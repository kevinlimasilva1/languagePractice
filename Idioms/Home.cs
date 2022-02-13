using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Collections;

namespace LanguagePractice
{
    public partial class Home : Form
    {
        public IDictionary<string, int> OpenedFile { get; set; }
        public string ConfigFilePath { get; set; }
        public int CurrentLanguage { get; set; }

        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();
            cbxLanguage.SelectedIndex = 0;

            this.CurrentLanguage = 0;
            OpenedFile = new Dictionary<string, int>();
            
            LoadPageData();
        }

        private void LoadPageData()
        {
            dtgWords.DataSource = null;
            dtgWords.Rows.Clear();
            cbxLanguage.Items.Clear();

            var languageDict = new Dictionary<string, int>();

            foreach (var line in OpenedFile)
            {
                var lineSplit = line.Key.Split(';');
                string[] dataLine = new string[lineSplit.Length + 1];

                string languageTemp = lineSplit[0];
                languageDict[languageTemp] = 0;

                for (int i = 0; i <= lineSplit.Length; i++)
                {
                    if (i == lineSplit.Length)
                    {
                        dataLine[i] = line.Value.ToString();
                        break;
                    }

                    dataLine[i] = lineSplit[i];
                }
                dtgWords.Rows.Add(dataLine);
            }

            foreach (var language in languageDict)
                cbxLanguage.Items.Add(language.Key);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!CheckConfigurationFile())
                return;

            var checkLanguage = cbxLanguage.SelectedIndex == 0;
            var checkNative = string.IsNullOrEmpty(txtNative.Text);
            var checkPhonetic = string.IsNullOrEmpty(txtPhonetic.Text);
            var checkTranslate = string.IsNullOrEmpty(txtNative.Text);

            if (checkLanguage || checkNative || checkPhonetic || checkTranslate)
            {
                MessageBox.Show("Atenção! Preencha todos os valores e selecione um idioma!");
                return;
            }

            var lineString = $"{cbxLanguage.SelectedItem.ToString()};{txtNative.Text};{txtPhonetic.Text};{txtTranslate.Text}";
            bool check = true;

            foreach (var line in OpenedFile){if (line.Key == lineString)check = false;}

            if (check)
            {
                using (StreamWriter sw = File.AppendText(ConfigFilePath))
                {
                    sw.WriteLine($"\n{lineString};0");
                }

                OpenedFile.Add(lineString, 0);

                MessageBox.Show("Palavra inserida com sucesso!");
                ClearInputsData();
                LoadPageData();
            }
            else
            {
                MessageBox.Show("Atenção! Encontrado informações duplicadas! Palavra não foi salva!");
            }
        }

        private void ClearInputsData()
        {
            txtNative.Text = "";
            txtPhonetic.Text = "";
            txtNative.Text = "";
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            if (!CheckConfigurationFile())
                return;

            var idiomaPratica = "";
            try
            {
                idiomaPratica = cbxLanguage.Items[this.CurrentLanguage].ToString();
                this.CurrentLanguage++;
            }
            catch (Exception)
            {
                idiomaPratica = cbxLanguage.Items[0].ToString();
                this.CurrentLanguage = 0;
            }

            try
            {
                lblNextLanguage.Text = cbxLanguage.Items[this.CurrentLanguage].ToString();
            }
            catch (Exception)
            {
                lblNextLanguage.Text = cbxLanguage.Items[0].ToString();
            }

            var palavras = GetWords(idiomaPratica);
            var palavraPratica = palavras[new Random().Next(0, palavras.Count)];
            
            new ToastContentBuilder()
                .AddArgument("action", "viewPratica")
                .AddArgument("praticaId", 9813)

                .AddText($"Vamos praticar {idiomaPratica}!")
                .AddText(palavraPratica)

                //.AddInputTextBox("tbDescricao", placeHolderContent: "Descrição fonética")
                //.AddInputTextBox("tbTraducao", placeHolderContent: "Tradução")

                //.AddButton(new ToastButton()
                //    .SetContent("Verificar")
                //    .AddArgument("action", "verificar")
                //    .SetAfterActivationBehavior(ToastAfterActivationBehavior.PendingUpdate))
                    
                .Show();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(){Title="Selecione o arquivo de configuração!", DefaultExt = "txt"};
            OpenedFile = new Dictionary<string, int>();
            lblFilePath.Text = "Arquivo de configuração não carregado!";
            ConfigFilePath = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != "Arquivo criado com sucesso" && line != "") {
                            var lineList = line.Split(';');
                            string notified = lineList[lineList.Length - 1];

                            OpenedFile.Add(line.Replace(";" + notified, ""), Int32.Parse(notified));
                        }
                    }
                }

                MessageBox.Show("Arquivo carregado com sucesso!");
                lblFilePath.Text = "Arquivo de configuração carregado!";
                ConfigFilePath = filePath;

                LoadPageData();
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string filePath = Path.Combine(fbd.SelectedPath, "languageConfig.txt");
                using (FileStream fs = File.Create(filePath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("Arquivo criado com sucesso");
                    fs.Write(info, 0, info.Length);
                }

                if (File.Exists(filePath))
                    MessageBox.Show("Arquivo criado com sucesso!");
            }
        }

        private bool CheckConfigurationFile()
        {
            if (string.IsNullOrEmpty(ConfigFilePath))
            {
                MessageBox.Show("Atenção! Arquivo de configuração não carregado!");
                btnOpenFile_Click(null, null);
                return false;
            }

            return true;
        }

        private List<string> GetWords(string language)
        {
            List<string> palavras = new List<string>();

            foreach (DataGridViewRow row in dtgWords.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == language)
                    palavras.Add(row.Cells[1].Value.ToString());
            }

            return palavras;
        }
    }
}

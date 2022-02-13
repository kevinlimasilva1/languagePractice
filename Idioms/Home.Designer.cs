
namespace LanguagePractice
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNotify = new System.Windows.Forms.Button();
            this.lblInfoNextLanguage = new System.Windows.Forms.Label();
            this.lblNextLanguage = new System.Windows.Forms.Label();
            this.txtNative = new System.Windows.Forms.TextBox();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.gbxHead = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.txtPhonetic = new System.Windows.Forms.TextBox();
            this.lblPhonetic = new System.Windows.Forms.Label();
            this.lblNative = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.dtgWords = new System.Windows.Forms.DataGridView();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NativeAlphabet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneticDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.gbxHead.SuspendLayout();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWords)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotify
            // 
            this.btnNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotify.Location = new System.Drawing.Point(4, 5);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(541, 73);
            this.btnNotify.TabIndex = 0;
            this.btnNotify.Text = "PRATICAR";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // lblInfoNextLanguage
            // 
            this.lblInfoNextLanguage.AutoSize = true;
            this.lblInfoNextLanguage.Location = new System.Drawing.Point(554, 23);
            this.lblInfoNextLanguage.Name = "lblInfoNextLanguage";
            this.lblInfoNextLanguage.Size = new System.Drawing.Size(103, 17);
            this.lblInfoNextLanguage.TabIndex = 0;
            this.lblInfoNextLanguage.Text = "Próximo idioma";
            // 
            // lblNextLanguage
            // 
            this.lblNextLanguage.AutoSize = true;
            this.lblNextLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextLanguage.Location = new System.Drawing.Point(553, 40);
            this.lblNextLanguage.Name = "lblNextLanguage";
            this.lblNextLanguage.Size = new System.Drawing.Size(58, 20);
            this.lblNextLanguage.TabIndex = 1;
            this.lblNextLanguage.Text = "Árabe";
            // 
            // txtNative
            // 
            this.txtNative.Location = new System.Drawing.Point(53, 120);
            this.txtNative.Name = "txtNative";
            this.txtNative.Size = new System.Drawing.Size(170, 22);
            this.txtNative.TabIndex = 3;
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "Selecione"});
            this.cbxLanguage.Location = new System.Drawing.Point(53, 62);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(170, 24);
            this.cbxLanguage.TabIndex = 4;
            // 
            // gbxHead
            // 
            this.gbxHead.Controls.Add(this.btnInsert);
            this.gbxHead.Controls.Add(this.txtTranslate);
            this.gbxHead.Controls.Add(this.lblTranslation);
            this.gbxHead.Controls.Add(this.txtPhonetic);
            this.gbxHead.Controls.Add(this.lblPhonetic);
            this.gbxHead.Controls.Add(this.lblNative);
            this.gbxHead.Controls.Add(this.lblLanguage);
            this.gbxHead.Controls.Add(this.txtNative);
            this.gbxHead.Controls.Add(this.cbxLanguage);
            this.gbxHead.Location = new System.Drawing.Point(12, 88);
            this.gbxHead.Name = "gbxHead";
            this.gbxHead.Size = new System.Drawing.Size(665, 167);
            this.gbxHead.TabIndex = 5;
            this.gbxHead.TabStop = false;
            this.gbxHead.Text = "Adicionar palavra";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(487, 44);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(137, 98);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "INSERIR";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtTranslate
            // 
            this.txtTranslate.Location = new System.Drawing.Point(277, 120);
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.Size = new System.Drawing.Size(170, 22);
            this.txtTranslate.TabIndex = 10;
            // 
            // lblTranslation
            // 
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Location = new System.Drawing.Point(277, 99);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(69, 17);
            this.lblTranslation.TabIndex = 9;
            this.lblTranslation.Text = "Tradução";
            // 
            // txtPhonetic
            // 
            this.txtPhonetic.Location = new System.Drawing.Point(277, 65);
            this.txtPhonetic.Name = "txtPhonetic";
            this.txtPhonetic.Size = new System.Drawing.Size(170, 22);
            this.txtPhonetic.TabIndex = 8;
            // 
            // lblPhonetic
            // 
            this.lblPhonetic.AutoSize = true;
            this.lblPhonetic.Location = new System.Drawing.Point(277, 44);
            this.lblPhonetic.Name = "lblPhonetic";
            this.lblPhonetic.Size = new System.Drawing.Size(125, 17);
            this.lblPhonetic.TabIndex = 7;
            this.lblPhonetic.Text = "Descrição fonética";
            // 
            // lblNative
            // 
            this.lblNative.AutoSize = true;
            this.lblNative.Location = new System.Drawing.Point(50, 100);
            this.lblNative.Name = "lblNative";
            this.lblNative.Size = new System.Drawing.Size(173, 17);
            this.lblNative.TabIndex = 6;
            this.lblNative.Text = "Palavra no alfabeto nativo";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(53, 39);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(127, 17);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "Selecione o idioma";
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.btnNotify);
            this.pnBottom.Controls.Add(this.lblNextLanguage);
            this.pnBottom.Controls.Add(this.lblInfoNextLanguage);
            this.pnBottom.Location = new System.Drawing.Point(12, 675);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(665, 84);
            this.pnBottom.TabIndex = 6;
            // 
            // dtgWords
            // 
            this.dtgWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Language,
            this.NativeAlphabet,
            this.PhoneticDescription,
            this.Translation,
            this.NotificationCount});
            this.dtgWords.Location = new System.Drawing.Point(12, 261);
            this.dtgWords.Name = "dtgWords";
            this.dtgWords.RowHeadersWidth = 51;
            this.dtgWords.RowTemplate.Height = 24;
            this.dtgWords.Size = new System.Drawing.Size(665, 408);
            this.dtgWords.TabIndex = 7;
            // 
            // Language
            // 
            this.Language.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Language.HeaderText = "Idioma";
            this.Language.MinimumWidth = 6;
            this.Language.Name = "Language";
            this.Language.Width = 78;
            // 
            // NativeAlphabet
            // 
            this.NativeAlphabet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NativeAlphabet.HeaderText = "Palavra no alfabeto nativo";
            this.NativeAlphabet.MinimumWidth = 6;
            this.NativeAlphabet.Name = "NativeAlphabet";
            this.NativeAlphabet.Width = 150;
            // 
            // PhoneticDescription
            // 
            this.PhoneticDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhoneticDescription.HeaderText = "Descrição Fonética";
            this.PhoneticDescription.MinimumWidth = 6;
            this.PhoneticDescription.Name = "PhoneticDescription";
            this.PhoneticDescription.Width = 145;
            // 
            // Translation
            // 
            this.Translation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Translation.HeaderText = "Tradução";
            this.Translation.MinimumWidth = 6;
            this.Translation.Name = "Translation";
            this.Translation.Width = 98;
            // 
            // NotificationCount
            // 
            this.NotificationCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NotificationCount.HeaderText = "Contagem de notificação";
            this.NotificationCount.MinimumWidth = 6;
            this.NotificationCount.Name = "NotificationCount";
            this.NotificationCount.Width = 176;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFilePath);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnCreateFile);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 70);
            this.panel1.TabIndex = 8;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(34, 26);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFilePath.Size = new System.Drawing.Size(262, 17);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "Arquivo de configuração não carregado!";
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(331, 8);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(160, 52);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Carregar arquivo \r\nde configuração";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(497, 8);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(160, 52);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Criar arquivo \r\nde configuração";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgWords);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.gbxHead);
            this.Name = "Home";
            this.Text = "Tela principal";
            this.gbxHead.ResumeLayout(false);
            this.gbxHead.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWords)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.Label lblInfoNextLanguage;
        private System.Windows.Forms.Label lblNextLanguage;
        private System.Windows.Forms.TextBox txtNative;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.GroupBox gbxHead;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtTranslate;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.TextBox txtPhonetic;
        private System.Windows.Forms.Label lblPhonetic;
        private System.Windows.Forms.Label lblNative;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.DataGridView dtgWords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn NativeAlphabet;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneticDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationCount;
    }
}


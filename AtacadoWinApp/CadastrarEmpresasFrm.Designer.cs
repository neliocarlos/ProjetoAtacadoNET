namespace AtacadoWinApp
{
    partial class CadastrarEmpresasFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CodigoLbl = new System.Windows.Forms.Label();
            this.CnpjLbl = new System.Windows.Forms.Label();
            this.InscEstadualLbl = new System.Windows.Forms.Label();
            this.NomeFantasiaLbl = new System.Windows.Forms.Label();
            this.RazaoSocialLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.EnderecoLbl = new System.Windows.Forms.Label();
            this.TelefoneLbl = new System.Windows.Forms.Label();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.CnpjTxt = new System.Windows.Forms.TextBox();
            this.NomeFantasiaTxt = new System.Windows.Forms.TextBox();
            this.EnderecoTxt = new System.Windows.Forms.TextBox();
            this.TelefoneTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.InscEstadualTxt = new System.Windows.Forms.TextBox();
            this.RazaoSocialTxt = new System.Windows.Forms.TextBox();
            this.FecharBtn = new System.Windows.Forms.Button();
            this.ValidarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(72, 15);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(49, 15);
            this.CodigoLbl.TabIndex = 0;
            this.CodigoLbl.Text = "Código:";
            // 
            // CnpjLbl
            // 
            this.CnpjLbl.AutoSize = true;
            this.CnpjLbl.Location = new System.Drawing.Point(84, 44);
            this.CnpjLbl.Name = "CnpjLbl";
            this.CnpjLbl.Size = new System.Drawing.Size(37, 15);
            this.CnpjLbl.TabIndex = 1;
            this.CnpjLbl.Text = "CNPJ:";
            this.CnpjLbl.Click += new System.EventHandler(this.CnpjLbl_Click);
            // 
            // InscEstadualLbl
            // 
            this.InscEstadualLbl.AutoSize = true;
            this.InscEstadualLbl.Location = new System.Drawing.Point(17, 73);
            this.InscEstadualLbl.Name = "InscEstadualLbl";
            this.InscEstadualLbl.Size = new System.Drawing.Size(104, 15);
            this.InscEstadualLbl.TabIndex = 2;
            this.InscEstadualLbl.Text = "Inscrição Estadual:";
            // 
            // NomeFantasiaLbl
            // 
            this.NomeFantasiaLbl.AutoSize = true;
            this.NomeFantasiaLbl.Location = new System.Drawing.Point(32, 102);
            this.NomeFantasiaLbl.Name = "NomeFantasiaLbl";
            this.NomeFantasiaLbl.Size = new System.Drawing.Size(89, 15);
            this.NomeFantasiaLbl.TabIndex = 3;
            this.NomeFantasiaLbl.Text = "Nome Fantasia:";
            this.NomeFantasiaLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // RazaoSocialLbl
            // 
            this.RazaoSocialLbl.AutoSize = true;
            this.RazaoSocialLbl.Location = new System.Drawing.Point(46, 131);
            this.RazaoSocialLbl.Name = "RazaoSocialLbl";
            this.RazaoSocialLbl.Size = new System.Drawing.Size(75, 15);
            this.RazaoSocialLbl.TabIndex = 4;
            this.RazaoSocialLbl.Text = "Razão Social:";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(82, 160);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(39, 15);
            this.EmailLbl.TabIndex = 5;
            this.EmailLbl.Text = "Email:";
            // 
            // EnderecoLbl
            // 
            this.EnderecoLbl.AutoSize = true;
            this.EnderecoLbl.Location = new System.Drawing.Point(62, 189);
            this.EnderecoLbl.Name = "EnderecoLbl";
            this.EnderecoLbl.Size = new System.Drawing.Size(59, 15);
            this.EnderecoLbl.TabIndex = 6;
            this.EnderecoLbl.Text = "Endereço:";
            // 
            // TelefoneLbl
            // 
            this.TelefoneLbl.AutoSize = true;
            this.TelefoneLbl.Location = new System.Drawing.Point(67, 218);
            this.TelefoneLbl.Name = "TelefoneLbl";
            this.TelefoneLbl.Size = new System.Drawing.Size(54, 15);
            this.TelefoneLbl.TabIndex = 7;
            this.TelefoneLbl.Text = "Telefone:";
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(124, 12);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.ReadOnly = true;
            this.CodigoTxt.Size = new System.Drawing.Size(125, 23);
            this.CodigoTxt.TabIndex = 8;
            // 
            // CnpjTxt
            // 
            this.CnpjTxt.Location = new System.Drawing.Point(124, 41);
            this.CnpjTxt.Name = "CnpjTxt";
            this.CnpjTxt.Size = new System.Drawing.Size(185, 23);
            this.CnpjTxt.TabIndex = 9;
            // 
            // NomeFantasiaTxt
            // 
            this.NomeFantasiaTxt.Location = new System.Drawing.Point(124, 99);
            this.NomeFantasiaTxt.Name = "NomeFantasiaTxt";
            this.NomeFantasiaTxt.Size = new System.Drawing.Size(274, 23);
            this.NomeFantasiaTxt.TabIndex = 10;
            // 
            // EnderecoTxt
            // 
            this.EnderecoTxt.Location = new System.Drawing.Point(124, 186);
            this.EnderecoTxt.Name = "EnderecoTxt";
            this.EnderecoTxt.Size = new System.Drawing.Size(274, 23);
            this.EnderecoTxt.TabIndex = 11;
            // 
            // TelefoneTxt
            // 
            this.TelefoneTxt.Location = new System.Drawing.Point(124, 215);
            this.TelefoneTxt.Name = "TelefoneTxt";
            this.TelefoneTxt.Size = new System.Drawing.Size(185, 23);
            this.TelefoneTxt.TabIndex = 12;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(124, 157);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(274, 23);
            this.EmailTxt.TabIndex = 13;
            // 
            // InscEstadualTxt
            // 
            this.InscEstadualTxt.Location = new System.Drawing.Point(124, 70);
            this.InscEstadualTxt.Name = "InscEstadualTxt";
            this.InscEstadualTxt.Size = new System.Drawing.Size(185, 23);
            this.InscEstadualTxt.TabIndex = 14;
            // 
            // RazaoSocialTxt
            // 
            this.RazaoSocialTxt.Location = new System.Drawing.Point(124, 128);
            this.RazaoSocialTxt.Name = "RazaoSocialTxt";
            this.RazaoSocialTxt.Size = new System.Drawing.Size(274, 23);
            this.RazaoSocialTxt.TabIndex = 15;
            // 
            // FecharBtn
            // 
            this.FecharBtn.Location = new System.Drawing.Point(713, 415);
            this.FecharBtn.Name = "FecharBtn";
            this.FecharBtn.Size = new System.Drawing.Size(75, 23);
            this.FecharBtn.TabIndex = 16;
            this.FecharBtn.Text = "Fechar";
            this.FecharBtn.UseVisualStyleBackColor = true;
            this.FecharBtn.Click += new System.EventHandler(this.FecharBtn_Click);
            // 
            // ValidarBtn
            // 
            this.ValidarBtn.Location = new System.Drawing.Point(632, 415);
            this.ValidarBtn.Name = "ValidarBtn";
            this.ValidarBtn.Size = new System.Drawing.Size(75, 23);
            this.ValidarBtn.TabIndex = 17;
            this.ValidarBtn.Text = "Validar";
            this.ValidarBtn.UseVisualStyleBackColor = true;
            this.ValidarBtn.Click += new System.EventHandler(this.ValidarBtn_Click);
            // 
            // CadastrarEmpresasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValidarBtn);
            this.Controls.Add(this.FecharBtn);
            this.Controls.Add(this.RazaoSocialTxt);
            this.Controls.Add(this.InscEstadualTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.TelefoneTxt);
            this.Controls.Add(this.EnderecoTxt);
            this.Controls.Add(this.NomeFantasiaTxt);
            this.Controls.Add(this.CnpjTxt);
            this.Controls.Add(this.CodigoTxt);
            this.Controls.Add(this.TelefoneLbl);
            this.Controls.Add(this.EnderecoLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.RazaoSocialLbl);
            this.Controls.Add(this.NomeFantasiaLbl);
            this.Controls.Add(this.InscEstadualLbl);
            this.Controls.Add(this.CnpjLbl);
            this.Controls.Add(this.CodigoLbl);
            this.Name = "CadastrarEmpresasFrm";
            this.Text = "CadastrarEmpresasFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CodigoLbl;
        private Label CnpjLbl;
        private Label InscEstadualLbl;
        private Label NomeFantasiaLbl;
        private Label RazaoSocialLbl;
        private Label EmailLbl;
        private Label EnderecoLbl;
        private Label TelefoneLbl;
        private TextBox CodigoTxt;
        private TextBox CnpjTxt;
        private TextBox NomeFantasiaTxt;
        private TextBox EnderecoTxt;
        private TextBox TelefoneTxt;
        private TextBox EmailTxt;
        private TextBox InscEstadualTxt;
        private TextBox RazaoSocialTxt;
        private Button FecharBtn;
        private Button ValidarBtn;
    }
}
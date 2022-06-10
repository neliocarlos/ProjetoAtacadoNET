namespace AtacadoWinApp
{
    partial class AdicionarFuncionariosFrm
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
            this.TelefoneLbl = new System.Windows.Forms.Label();
            this.NomeLbl = new System.Windows.Forms.Label();
            this.SobrenomeLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.EnderecoLbl = new System.Windows.Forms.Label();
            this.IdadeLbl = new System.Windows.Forms.Label();
            this.AlturaLbl = new System.Windows.Forms.Label();
            this.PesoLbl = new System.Windows.Forms.Label();
            this.DtNascimentoLbl = new System.Windows.Forms.Label();
            this.NaturalidadeLbl = new System.Windows.Forms.Label();
            this.NacionalidadeLbl = new System.Windows.Forms.Label();
            this.SexoLbl = new System.Windows.Forms.Label();
            this.RgLbl = new System.Windows.Forms.Label();
            this.CpfLbl = new System.Windows.Forms.Label();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.NomeTxt = new System.Windows.Forms.TextBox();
            this.SobrenomeTxt = new System.Windows.Forms.TextBox();
            this.TelefoneTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EnderecoTxt = new System.Windows.Forms.TextBox();
            this.IdadeTxt = new System.Windows.Forms.TextBox();
            this.AlturaTxt = new System.Windows.Forms.TextBox();
            this.PesoTxt = new System.Windows.Forms.TextBox();
            this.NaturalidadeTxt = new System.Windows.Forms.TextBox();
            this.NacionalidadeTxt = new System.Windows.Forms.TextBox();
            this.RgTxt = new System.Windows.Forms.TextBox();
            this.CpfTxt = new System.Windows.Forms.TextBox();
            this.DtNascimentoDtPicker = new System.Windows.Forms.DateTimePicker();
            this.SexoCmb = new System.Windows.Forms.ComboBox();
            this.FecharBtn = new System.Windows.Forms.Button();
            this.AdicionarBtn = new System.Windows.Forms.Button();
            this.TesteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(79, 20);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(49, 15);
            this.CodigoLbl.TabIndex = 0;
            this.CodigoLbl.Text = "Código:";
            this.CodigoLbl.Click += new System.EventHandler(this.CodigoLbl_Click);
            // 
            // TelefoneLbl
            // 
            this.TelefoneLbl.AutoSize = true;
            this.TelefoneLbl.Location = new System.Drawing.Point(361, 78);
            this.TelefoneLbl.Name = "TelefoneLbl";
            this.TelefoneLbl.Size = new System.Drawing.Size(54, 15);
            this.TelefoneLbl.TabIndex = 1;
            this.TelefoneLbl.Text = "Telefone:";
            // 
            // NomeLbl
            // 
            this.NomeLbl.AutoSize = true;
            this.NomeLbl.Location = new System.Drawing.Point(85, 49);
            this.NomeLbl.Name = "NomeLbl";
            this.NomeLbl.Size = new System.Drawing.Size(43, 15);
            this.NomeLbl.TabIndex = 2;
            this.NomeLbl.Text = "Nome:";
            // 
            // SobrenomeLbl
            // 
            this.SobrenomeLbl.AutoSize = true;
            this.SobrenomeLbl.Location = new System.Drawing.Point(344, 49);
            this.SobrenomeLbl.Name = "SobrenomeLbl";
            this.SobrenomeLbl.Size = new System.Drawing.Size(71, 15);
            this.SobrenomeLbl.TabIndex = 3;
            this.SobrenomeLbl.Text = "Sobrenome:";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(89, 78);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(39, 15);
            this.EmailLbl.TabIndex = 4;
            this.EmailLbl.Text = "Email:";
            // 
            // EnderecoLbl
            // 
            this.EnderecoLbl.AutoSize = true;
            this.EnderecoLbl.Location = new System.Drawing.Point(69, 107);
            this.EnderecoLbl.Name = "EnderecoLbl";
            this.EnderecoLbl.Size = new System.Drawing.Size(59, 15);
            this.EnderecoLbl.TabIndex = 5;
            this.EnderecoLbl.Text = "Endereço:";
            // 
            // IdadeLbl
            // 
            this.IdadeLbl.AutoSize = true;
            this.IdadeLbl.Location = new System.Drawing.Point(363, 223);
            this.IdadeLbl.Name = "IdadeLbl";
            this.IdadeLbl.Size = new System.Drawing.Size(39, 15);
            this.IdadeLbl.TabIndex = 6;
            this.IdadeLbl.Text = "Idade:";
            // 
            // AlturaLbl
            // 
            this.AlturaLbl.AutoSize = true;
            this.AlturaLbl.Location = new System.Drawing.Point(86, 194);
            this.AlturaLbl.Name = "AlturaLbl";
            this.AlturaLbl.Size = new System.Drawing.Size(42, 15);
            this.AlturaLbl.TabIndex = 7;
            this.AlturaLbl.Text = "Altura:";
            // 
            // PesoLbl
            // 
            this.PesoLbl.AutoSize = true;
            this.PesoLbl.Location = new System.Drawing.Point(191, 194);
            this.PesoLbl.Name = "PesoLbl";
            this.PesoLbl.Size = new System.Drawing.Size(35, 15);
            this.PesoLbl.TabIndex = 8;
            this.PesoLbl.Text = "Peso:";
            // 
            // DtNascimentoLbl
            // 
            this.DtNascimentoLbl.AutoSize = true;
            this.DtNascimentoLbl.Location = new System.Drawing.Point(11, 223);
            this.DtNascimentoLbl.Name = "DtNascimentoLbl";
            this.DtNascimentoLbl.Size = new System.Drawing.Size(117, 15);
            this.DtNascimentoLbl.TabIndex = 9;
            this.DtNascimentoLbl.Text = "Data de Nascimento:";
            this.DtNascimentoLbl.Click += new System.EventHandler(this.label10_Click);
            // 
            // NaturalidadeLbl
            // 
            this.NaturalidadeLbl.AutoSize = true;
            this.NaturalidadeLbl.Location = new System.Drawing.Point(275, 136);
            this.NaturalidadeLbl.Name = "NaturalidadeLbl";
            this.NaturalidadeLbl.Size = new System.Drawing.Size(78, 15);
            this.NaturalidadeLbl.TabIndex = 10;
            this.NaturalidadeLbl.Text = "Naturalidade:";
            this.NaturalidadeLbl.Click += new System.EventHandler(this.label11_Click);
            // 
            // NacionalidadeLbl
            // 
            this.NacionalidadeLbl.AutoSize = true;
            this.NacionalidadeLbl.Location = new System.Drawing.Point(42, 136);
            this.NacionalidadeLbl.Name = "NacionalidadeLbl";
            this.NacionalidadeLbl.Size = new System.Drawing.Size(86, 15);
            this.NacionalidadeLbl.TabIndex = 11;
            this.NacionalidadeLbl.Text = "Nacionalidade:";
            this.NacionalidadeLbl.Click += new System.EventHandler(this.label12_Click);
            // 
            // SexoLbl
            // 
            this.SexoLbl.AutoSize = true;
            this.SexoLbl.Location = new System.Drawing.Point(292, 194);
            this.SexoLbl.Name = "SexoLbl";
            this.SexoLbl.Size = new System.Drawing.Size(35, 15);
            this.SexoLbl.TabIndex = 12;
            this.SexoLbl.Text = "Sexo:";
            // 
            // RgLbl
            // 
            this.RgLbl.AutoSize = true;
            this.RgLbl.Location = new System.Drawing.Point(103, 160);
            this.RgLbl.Name = "RgLbl";
            this.RgLbl.Size = new System.Drawing.Size(25, 15);
            this.RgLbl.TabIndex = 13;
            this.RgLbl.Text = "RG:";
            // 
            // CpfLbl
            // 
            this.CpfLbl.AutoSize = true;
            this.CpfLbl.Location = new System.Drawing.Point(322, 160);
            this.CpfLbl.Name = "CpfLbl";
            this.CpfLbl.Size = new System.Drawing.Size(31, 15);
            this.CpfLbl.TabIndex = 14;
            this.CpfLbl.Text = "CPF:";
            this.CpfLbl.Click += new System.EventHandler(this.label15_Click);
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(134, 12);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.ReadOnly = true;
            this.CodigoTxt.Size = new System.Drawing.Size(100, 23);
            this.CodigoTxt.TabIndex = 15;
            // 
            // NomeTxt
            // 
            this.NomeTxt.Location = new System.Drawing.Point(134, 41);
            this.NomeTxt.Name = "NomeTxt";
            this.NomeTxt.Size = new System.Drawing.Size(200, 23);
            this.NomeTxt.TabIndex = 16;
            // 
            // SobrenomeTxt
            // 
            this.SobrenomeTxt.Location = new System.Drawing.Point(421, 41);
            this.SobrenomeTxt.Name = "SobrenomeTxt";
            this.SobrenomeTxt.Size = new System.Drawing.Size(200, 23);
            this.SobrenomeTxt.TabIndex = 17;
            // 
            // TelefoneTxt
            // 
            this.TelefoneTxt.Location = new System.Drawing.Point(421, 70);
            this.TelefoneTxt.Name = "TelefoneTxt";
            this.TelefoneTxt.Size = new System.Drawing.Size(200, 23);
            this.TelefoneTxt.TabIndex = 18;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(134, 70);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(200, 23);
            this.EmailTxt.TabIndex = 19;
            // 
            // EnderecoTxt
            // 
            this.EnderecoTxt.Location = new System.Drawing.Point(134, 99);
            this.EnderecoTxt.Name = "EnderecoTxt";
            this.EnderecoTxt.Size = new System.Drawing.Size(487, 23);
            this.EnderecoTxt.TabIndex = 20;
            // 
            // IdadeTxt
            // 
            this.IdadeTxt.Location = new System.Drawing.Point(408, 215);
            this.IdadeTxt.Name = "IdadeTxt";
            this.IdadeTxt.ReadOnly = true;
            this.IdadeTxt.Size = new System.Drawing.Size(46, 23);
            this.IdadeTxt.TabIndex = 21;
            // 
            // AlturaTxt
            // 
            this.AlturaTxt.Location = new System.Drawing.Point(134, 186);
            this.AlturaTxt.Name = "AlturaTxt";
            this.AlturaTxt.Size = new System.Drawing.Size(46, 23);
            this.AlturaTxt.TabIndex = 22;
            // 
            // PesoTxt
            // 
            this.PesoTxt.Location = new System.Drawing.Point(232, 186);
            this.PesoTxt.Name = "PesoTxt";
            this.PesoTxt.Size = new System.Drawing.Size(46, 23);
            this.PesoTxt.TabIndex = 23;
            // 
            // NaturalidadeTxt
            // 
            this.NaturalidadeTxt.Location = new System.Drawing.Point(359, 128);
            this.NaturalidadeTxt.Name = "NaturalidadeTxt";
            this.NaturalidadeTxt.Size = new System.Drawing.Size(135, 23);
            this.NaturalidadeTxt.TabIndex = 25;
            // 
            // NacionalidadeTxt
            // 
            this.NacionalidadeTxt.Location = new System.Drawing.Point(134, 128);
            this.NacionalidadeTxt.Name = "NacionalidadeTxt";
            this.NacionalidadeTxt.Size = new System.Drawing.Size(135, 23);
            this.NacionalidadeTxt.TabIndex = 26;
            // 
            // RgTxt
            // 
            this.RgTxt.Location = new System.Drawing.Point(134, 157);
            this.RgTxt.Name = "RgTxt";
            this.RgTxt.Size = new System.Drawing.Size(135, 23);
            this.RgTxt.TabIndex = 27;
            // 
            // CpfTxt
            // 
            this.CpfTxt.Location = new System.Drawing.Point(359, 157);
            this.CpfTxt.Name = "CpfTxt";
            this.CpfTxt.Size = new System.Drawing.Size(135, 23);
            this.CpfTxt.TabIndex = 28;
            // 
            // DtNascimentoDtPicker
            // 
            this.DtNascimentoDtPicker.Location = new System.Drawing.Point(134, 215);
            this.DtNascimentoDtPicker.Name = "DtNascimentoDtPicker";
            this.DtNascimentoDtPicker.Size = new System.Drawing.Size(200, 23);
            this.DtNascimentoDtPicker.TabIndex = 30;
            // 
            // SexoCmb
            // 
            this.SexoCmb.FormattingEnabled = true;
            this.SexoCmb.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.SexoCmb.Location = new System.Drawing.Point(333, 186);
            this.SexoCmb.Name = "SexoCmb";
            this.SexoCmb.Size = new System.Drawing.Size(121, 23);
            this.SexoCmb.TabIndex = 31;
            // 
            // FecharBtn
            // 
            this.FecharBtn.Location = new System.Drawing.Point(713, 415);
            this.FecharBtn.Name = "FecharBtn";
            this.FecharBtn.Size = new System.Drawing.Size(75, 23);
            this.FecharBtn.TabIndex = 32;
            this.FecharBtn.Text = "Fechar";
            this.FecharBtn.UseVisualStyleBackColor = true;
            this.FecharBtn.Click += new System.EventHandler(this.FecharBtn_Click);
            // 
            // AdicionarBtn
            // 
            this.AdicionarBtn.Location = new System.Drawing.Point(632, 415);
            this.AdicionarBtn.Name = "AdicionarBtn";
            this.AdicionarBtn.Size = new System.Drawing.Size(75, 23);
            this.AdicionarBtn.TabIndex = 34;
            this.AdicionarBtn.Text = "Adicionar";
            this.AdicionarBtn.UseVisualStyleBackColor = true;
            this.AdicionarBtn.Click += new System.EventHandler(this.AdicionarBtn_Click);
            // 
            // AdicionarFuncionariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TesteBtn);
            this.Controls.Add(this.AdicionarBtn);
            this.Controls.Add(this.FecharBtn);
            this.Controls.Add(this.SexoCmb);
            this.Controls.Add(this.DtNascimentoDtPicker);
            this.Controls.Add(this.CpfTxt);
            this.Controls.Add(this.RgTxt);
            this.Controls.Add(this.NacionalidadeTxt);
            this.Controls.Add(this.NaturalidadeTxt);
            this.Controls.Add(this.PesoTxt);
            this.Controls.Add(this.AlturaTxt);
            this.Controls.Add(this.IdadeTxt);
            this.Controls.Add(this.EnderecoTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.TelefoneTxt);
            this.Controls.Add(this.SobrenomeTxt);
            this.Controls.Add(this.NomeTxt);
            this.Controls.Add(this.CodigoTxt);
            this.Controls.Add(this.CpfLbl);
            this.Controls.Add(this.RgLbl);
            this.Controls.Add(this.SexoLbl);
            this.Controls.Add(this.NacionalidadeLbl);
            this.Controls.Add(this.NaturalidadeLbl);
            this.Controls.Add(this.DtNascimentoLbl);
            this.Controls.Add(this.PesoLbl);
            this.Controls.Add(this.AlturaLbl);
            this.Controls.Add(this.IdadeLbl);
            this.Controls.Add(this.EnderecoLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.SobrenomeLbl);
            this.Controls.Add(this.NomeLbl);
            this.Controls.Add(this.TelefoneLbl);
            this.Controls.Add(this.CodigoLbl);
            this.Name = "AdicionarFuncionariosFrm";
            this.Text = "Adicionar Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CodigoLbl;
        private Label TelefoneLbl;
        private Label NomeLbl;
        private Label SobrenomeLbl;
        private Label EmailLbl;
        private Label EnderecoLbl;
        private Label IdadeLbl;
        private Label AlturaLbl;
        private Label PesoLbl;
        private Label DtNascimentoLbl;
        private Label NaturalidadeLbl;
        private Label NacionalidadeLbl;
        private Label SexoLbl;
        private Label RgLbl;
        private Label CpfLbl;
        private TextBox CodigoTxt;
        private TextBox NomeTxt;
        private TextBox SobrenomeTxt;
        private TextBox TelefoneTxt;
        private TextBox EmailTxt;
        private TextBox EnderecoTxt;
        private TextBox IdadeTxt;
        private TextBox AlturaTxt;
        private TextBox PesoTxt;
        private TextBox NaturalidadeTxt;
        private TextBox NacionalidadeTxt;
        private TextBox RgTxt;
        private TextBox CpfTxt;
        private DateTimePicker DtNascimentoDtPicker;
        private ComboBox SexoCmb;
        private Button FecharBtn;
        private Button AdicionarBtn;
        private Button TesteBtn;
    }
}
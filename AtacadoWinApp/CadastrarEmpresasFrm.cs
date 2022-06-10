using Atacado.POCO.RH;
using Atacado.Service.RH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtacadoWinApp
{
    public partial class CadastrarEmpresasFrm : Form
    {
        public CadastrarEmpresasFrm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CnpjLbl_Click(object sender, EventArgs e)
        {

        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidarBtn_Click(object sender, EventArgs e)
        {
            EmpresaPOCO poco = new EmpresaPOCO()
            {
                Cnpj = CnpjTxt.Text,
                InscricaoEstadual = InscEstadualTxt.Text,
                NomeFantasia = NomeFantasiaTxt.Text,
                RazaoSocial = RazaoSocialTxt.Text,
                Email = EmailTxt.Text,
                Endereco = EnderecoTxt.Text,
                Telefone = TelefoneTxt.Text,
            };


            EmpresaService srv = new EmpresaService();
            if (srv.Validar(poco) == false)
            {
                string mensagem = srv.MensagensDeErro.Aggregate((x, y) => x + ";\n" + y);
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mensagem = "- CNPJ válido.";
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
    }
}

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
    public partial class AdicionarFuncionariosFrm : Form
    {
        public AdicionarFuncionariosFrm()
        {
            InitializeComponent();
            //PreencherSexoCmb();
        }

        private void CodigoLbl_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarBtn_Click(object sender, EventArgs e)
        {
            FuncionarioPOCO poco = new FuncionarioPOCO()
            {
                Cpf = CpfTxt.Text,
                Nome = NomeTxt.Text,
                SobreNome = SobrenomeTxt.Text,
                Email = EmailTxt.Text,
                Telefone = TelefoneTxt.Text,
                Endereco = EnderecoTxt.Text,
                Nacionalidade = NacionalidadeTxt.Text,
                Naturalidade = NaturalidadeTxt.Text,
                Rg = RgTxt.Text,
                DtNascimento = DtNascimentoDtPicker.Value,
                //Sexo = SexoCmb.SelectedItem.ToString(),
            };

            FuncionarioService srv = new FuncionarioService();
            if (srv.Validar(poco) == false)
            {
                string mensagem = srv.MensagensDeErro.Aggregate((x, y) => x + ";\n" + y);
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mensagem = "- CPF válido.";
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        //private void PreencherSexoCmb(FuncionarioPOCO funcionario)
        //{
        //    //FuncionarioPOCO funcionario = new FuncionarioPOCO();
        //    //if (SexoCmb.SelectedItem.ToString() == "Masculino")
        //    //{
        //    //    this.funcionario.Sexo = "M";
        //    //}
        //    //else
        //    //    this.funcionario.Sexo = "F";

        //    SexoCmb.Items.Clear();

        //    SexoCmb.DisplayMember = "Value";
        //    SexoCmb.ValueMember = "Key";

        //    Dictionary<string, string> itens = new Dictionary<string, string>();
        //    itens.Add("M", "Masculino");
        //    itens.Add("F", "Feminino");

        //    SexoCmb.DataSource = new BindingSource(itens, null);

        //    SexoCmb.SelectedIndex = 0;
        //}

        //private void TesteBtn_Click(object sender, EventArgs e)
        //{
        //    if (SexoCmb.SelectedIndex == -1)
        //        MessageBox.Show("ERRO");
        //    else
        //    {
        //        string texto = SexoCmb.SelectedValue.ToString();
        //        MessageBox.Show(texto);
        //    }
        //}
    }
}

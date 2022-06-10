using Atacado.POCO.RH;
using Atacado.Service.RH;

namespace AtacadoWinApp
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void OiMundoBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Oi Mundo!");
            //MessageBox.Show("Oi Mundo!", "Mensagem");
            MessageBox.Show("Oi Mundo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarFuncionarioMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFuncionariosFrm frm = new AdicionarFuncionariosFrm();
            frm.ShowDialog();
        }

        private void CadastrarEmpresaMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarEmpresasFrm frm = new CadastrarEmpresasFrm();
            frm.ShowDialog();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void ValidarBtn_Click(object sender, EventArgs e)
        //{
        //    FuncionarioPOCO poco = new FuncionarioPOCO()
        //    {
        //        Cpf = CpfTxt.Text
        //    };

        //    FuncionarioService srv = new FuncionarioService();
        //    if (srv.Validar(poco) == false)
        //    {
        //        string mensagem = srv.MensagensDeErro.Aggregate((x, y) => x + ";" + y);
        //        MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        string mensagem = "- CPF válido.";
        //        MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    return;
        //}

    }
}
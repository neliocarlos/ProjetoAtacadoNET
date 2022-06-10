using Atacado.Domain.RH;
using Atacado.Business.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Business.RH
{
    public class EmpresaBizz : BaseAncestralBizz
    {
        public EmpresaBizz() : base()
        { }

        public bool Executar(Empresa obj)
        {
            Empresa empresa = obj;

            bool resultado = true;

			if (this.ValidarCnpjVazio(empresa.Cnpj) == false)
			{
				this.mensagens.Add("- CNPJ não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarCnpj(empresa.Cnpj) == false)
			{
				this.mensagens.Add("- CNPJ inválido");
				resultado = false;
			}

			if (this.ValidarInscricaoEstadualVazia(empresa.InscricaoEstadual) == false)
			{
				this.mensagens.Add("- Inscrição Estadual não pode ser vazia.");
				resultado = false;
			}

			if (this.ValidarEmailVazio(empresa.Email) == false)
			{
				this.mensagens.Add("- Email não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarEmail(empresa.Email) == false)
            {
				this.mensagens.Add("- Email inválido.");
				resultado = false;
            }

			if (this.ValidarRazaoSocialVazio(empresa.RazaoSocial) == false)
			{
				this.mensagens.Add("- Razão Social não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarNomeFantasiaVazio(empresa.NomeFantasia) == false)
			{
				this.mensagens.Add("- Nome Fantasia não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarEnderecoVazio(empresa.Endereco) == false)
			{
				this.mensagens.Add("- Endereco não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarTelefoneVazio(empresa.Telefone) == false)
			{
				this.mensagens.Add("- Número de telefone não pode ser vazio.");
				resultado = false;
			}

			if (this.ValidarTelefone(empresa.Telefone) == false)
			{
				this.mensagens.Add("- Telefone inválido");
				resultado = false;
			}

			return resultado;
		}

        private bool ValidarCnpjVazio(string cnpj)
        {
            return !(cnpj == String.Empty);
        }

		private bool ValidarCnpj(string cnpj)
		{
			int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int soma;
			int resto;
			string digito;
			string tempCnpj;
			cnpj = cnpj.Trim();
			cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
			if (cnpj.Length != 14)
				return false;
			tempCnpj = cnpj.Substring(0, 12);
			soma = 0;
			for (int i = 0; i < 12; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCnpj = tempCnpj + digito;
			soma = 0;
			for (int i = 0; i < 13; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cnpj.EndsWith(digito);
		}

		private bool ValidarInscricaoEstadualVazia(string inscEstadual)
        {
			return !(inscEstadual == String.Empty);
		}

		private bool ValidarInscricaoEstadualDigitos(string inscEstadual)
		{
			if (string.IsNullOrEmpty(inscEstadual) != true)
			{
				if ((inscEstadual.Length <= 13) && (inscEstadual.Length > 14))
				{
					return false;
				}
				else
					return true;
			}
			else
				return false;
		}

		//private bool ValidarInscricaoEstadual(string inscEstadual)
		//      {

		//      }

		private bool ValidarEmailVazio(string email)
		{
			return !(string.IsNullOrEmpty(email));
		}

		private bool ValidarEmail(string email)
        {
			bool ValidEmail = false;
			int indexArr = email.IndexOf("@");

			if (indexArr > 0)
			{
				int indexDot = email.IndexOf(".", indexArr);
				if (indexDot - 1 > indexArr)
				{
					if (indexDot + 1 < email.Length)
					{
						string indexDot2 = email.Substring(indexDot + 1, 1);
						if (indexDot2 != ".")
						{
							ValidEmail = true;
						}
					}
				}
			}
			return ValidEmail;
		}

		private bool ValidarRazaoSocialVazio(string razaoSocial)
		{
			return !(string.IsNullOrEmpty(razaoSocial));
		}

		private bool ValidarNomeFantasiaVazio(string nomeFantasia)
		{
			return !(string.IsNullOrEmpty(nomeFantasia));
		}

		private bool ValidarEnderecoVazio(string endereco)
		{
			return !(string.IsNullOrEmpty(endereco));
		}

		private bool ValidarTelefoneVazio(string telefone)
        {
			return !(string.IsNullOrEmpty(telefone));
        }

		private bool ValidarTelefone(string telefone)
		{
			if (string.IsNullOrEmpty(telefone) != true)
			{
				if ((telefone.Length < 10) || (telefone.Length > 11))
				{
					return false;
				}
				else
					return true;
			}
			else
				return false;
		}
	}
}

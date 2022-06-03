using Atacado.DAL.Ancestral;
using Atacado.FakeDB.RH;
using Atacado.Modelo.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.RH
{
    public class FuncionarioDAO : BaseAncestralDAO<Funcionario>
    {
        public override Funcionario Create(Funcionario obj)
        {
            int chave = FuncionarioFakeDB.Funcionarios.Max(fun => fun.Codigo) + 1;
            FuncionarioFakeDB.Funcionarios.Add(obj);
            return obj;
        }

        public override Funcionario Delete(int id)
        {
            Funcionario del = this.Read(id);
            FuncionarioFakeDB.Funcionarios.Remove(del);
            return del;
        }

        public override Funcionario Delete(Funcionario obj)
        {
            return this.Delete(obj.Codigo);
        }

        public override Funcionario Read(int id)
        {
            Funcionario obj = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun => fun.Codigo == id);
            return obj;
        }

        public override List<Funcionario> ReadAll()
        {
            return FuncionarioFakeDB.Funcionarios;
        }

        public override Funcionario Update(Funcionario obj)
        {
            Funcionario alt = this.Read(obj.Codigo);
            alt.Nome = obj.Nome;
            alt.SobreNome = obj.SobreNome;
            alt.Cpf = obj.Cpf;
            alt.Telefone = obj.Telefone;
            alt.Idade = obj.Idade;
            alt.Altura = obj.Altura;
            alt.Sexo = obj.Sexo;
            alt.Situacao = obj.Situacao;
            alt.Peso = obj.Peso;
            alt.Rg = obj.Rg;
            alt.DtNascimento = obj.DtNascimento;
            alt.Naturalidade = obj.Naturalidade;
            alt.Nacionalidade = obj.Nacionalidade;
            alt.Endereco = obj.Endereco;
            alt.Email = obj.Email;
            return alt;
        }
    }
}

using Atacado.DAL.Estoque;
using Atacado.DAL.IBGE;
using Atacado.DAL.RH;
using Atacado.DAL.RH.Admin;
using Atacado.Domain.Estoque;
using Atacado.Domain.IBGE;
using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesafioDaGripe01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.Write("Informe o código da categoria: ");
            //int codigo = Convert.ToInt32(Console.ReadLine());
            //ApresentarCategoria(codigo);

            //Console.Write("Informe o código do funcionário: ");
            //int codigo = Convert.ToInt32(Console.ReadLine());
            //ApresentarFuncionarios(codigo);

            //Console.Write("Informe o código da empresa: ");
            //int codigo = Convert.ToInt32(Console.ReadLine());
            //ApresentarEmpresa(codigo);

            Console.Write("Informe o código do funcionário: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ApresentarFuncionario(codigo);
            Console.ReadLine();
        }

        private static void ApresentarCategoria(int id)
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = dao.Read(id);
            Imprimir(cat);
        }

        private static void Imprimir(Categoria cat)
        {
            Console.WriteLine("Código: {0}", cat.Codigo);
            Console.WriteLine("Nome: {0}", cat.Descricao);
            Console.WriteLine("Situação: {0}", cat.Situacao);
        }

        private static void ApresentarFuncionario(int id)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            Funcionario fun = dao.Read(id);
            ImprimirFuncionario(fun);
        }

        private static void ImprimirFuncionario(Funcionario fun)
        {
            Console.WriteLine("Código: {0}", fun.Codigo);
            Console.Write("Nome: {0}", fun.Nome);
            Console.WriteLine(" {0}", fun.SobreNome);
        }

        private static void ApresentarEmpresa(int id)
        {
            EmpresaDAO dao = new EmpresaDAO();
            Empresa emp = dao.Read(id);
            Console.WriteLine("Nome Fantasia: {0}", emp.NomeFantasia);
        }

        private static void ApresentarMunicipio(int id)
        {
            MunicipioDAO dao = new MunicipioDAO();
            Municipio mun = dao.Read(id);
            Console.WriteLine("Nome município: {0}", mun.Descricao);
        }
    }
}
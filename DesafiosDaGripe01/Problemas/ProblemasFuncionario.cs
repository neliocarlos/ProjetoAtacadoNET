using System;
using Atacado.Modelo.RH;
using Atacado.FakeDB.RH;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.Modelo.Ancestral;

namespace DesafiosDaGripe01
{
    public static class ProblemasFuncionario
    {
        public static void DadosFuncionario(Funcionario empregado)
        {
            Console.Write("Nome: {0} ", empregado.Nome);
            Console.WriteLine("{0}", empregado.SobreNome);
            Console.WriteLine("Sexo: {0}", empregado.Sexo);
            Console.WriteLine("Email: {0}", empregado.Email);
            Console.WriteLine("Telefone: {0}", empregado.Telefone);
            Console.WriteLine("Situacao: {0}", empregado.Situacao);
        }

        public static void Exercicio02(float peso, float altura)
        {
            double IMC = peso * Math.Pow(altura, 2);
            Console.WriteLine("IMC: {0}", IMC);
        }

        public static void Exercicio03(Funcionario empregado)
        {
            int idade = 0;
            if (empregado.DtNascimento.DayOfWeek < DateTime.Today.DayOfWeek)
            {
                idade = DateTime.Today.Year - empregado.DtNascimento.Year - 1;
            }
            else
            {
                idade = DateTime.Today.Year - empregado.DtNascimento.Year;
            }
            Console.WriteLine("Nome: {0} {1}.", empregado.Nome, empregado.SobreNome);
            Console.WriteLine("Idade: {0}", idade);
        }

        public static void Exercicio04(Funcionario empregado)
        {
            bool status;
            int idade = 0;
            Exercicio03(empregado);

            if (empregado.DtNascimento.DayOfWeek < DateTime.Today.DayOfWeek)
            {
                idade = DateTime.Today.Year - empregado.DtNascimento.Year - 1;
            }
            else
            {
                idade = DateTime.Today.Year - empregado.DtNascimento.Year;
            }

            if (empregado.Sexo == "M" && idade > 65)
            {
                status = true;
                Console.WriteLine("Pode se aposentar? {0}.", status);
            }
            else if (empregado.Sexo == "F" && idade > 60)
            {
                status = true;
                Console.WriteLine("Pode se aposentar? {0}.", status);
            }
            else
            {
                status = false;
                Console.WriteLine("Pode se aposentar? {0}", status);
            }
        }

        //EXERCICIO SITUAÇÃO
        public static int ObterCodigo()
        {
            int codigo;
            while (true)
            {
                Console.Write("Informe o código do funcionário: ");
                if (int.TryParse(Console.ReadLine(), out codigo) == false)
                {
                    Console.WriteLine("Código inválido, tente novamente.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
            return codigo;
        }

        public static Funcionario AtivarRegistro(int codigo)
        {
            Funcionario funcionario = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun => fun.Codigo == codigo);
            if (funcionario != null)
            {
                funcionario.Situacao = SituacaoEnum.Ativo;
                DadosFuncionario(funcionario);
            }
            return funcionario;
        }

        public static Funcionario InativarRegistro(int codigo)
        {
            Funcionario funcionario = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun => fun.Codigo == codigo);
            if (funcionario != null)
            {
                funcionario.Situacao = SituacaoEnum.Inativo;
                DadosFuncionario(funcionario);
            }
            return funcionario;
        }

        public static void SituacaoFuncionario(int codigo)
        {
            while (true)
            {
                Console.Write("Deseja ativar ou inativar o funcionário selecionado? (A/I)");
                string sit = Console.ReadLine();
                if (sit.ToUpper() == "A")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    AtivarRegistro(codigo);
                    break;
                }
                else if (sit.ToUpper() == "I")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    InativarRegistro(codigo);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Situação inválida. Tente novamente.");
                    Console.ResetColor();
                    Console.Clear();
                }
            }
        }

        
    }
}

using Atacado.Modelo.RH;
using Atacado.FakeDB.RH;
using DesafiosDaGripe01;
using DesafiosDaGripe01.Problemas;
using System;
using Atacado.Modelo.IBGE;
using Atacado.FakeDB.IBGE;
using Atacado.Modelo.Ancestral;

namespace DesafioDaGripe01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ExecutarExercicio_1_1();
            //ExecutarExercicio_1_2();
            //ExecutarExercicio_1_3();
            //ExecutarExercicio_1_4();
            //ExecutarExercicio_2_1();
            //ExecutarExercicio_2_2();
            //ExecutarExercicio_2_3();
            //ExecutarExercicio_2_4();
            //ExecutarExercicioIBGE01();
            //ExecutarExercicioIBGE02();
            //ExecutarExercicioIBGE03();
            //ExecutarAtivarFuncionario();
            //ExecutarDesativarFuncionario();
            ExecutarSituacaoFuncionario();
            Console.ReadLine();
        }

        public static void ExecutarExercicio_1_1()
        {
            Console.WriteLine("Qual a operação matemática?(0 - Adição, 1 - Subtração, 2 - Multiplicação, 3 - Divisão)");
            int menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o primeiro valor:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (menu)
            {
                case 0:
                    result = ProblemasMatematicos.Exercicio1(Operacoes.Adicao, num1, num2);
                    break;
                case 1:
                    result = ProblemasMatematicos.Exercicio1(Operacoes.Subtracao, num1, num2);
                    break;
                case 2:
                    result = ProblemasMatematicos.Exercicio1(Operacoes.Multiplicacao, num1, num2);
                    break;
                case 3:
                    result = ProblemasMatematicos.Exercicio1(Operacoes.Divisao, num1, num2);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Resultado da operação é {0}.", result);
        }

        public static void ExecutarExercicio_1_2()
        {
            Console.WriteLine("Informe a largura:");
            float largura = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe o comprimento:");
            float comprimento = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe a altura:");
            float altura = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("O volume é igual a {0}L.", ProblemasMatematicos.Exercicio2(largura, comprimento, altura));
        }

        public static void ExecutarExercicio_1_3()
        {
            Console.WriteLine("Informe o raio do cilindro: ");
            float raio = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe a altura do cilindro: ");
            float altura = Convert.ToSingle(Console.ReadLine());
            ProblemasMatematicos.Exercicio3(raio, altura);
        }

        public static void ExecutarExercicio_1_4()
        {
            Console.WriteLine("Informe o raio do cilindro: ");
            float raio = Convert.ToSingle(Console.ReadLine());
            ProblemasMatematicos.Exercicio4(raio);
        }

        public static void ExecutarExercicio_2_1()
        {
            Console.WriteLine("Informe o código do funcionário (1 até 100): ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(empregado => empregado.Codigo == codigo).ToList();
            foreach (Funcionario i in funcionario)
            {
                ProblemasFuncionario.DadosFuncionario(i);
            }
        }

        public static void ExecutarExercicio_2_2()
        {
            Console.WriteLine("Informe o peso do funcionário: ");
            float peso = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe a altura do funcionário: ");
            float altura = Convert.ToSingle(Console.ReadLine());
            ProblemasFuncionario.Exercicio02(peso, altura);
        }

        public static void ExecutarExercicio_2_3()
        {
            Console.WriteLine("Informe o código do funcionário (1 até 100): ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(pes => pes.Codigo == codigo).ToList();
            foreach (Funcionario i in funcionario)
            {
                ProblemasFuncionario.Exercicio03(i);
            }
        }

        public static void ExecutarExercicio_2_4()
        {
            Console.WriteLine("Informe o código do funcionário (1 até 100): ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(pes => pes.Codigo == codigo).ToList();
            foreach (Funcionario i in funcionario)
            {
                ProblemasFuncionario.Exercicio04(i);
            }
        }

        public static void ExecutarExercicioIBGE01()
        {
            Console.WriteLine("Informe o nome de um estado: ");
            string sigla = Console.ReadLine();
            List<Estado> estados = EstadoFakeDB.Estados.Where(pes => pes.SiglaUF == sigla.ToUpper()).ToList();
            ProblemasIBGE.ListarEstados(estados);
        }

        public static void ExecutarExercicioIBGE02()
        {
            Console.Write("Informe a sigla de um estado: ");
            string sigla = Console.ReadLine();
            List<Municipio> municipios = MunicipioFakeDB.Municipios.Where(pes => pes.SiglaUF == sigla.ToUpper()).ToList();
            ProblemasIBGE.ListarMunicipiosPorEstado(municipios);
        }

        public static void ExecutarExercicioIBGE03()
        { 
            Console.WriteLine("Informe o nome de uma região do Brasil: ");
            string regiao = Console.ReadLine();
            List<Estado> estados = EstadoFakeDB.Estados.Where(pes => pes.RegiaoBrasil.StartsWith(regiao)).ToList();
            ProblemasIBGE.ListarEstadosPorRegiao(estados);
        }

        public static void ExecutarAtivarFuncionario()
        {
            Console.WriteLine("Informe o código do funcionário: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ProblemasFuncionario.AtivarRegistro(codigo);
        }

        public static void ExecutarDesativarFuncionario()
        {
            Console.WriteLine("Informe o código do funcionário: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ProblemasFuncionario.InativarRegistro(codigo);
        }

        public static void ExecutarSituacaoFuncionario()
        {
            int codigo = ProblemasFuncionario.ObterCodigo();
            ProblemasFuncionario.SituacaoFuncionario(codigo);
        }

    }
}
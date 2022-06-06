using Atacado.FakeDB.IBGE;
using Atacado.Domain.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDaGripe01
{
    public static class ProblemasIBGE
    {
        public static void DadosEstado(Estado estado)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Código: {0}", estado.Codigo);
            Console.WriteLine("Nome: {0}", estado.Descricao);
            Console.WriteLine("Sigla: {0}", estado.SiglaUF);
            Console.WriteLine("Região: {0}", estado.RegiaoBrasil);
            Console.WriteLine("");
        }

        public static void ListarEstados(List<Estado> estados)
        {
            if (estados.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este estado não existe!");
            }
            else
            {
                foreach (var estado in estados)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    DadosEstado(estado);
                }
            }
            Console.ResetColor();
        }

        public static void ListarMunicipiosPorEstado(List<Municipio> municipios)
        {
            if (municipios.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A sigla informada não existe.");
            }
            else
            {
                foreach (var municipio in municipios)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Código: {0}", municipio.Codigo);
                    Console.WriteLine("Nome: {0}", municipio.Descricao);
                    Console.WriteLine("IBGE: {0}", municipio.CodigoIBGE6);
                    Console.WriteLine("IBGE7: {0}", municipio.CodigoIBGE7);
                    Console.WriteLine("Estado: {0}", municipio.SiglaUF);
                    Console.WriteLine("População: {0}", municipio.PopulacaoMunicipio);
                    Console.WriteLine("");
                } 
            }
            Console.ResetColor();
        }

        public static void ListarEstadosPorRegiao(List<Estado> estados)
        {
            if (estados.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Essa região não existe!");
            }
            else
            {
                foreach(Estado estado in estados)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    DadosEstado(estado);
                }
            }
        }
    }
}

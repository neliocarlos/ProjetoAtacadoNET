using DesafiosDaGripe01.Problemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDaGripe01
{
    public static class ProblemasMatematicos
    {
        public static int Exercicio1(Operacoes op, int num1, int num2)
        {
            int result = 0;
            switch (op)
            {
                case Operacoes.Adicao:
                    result = num1 + num2;
                    break;
                case Operacoes.Subtracao:
                    result = num1 - num2;
                    break;
                case Operacoes.Multiplicacao:
                    result = num1 * num2;
                    break;
                case Operacoes.Divisao:
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            return result;
        }

        public static float Exercicio2(float largura, float comprimento, float altura)
        {
            float result = largura * comprimento * altura;
            Console.WriteLine("{0} Litros.", result);
            return result;
        }

        public static double Exercicio3(float raio, float altura)
        { 
            double result = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine("{0} cm³.", result);
            return result;
        }

        public static double Exercicio4(float raio)
        {
            double result = (4 / 3) * Math.PI * Math.Pow(raio, 3);
            Console.WriteLine("{0} cm³.", result);
            return result;
        }
    }
}

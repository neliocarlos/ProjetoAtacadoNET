﻿using Atacado.DAL.Estoque;
using Atacado.Map.Estoque;
using Atacado.Domain.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TesteAtacadoMap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o código da categoria: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            CategoriaDAO dao = new CategoriaDAO();
            Categoria modelo = dao.Read(codigo);
            CategoriaPOCO poco = CategoriaMap.ConverterParaPoco(modelo);
            Console.Write("Código: {0} / ", poco.Codigo);
            Console.Write("Descrição: {0} / ", poco.Descricao);
            Console.WriteLine("Situação: {0}", poco.Situacao);
            Console.ReadLine();
        }
    }
}
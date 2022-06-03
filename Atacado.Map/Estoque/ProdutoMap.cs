using Atacado.Modelo.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class ProdutoMap
    {
        public static ProdutoPOCO ConverterParaPoco(Produto modelo)
        {
            return new ProdutoPOCO()
            {
                Codigo = modelo.Codigo,
                CodigoSubcategoria = modelo.CodigoSubcategoria,
                CodigoCategoria = modelo.CodigoCategoria,
                Descricao = modelo.Descricao,
                Situacao = modelo.Situacao
            };
        }

        public static Produto ConverterParaModelo(ProdutoPOCO poco)
        {
            return new Produto(poco.Codigo, poco.CodigoSubcategoria, poco.CodigoCategoria, poco.Descricao, poco.Situacao);
        }
    }
}

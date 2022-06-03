using Atacado.Modelo.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Modelo.Estoque
{
    public class Produto : BaseCampoPadronizado03
    {
        private int codigoCategoria;
        private int codigoSubcategoria;

        public int CodigoCategoria 
        { 
            get => codigoCategoria; 
            set => codigoCategoria = value; 
        }
        public int CodigoSubcategoria 
        {
            get => codigoSubcategoria;
            set => codigoSubcategoria = value;
        }

        public Produto(int codigo, int codigoSubcategoria, int codigoCategoria, string descricao, int situacao) 
            : base(codigo, descricao, situacao)
        {
            this.codigoCategoria = codigoCategoria;
            this.codigoSubcategoria = codigoSubcategoria;
        }
    }
}

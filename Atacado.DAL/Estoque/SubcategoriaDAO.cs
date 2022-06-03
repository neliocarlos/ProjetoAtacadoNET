using Atacado.DAL.Ancestral;
using Atacado.FakeDB.Estoque;
using Atacado.Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.Estoque
{
    public class SubcategoriaDAO : BaseAncestralDAO<Subcategoria>
    {
        public override Subcategoria Create(Subcategoria obj)
        {
            int chave = SubcategoriaFakeDB.Subcategorias.Max(subc => subc.Codigo) + 1;
            SubcategoriaFakeDB.Subcategorias.Add(obj);
            return obj;
        }
        public override Subcategoria Read(int id)
        {
            Subcategoria obj = SubcategoriaFakeDB.Subcategorias.SingleOrDefault(subc => subc.Codigo == id);
            return obj;
        }

        public override List<Subcategoria> ReadAll()
        {
            return SubcategoriaFakeDB.Subcategorias;
        }

        public override Subcategoria Update(Subcategoria obj)
        {
            Subcategoria alt = this.Read(obj.Codigo);
            alt.Descricao = obj.Descricao;
            alt.Situacao = obj.Situacao;
            alt.CodigoCategoria = obj.CodigoCategoria;
            return alt;
        }

        public override Subcategoria Delete(int id)
        {
            Subcategoria del = this.Read(id);
            SubcategoriaFakeDB.Subcategorias.Remove(del);
            return del;
        }

        public override Subcategoria Delete(Subcategoria obj)
        {
            return this.Delete(obj.Codigo);
        }
    }
}

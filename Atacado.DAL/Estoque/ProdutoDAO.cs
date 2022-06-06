﻿using Atacado.DAL.Ancestral;
using Atacado.FakeDB.Estoque;
using Atacado.Domain.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.Estoque
{
    public class ProdutoDAO : BaseAncestralDAO<Produto>
    {
        public override Produto Create(Produto obj)
        {
            int chave = ProdutoFakeDB.Produtos.Max(prod => prod.Codigo) + 1;
            ProdutoFakeDB.Produtos.Add(obj);
            return obj;
        }

        public override Produto Read(int id)
        {
            Produto obj = ProdutoFakeDB.Produtos.SingleOrDefault(prod => prod.Codigo == id);
            return obj;
        }

        public override List<Produto> ReadAll()
        {
            return ProdutoFakeDB.Produtos;
        }

        public override Produto Update(Produto obj)
        {
            Produto alt = this.Read(obj.Codigo);
            alt.Descricao = obj.Descricao;
            alt.Situacao = obj.Situacao;
            alt.CodigoCategoria = obj.CodigoCategoria;
            alt.CodigoSubcategoria = obj.CodigoSubcategoria;
            return alt;
        }

        public override Produto Delete(int id)
        {
            Produto del = this.Read(id);
            ProdutoFakeDB.Produtos.Remove(del);
            return del;
        }

        public override Produto Delete(Produto obj)
        {
            return this.Delete(obj.Codigo);
        }

    }
}

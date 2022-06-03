using Atacado.DAL.Ancestral;
using Atacado.FakeDB.IBGE;
using Atacado.Modelo.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.IBGE
{
    public class MunicipioDAO : BaseAncestralDAO<Municipio>
    {
        public override Municipio Create(Municipio obj)
        {
            int chave = MunicipioFakeDB.Municipios.Max(mun => mun.Codigo) + 1;
            MunicipioFakeDB.Municipios.Add(obj);
            return obj;
        }

        public override Municipio Delete(int id)
        {
            Municipio del = this.Read(id);
            MunicipioFakeDB.Municipios.Remove(del);
            return del;
        }

        public override Municipio Delete(Municipio obj)
        {
            return this.Delete(obj.Codigo);
        }

        public override Municipio Read(int id)
        {
            Municipio obj = MunicipioFakeDB.Municipios.SingleOrDefault(mun => mun.Codigo == id);
            return obj;
        }

        public override List<Municipio> ReadAll()
        {
            return MunicipioFakeDB.Municipios;
        }

        public override Municipio Update(Municipio obj)
        {
            Municipio alt = this.Read(obj.Codigo);
            alt.Descricao = obj.Descricao;
            alt.CodigoUF = obj.CodigoUF;
            alt.SiglaUF = obj.SiglaUF;
            alt.CodigoMicroregiao = obj.CodigoMicroregiao;
            alt.CodigoMesoregiao = obj.CodigoMesoregiao;
            alt.CodigoIBGE6 = obj.CodigoIBGE6;
            alt.CodigoIBGE7 = obj.CodigoIBGE7;
            alt.PopulacaoMunicipio = obj.PopulacaoMunicipio;
            alt.PorteMunicipio = obj.PorteMunicipio;
            alt.Cep = obj.Cep;
            return alt;
        }
    }
}

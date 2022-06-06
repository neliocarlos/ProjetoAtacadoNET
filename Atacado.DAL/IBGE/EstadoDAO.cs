using Atacado.DAL.Ancestral;
using Atacado.FakeDB.IBGE;
using Atacado.Domain.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.IBGE
{
    public class EstadoDAO : BaseAncestralDAO<Estado>
    {
        public override Estado Create(Estado obj)
        {
            int chave = EstadoFakeDB.Estados.Max(est => est.Codigo) + 1;
            EstadoFakeDB.Estados.Add(obj);
            return obj;
        }

        public override Estado Delete(int id)
        {
            Estado del = this.Read(id);
            EstadoFakeDB.Estados.Remove(del);
            return del;
        }

        public override Estado Delete(Estado obj)
        {
            return this.Delete(obj.Codigo);
        }

        public override Estado Read(int id)
        {
            Estado obj = EstadoFakeDB.Estados.SingleOrDefault(est => est.Codigo == id);
            return obj;
        }

        public override List<Estado> ReadAll()
        {
            return EstadoFakeDB.Estados;
        }

        public override Estado Update(Estado obj)
        {
            Estado alt = this.Read(obj.Codigo);
            alt.Descricao = obj.Descricao;
            alt.SiglaUF = obj.SiglaUF;
            alt.RegiaoBrasil = obj.RegiaoBrasil;
            return alt;
        }
    }
}

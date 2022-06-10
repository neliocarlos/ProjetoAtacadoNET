using Atacado.Business.RH;
using Atacado.DAL.RH.Admin;
using Atacado.Domain.RH;
using Atacado.Map.RH;
using Atacado.POCO.RH;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.RH
{
    public class EmpresaService :
        IAcaoAdicionarSrv<EmpresaPOCO>,
        IAcaoAlterarSrv<EmpresaPOCO>,
        IAcaoExcluirSrv<EmpresaPOCO>,
        IAcaoExcluirTodosSrv<EmpresaPOCO>,
        IAcaoListarSrv<EmpresaPOCO>,
        IAcaoSelecionarSrv<EmpresaPOCO>
    {
        private EmpresaDAO dao;

        private EmpresaBizz bizz;

        private List<string> mensagensDeErro;

        public List<string> MensagensDeErro
        {
            get { return this.mensagensDeErro; }
        }

        public EmpresaService()
        {
            this.dao = new EmpresaDAO();
            this.bizz = new EmpresaBizz();
            this.mensagensDeErro = new List<string>();
        }

        public EmpresaPOCO Adicionar(EmpresaPOCO obj)
        {
            Empresa dom = EmpresaMap.ConverterParaDomain(obj);
            Empresa criado = this.dao.Create(dom);
            return EmpresaMap.ConverterParaPoco(criado);
        }

        public EmpresaPOCO Alterar(EmpresaPOCO obj)
        {
            Empresa dom = EmpresaMap.ConverterParaDomain(obj);
            Empresa alterado = this.dao.Update(dom);
            return EmpresaMap.ConverterParaPoco(alterado);
        }

        public EmpresaPOCO Excluir(EmpresaPOCO obj)
        {
            Empresa dom = EmpresaMap.ConverterParaDomain(obj);
            Empresa deletado = this.dao.Delete(dom);
            return EmpresaMap.ConverterParaPoco(deletado);
        }

        public List<EmpresaPOCO> ExcluirTodos(List<EmpresaPOCO> lista)
        {
            List<EmpresaPOCO> resultado = new List<EmpresaPOCO>();
            foreach (EmpresaPOCO obj in lista)
            {
                Empresa dom = EmpresaMap.ConverterParaDomain(obj);
                this.dao.Delete(dom);
                resultado.Add(obj);
            }
            return resultado;
        }

        public List<EmpresaPOCO> Listar()
        {
            List<EmpresaPOCO> listPOCO = this.dao.ReadAll().Select(emp => new EmpresaPOCO()
            {
                Codigo = emp.Codigo,
                Telefone = emp.Telefone,
                Email = emp.Email,
                Endereco = emp.Endereco,
                Cnpj = emp.Cnpj,
                NomeFantasia = emp.NomeFantasia,
                RazaoSocial = emp.RazaoSocial,
                InscricaoEstadual = emp.InscricaoEstadual
            }).ToList();
            return listPOCO;
        }

        public EmpresaPOCO Selecionar(int id)
        {
            Empresa dom = this.dao.Read(id);
            if (dom != null)
                return EmpresaMap.ConverterParaPoco(dom);
            else
                return null;
        }

        public bool Validar(EmpresaPOCO obj)
        {
            Empresa dom = EmpresaMap.ConverterParaDomain(obj);
            if (this.bizz.Executar(dom) == false)
            {
                this.mensagensDeErro.AddRange(this.bizz.Mensagens);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.DAL
{
    public class Opt
    {
        public Opt()
        {
            new ConexaoBD().getConexao().CreateTable<Controle.DL.Opt>();
        }

        public List<Controle.DL.Opt> Pesquisar()
        {
            return new ConexaoBD().getConexao().Table<Controle.DL.Opt>().ToList();
        }

        public Controle.DL.Opt PesquisarPorId(int id)
        {
            return new ConexaoBD().getConexao().Table<Controle.DL.Opt>().Where(a => a.OptID == id).FirstOrDefault();
        }

        public Int32 Inserir(Controle.DL.Opt opt)
        {
            return new ConexaoBD().getConexao().Insert(opt);
        }

        public Int32 Alterar(Controle.DL.Opt opt)
        {
            return new ConexaoBD().getConexao().Update(opt);
        }

        public Int32 Excluir(Controle.DL.Opt opt)
        {
            return new ConexaoBD().getConexao().Delete(opt);
        }

        public void Limpar()
        {
            new ConexaoBD().getConexao().DropTable<Controle.DL.Opt>();
        }
    }
}

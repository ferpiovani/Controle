using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.DAL
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            new ConexaoBD().getConexao().CreateTable<Controle.DL.Fornecedor>();
        }

        public List<Controle.DL.Fornecedor> Pesquisar()
        {
            return new ConexaoBD().getConexao().Table<Controle.DL.Fornecedor>().ToList();
        }

        public Controle.DL.Fornecedor PesquisarPorId(int id)
        {
            return new ConexaoBD().getConexao().Table<Controle.DL.Fornecedor>().Where(a => a.FornID == id).FirstOrDefault();
        }

        public Int32 Inserir(Controle.DL.Fornecedor forn)
        {
            return new ConexaoBD().getConexao().Insert(forn);
        }

        public Int32 Alterar(Controle.DL.Fornecedor forn)
        {
            return new ConexaoBD().getConexao().Update(forn);
        }

        public Int32 Excluir(Controle.DL.Fornecedor forn)
        {
            return new ConexaoBD().getConexao().Delete(forn);
        }

        public void Limpar()
        {
            new ConexaoBD().getConexao().DropTable<Controle.DL.Fornecedor>();
        }
    }
}

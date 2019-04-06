using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Controle.DAL
{
    class ConexaoBD
    {
        private SQLiteConnection _conexao;

        public ConexaoBD()
        {
            string caminho = @"C:\Server\";
            _conexao = new SQLiteConnection(caminho);
        }

        public SQLiteConnection getConexao()
        {
            return _conexao;
        }


    }
}

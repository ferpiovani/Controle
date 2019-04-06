using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Controle.DL
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        public Fornecedor()
        {
            FornNome = string.Empty;
            FornProdLista = new List<Produto>();
        }
        [PrimaryKey, AutoIncrement]
        public int FornID { get; set; }
        public String FornNome { get; set; }
        public Contato FornContato { get; set; }
        public List<DL.Produto> FornProdLista { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Controle.DL
{
    [Table("Produto")]
    public class Produto
    {
        public Produto()
        {
            ProdDesc = string.Empty;
        }
        [PrimaryKey, AutoIncrement]
        public int ProdID { get; set; }
        public String ProdDesc { get; set; }
        public Double ProdVrTotal { get; set; }
    }
}

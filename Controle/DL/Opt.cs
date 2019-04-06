using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Controle.DL
{
    [Table("Opt")]
    public class Opt
    {
        public Opt()
        {
            OptTipoDesc = string.Empty;
        }
        [PrimaryKey, AutoIncrement]
        public int OptID { get; set; }
        public Int32 OptTipo { get; set; }
        public String OptTipoDesc { get; set; }
        public Int32 OptTipoComporta { get; set; }
        public Double OptPalhaUn { get; set; }
        public Double OptFumoUn { get; set; }
        public Double OptEnbalagemUn { get; set; }
    }
}

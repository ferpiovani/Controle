using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.DL
{
    public class Contato
    {
        public Contato()
        {
            ContatoNome = String.Empty;
            ContatoEmail = String.Empty;
            ContatoTel1 = String.Empty;
            ContatoTel2 = String.Empty;
            ContatoSite = String.Empty;
        }

        public Int32 ContatoID { get; set; }
        public String ContatoNome { get; set; }
        public String ContatoEmail { get; set; }
        public String ContatoTel1 { get; set; }
        public Boolean ContatoTel1Whats { get; set; }
        public String ContatoTel2 { get; set; }
        public Boolean ContatoTel2Whats { get; set; }
        public String ContatoSite { get; set; }

    }
}

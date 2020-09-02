using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PryHelpDesk01.objetos
{
    public class clsObjetosAutorizacion
    {
        public string estado { get; set; }
        public string numeroAutorizacion { get; set; }
        public string fechaAutorizacion { get; set; }
        public string ambiente { get; set; }
        public XDocument comprobante { get; set; }

    }
}

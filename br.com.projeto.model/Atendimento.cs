using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AxiosDental.br.com.projeto.model
{
    public class Atendimento
    {
        public int id { get; set; }
        public int cliente_id { get; set; }
        public string Data_hora_cad { get; set; }
       public string Data_hora_alt { get; set; }
        public string status { get; set; }

    }
}

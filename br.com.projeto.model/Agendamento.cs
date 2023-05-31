using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AxiosDental.br.com.projeto.model
{
    public class Agendamento
    {
        public int id { get; set; }
        public int id_cliente { get; set; }
        public string data_agendamento { get; set; }
        public string hora_agendamento { get; set; }
        public string observacao { get; set; }
        public string status { get; set; }
        public string data_cad { get; set; }
        public int id_funcionario { get; set; }
    }
}

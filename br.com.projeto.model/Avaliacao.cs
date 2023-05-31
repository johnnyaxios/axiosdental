using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AxiosDental.br.com.projeto.model
{
    public class Avaliacao
    {
        public int id { get; set; }

        public string tipo_aval { get; set; }
        public string data_avaliacao { get; set; }
        public string horario_agendamento { get; set; }
        public string horario_chegada { get; set; }
        public string status { get; set; }
        public int cliente_id { get; set; }
        public string Data_hora_cad { get; set; }
        public int usuario_cad { get; set; }
        public string Data_hora_alt { get; set; }
        public int usuario_alt { get; set; }



}
}

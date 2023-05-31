using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiosDental.br.com.projeto.model
{
    public class Procedimento
    {

        public int id { get; set; }
        public string codigo_interno { get; set; }
        public string descricao { get; set; }
        public Decimal valor { get; set; }
        public string Data_hora_cad { get; set; }
        public int usuario_cad { get; set; }
        public string Data_hora_alt { get; set; }
        public int usuario_alt { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiosDental.br.com.projeto.model
{
    public class AtendimentoItem
    {
        public int id { get; set; }
        public int atendimento_id { get; set; }
        public int local_id { get; set; }
        public int posicao_id { get; set; }
        public int procedimento_id { get; set; }
        public string observacao { get; set; }
        public string status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiosDental.br.com.projeto.model
{
    public class Cliente
    {
        public int id { get; set; }
        public string prontuario { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string nome_convenio { get; set; }
        public string plano { get; set; }
        public string num_cart_convenio { get; set; }
        public string data_validade_plano { get; set; }
        public string data_nascimento { get; set; }
        public string nome_sindicato { get; set; }
        public string num_cart_sindicato { get; set; }
        public string observacao { get; set; }
        public string status { get; set; }
        public string Data_hora_cad { get; set; }
        public int usuario_cad { get; set; }
        public string Data_hora_alt { get; set; }
        public int usuario_alt { get; set; }
        public string titular { get; set; }
        public string nome_titular { get; set; }

    }
}

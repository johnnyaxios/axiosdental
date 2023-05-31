using AxiosDental.br.com.projeto.conexao;
using AxiosDental.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxiosDental.br.com.projeto.dao
{
    public class AtendimentoDAO
    {
        private SqlConnection conexao;

        public AtendimentoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar
        public int cadastrar(Atendimento obj)
        {
            try
            {
                string sql = @"insert into tb_atendimento(cliente_id, Data_hora_cad) " +
                                "values (@cliente_id,@Data_hora_cad)";
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@Data_hora_cad", obj.Data_hora_cad);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Iniciar atendimento!");

                if (executacmd.LastInsertedId != 0)
                    executacmd.Parameters.Add(new SqlParameter("ultimoId", executacmd.LastInsertedId));
                // Retorna o id do novo rgistro e convert de Int64 para Int32 (int).
            return Convert.ToInt32(executacmd.Parameters["@ultimoId"].Value);
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return -1;
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion
    }
}

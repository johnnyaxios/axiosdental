using AxiosDental.br.com.projeto.conexao;
using AxiosDental.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxiosDental.br.com.projeto.dao
{
    public class AtendimentoDAO
    {
        private MySqlConnection conexao;

        public AtendimentoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar
        public int cadastrar(Atendimento obj)
        {
            try
            {
                string sql = @"insert into tb_atendimento(cliente_id, Data_hora_cad, status) " +
                                "values (@cliente_id,@Data_hora_cad, @status)";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@status", obj.status);
                executacmd.Parameters.AddWithValue("@Data_hora_cad", obj.Data_hora_cad);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Iniciar atendimento!");

                if (executacmd.LastInsertedId != 0)
                    executacmd.Parameters.Add(new MySqlParameter("ultimoId", executacmd.LastInsertedId));
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

        #region AlterarStatus
        public void alterarStatus(Atendimento obj)
        {
            try
            {
                string sql = @"update tb_atendimento set  status = @status
                                    where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@status", obj.status);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Atendimento Alterada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Listar
        public DataTable listar()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select ta.id id_atendimento, tc.prontuario, tc.id id_cliente, tc.nome, ta.status " +
                            " from tb_atendimento ta " +
                            "inner join tb_cliente tc on tc.id = ta.cliente_id " +
                            " where ta.status not in ('Cancelado', 'Concluido', 'Rejeitado', 'Reprovado') " +
                            " and ta.status is not null";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);
                conexao.Close();
                return tabela;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion
    }
}

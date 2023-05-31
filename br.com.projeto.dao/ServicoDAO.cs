using AxiosDental.br.com.projeto.conexao;
using AxiosDental.br.com.projeto.model;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxiosDental.br.com.projeto.dao
{
    public class ServicoDAO
    {
        private SqlConnection conexao;
        public ServicoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        //metodo cadastrarcliente
        #region CadastrarServico
        public void cadastrarServico(Procedimento obj)
        {
            try
            {
                string sql = @"insert into tb_servico(codigo_interno,descricao,valor,Data_hora_cad,usuario_cad) " +
                               "values(@codigo_interno,@descricao,@valor,@Data_hora_cad,@usuario_cad)";
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@codigo_interno", obj.codigo_interno);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@valor", obj.valor);
                executacmd.Parameters.AddWithValue("@Data_hora_cad", obj.Data_hora_cad);
                executacmd.Parameters.AddWithValue("@usuario_cad", obj.usuario_cad);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                /*if (executacmd.LastInsertedId != 0)
                    executacmd.Parameters.Add(new SqlParameter("ultimoId", executacmd.LastInsertedId));
                // Retorna o id do novo rgistro e convert de Int64 para Int32 (int).
                ; + Convert.ToInt32(executacmd.Parameters["@ultimoId"].Value)*/

                MessageBox.Show("Serviço Cadastrado com sucesso! ");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion
        #region AlterarServico
        public void alterarServico(Procedimento obj)
        {
            try
            {
                string sql = @"update tb_servico set codigo_interno=@codigo_interno,descricao=@descricao,valor=@valor,Data_hora_alt=@Data_hora_alt,usuario_alt=@usuario_alt
                                    where id=@id";
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@codigo_interno", obj.codigo_interno);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@valor", obj.valor);
                executacmd.Parameters.AddWithValue("@Data_hora_alt", obj.Data_hora_alt);
                executacmd.Parameters.AddWithValue("@usuario_alt", obj.usuario_alt);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Serviço Cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion
        #region ExcluirServico
        public void excluirServico(Procedimento obj)
        {
            try
            {
                string sql = @"delete from tb_servico where id=@id";



                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Serviço Excluido com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion
        #region ListarClientes
        public DataTable listarServico()
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_Servico order by descricao";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelacliente);
                conexao.Close();
                return tabelacliente;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                return null;
            }
        }
        #endregion
        #region buscarclienteporCodigoInterno
        public DataTable buscarServocoPorCodInterno(string codiInterno)
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_servico where codigo_interno like '%" + codiInterno + "%'";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@codiInterno", codiInterno);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelacliente);
                conexao.Close();
                return tabelacliente;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                return null;
            }
        }
        #endregion
    }
}

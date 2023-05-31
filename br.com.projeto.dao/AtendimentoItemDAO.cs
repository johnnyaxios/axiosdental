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
    public class AtendimentoItemDAO
    {
        private SqlConnection conexao;

        public AtendimentoItemDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar
        public void cadastrar(AtendimentoItem obj)
        {
            try
            {
                string sql = @"insert into tb_atendimento_item(atendimento_id, local_id, procedimento_id, posicao_id, observacao, status) " +
                                "values (@atendimento_id, @local_id, @procedimento_id, @posicao_id, @observacao, @status)";
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@atendimento_id", obj.atendimento_id);
                executacmd.Parameters.AddWithValue("@local_id", obj.local_id);
                executacmd.Parameters.AddWithValue("@procedimento_id", obj.procedimento_id);
                executacmd.Parameters.AddWithValue("@posicao_id", obj.posicao_id);
                executacmd.Parameters.AddWithValue("@observacao", obj.observacao);
                executacmd.Parameters.AddWithValue("@status", obj.status);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Tratamento Cadastrado com sucesso!");
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
                string sql = "select tai.id ,  \r\ntl.id id_local, tl.descricao local, \r\ntpr.id id_procedimento, tpr.descricao procedimeto, \r\ntpt.id id_posicao, tpt.descricao posicao, \r\ntai.observacao, tai.status\r\nfrom tb_atendimento_item tai\r\ninner join tb_atendimento ta on ta.id = tai.atendimento_id\r\ninner join tb_local_tratamento tl on tl.id = tai.local_id\r\ninner join tb_posicao_tratamento tpt on tpt.id = tai.posicao_id\r\ninner join tb_servico tpr on tpr.id = tai.procedimento_id\r\nwhere ta.id = @id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
               
                conexao.Open();
                executacmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
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

        #region Alterar
        public void alterar(AtendimentoItem obj)
        {
            try
            {
                string sql = @"update tb_atendimento_item set atendimento_id = @atendimento_id, local_id = @local_id, procedimento_id = @procedimento_id, 
                                    posicao_id = @posicao_id, observacao = @observacao, status = @status
                                    where id=@id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@atendimento_id", obj.atendimento_id);
                executacmd.Parameters.AddWithValue("@local_id", obj.local_id);
                executacmd.Parameters.AddWithValue("@procedimento_id", obj.procedimento_id);
                executacmd.Parameters.AddWithValue("@posicao_id", obj.posicao_id);
                executacmd.Parameters.AddWithValue("@observacao", obj.observacao);
                executacmd.Parameters.AddWithValue("@status", obj.status);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Item Alterada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Deletar
        public void deletar(AtendimentoItem obj)
        {
            try
            {
                string sql = @"delete from tb_atendimento_item where id=@id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("NPosicao Deletada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region buscarporcriterio
        public DataTable buscarPorCriterio(int criterio)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select tai.id ,  \r\ntl.id id_local, tl.descricao local, \r\ntpr.id id_procedimento, tpr.descricao procedimeto, \r\ntpt.id id_posicao, tpt.descricao posicao, \r\ntai.observacao, tai.status\r\nfrom tb_atendimento_item tai\r\ninner join tb_atendimento ta on ta.id = tai.atendimento_id\r\ninner join tb_local_tratamento tl on tl.id = tai.local_id\r\ninner join tb_posicao_tratamento tpt on tpt.id = tai.posicao_id\r\ninner join tb_servico tpr on tpr.id = tai.procedimento_id\r\nwhere ta.id = @criterio";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@criterio", criterio);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
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

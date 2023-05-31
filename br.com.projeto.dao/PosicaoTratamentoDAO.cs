using AxiosDental.br.com.projeto.conexao;
using AxiosDental.br.com.projeto.model;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxiosDental.br.com.projeto.dao
{
    public  class PosicaoTratamentoDAO
    {
        private SqlConnection conexao;

        public PosicaoTratamentoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar
        public void cadastrar(PosicaoTratamento obj)
        {
            try
            {
                string sql = @"insert into tb_posicao_tratamento(descricao) " +
                                "values (@descricao)";
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Posição Cadastrado com sucesso!");
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
                string sql = "select * from tb_posicao_tratamento order by 2";

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
        public void alterar(PosicaoTratamento obj)
        {
            try
            {
                string sql = @"update tb_posicao_tratamento set descricao = @descricao,
                                    where id=@id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Posicao Alterada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Deletar
        public void deletar(PosicaoTratamento obj)
        {
            try
            {
                string sql = @"delete from tb_posicao_tratamento where id=@id";

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
        public DataTable buscarPorCriterio(string criterio)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from tb_posicao_tratamento where descricao like '%"+ criterio+ "%'order by 2";

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

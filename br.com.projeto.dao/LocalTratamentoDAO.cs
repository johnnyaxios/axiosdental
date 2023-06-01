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
    public  class LocalTratamentoDAO
    {
        private MySqlConnection conexao;

        public LocalTratamentoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar
        public void cadastrar(LocalTratamento obj)
        {
            try
            {
                string sql = @"insert into tb_local_tratamento(descricao) " +
                                "values (@descricao)";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Natureza Cadastrado com sucesso!");
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
                string sql = "select * from tb_local_tratamento order by 2";

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

        #region Alterar
        public void alterar(LocalTratamento obj)
        {
            try
            {
                string sql = @"update tb_local_tratamento set descricao = @descricao,
                                    where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Local Alterada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Deletar
        public void deletar(LocalTratamento obj)
        {
            try
            {
                string sql = @"delete from tb_local_tratamento where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("NLocal Deletada com sucesso!");
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
                string sql = "select * from tb_local_tratamento where descricao like '%"+ criterio+ "%'order by 2";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@criterio", criterio);
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

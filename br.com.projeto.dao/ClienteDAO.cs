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
    public class ClienteDAO
    {
        private SqlConnection conexao;
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        //metodo cadastrarcliente
        #region CadastarCliente
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                string sql = @"insert into tb_cliente(prontuario,nome,rg,cpf,email,telefone,celular,
                                    cep,endereco,numero,complemento,bairro,estado,cidade,nome_convenio,
                                    plano,num_cart_convenio,data_validade_plano,data_nascimento,nome_sindicato,
                                    num_cart_sindicato,observacao,status,Data_hora_cad,usuario_cad,
                                    titular,nome_titular) " +
                               "values(@prontuario,@nome,@rg,@cpf,@email,@telefone,\r\n@celular,@cep,@endereco,@numero,@complemento,@bairro,\r\n@estado,@cidade,@nome_convenio,@plano,@num_cart_convenio,\r\n@data_validade_plano,@data_nascimento,@nome_sindicato,\r\n@num_cart_sindicato,@observacao,@status,@Data_hora_cad,\r\n@usuario_cad,@titular,@nome_titular)";
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@prontuario", obj.prontuario);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@nome_convenio", obj.nome_convenio);
                executacmd.Parameters.AddWithValue("@plano", obj.plano);
                executacmd.Parameters.AddWithValue("@num_cart_convenio", obj.num_cart_convenio);
                executacmd.Parameters.AddWithValue("@data_validade_plano", obj.data_validade_plano);
                executacmd.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                executacmd.Parameters.AddWithValue("@nome_sindicato", obj.nome_sindicato);
                executacmd.Parameters.AddWithValue("@num_cart_sindicato", obj.num_cart_sindicato);
                executacmd.Parameters.AddWithValue("@observacao", obj.observacao);
                executacmd.Parameters.AddWithValue("@status", obj.status);
                executacmd.Parameters.AddWithValue("@Data_hora_cad", obj.Data_hora_cad);
                executacmd.Parameters.AddWithValue("@usuario_cad", obj.usuario_cad);
                executacmd.Parameters.AddWithValue("@Data_hora_alt", obj.Data_hora_alt);
                executacmd.Parameters.AddWithValue("@usuario_alt", obj.usuario_alt);
                executacmd.Parameters.AddWithValue("@titular", obj.titular);
                executacmd.Parameters.AddWithValue("@nome_titular", obj.nome_titular);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion
        #region AlterarCliente
        public void alterarCliente(Cliente obj)
        {
            try
            {
                string sql = @"update tb_cliente set prontuario=@prontuario,nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,
                                cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,estado=@estado,
                                cidade=@cidade,nome_convenio=@nome_convenio,plano=@plano,num_cart_convenio=@num_cart_convenio,
                                data_validade_plano=@data_validade_plano,data_nascimento=@data_nascimento,nome_sindicato=@nome_sindicato,
                                num_cart_sindicato=@num_cart_sindicato,observacao=@observacao,status=@status,Data_hora_alt=@Data_hora_alt,
                                 usuario_alt=@usuario_alt,titular=@titular,nome_titular=@nome_titular,
                                    where id=@id";
                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@prontuario", obj.prontuario);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@nome_convenio", obj.nome_convenio);
                executacmd.Parameters.AddWithValue("@plano", obj.plano);
                executacmd.Parameters.AddWithValue("@num_cart_convenio", obj.num_cart_convenio);
                executacmd.Parameters.AddWithValue("@data_validade_plano", obj.data_validade_plano);
                executacmd.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                executacmd.Parameters.AddWithValue("@nome_sindicato", obj.nome_sindicato);
                executacmd.Parameters.AddWithValue("@num_cart_sindicato", obj.num_cart_sindicato);
                executacmd.Parameters.AddWithValue("@observacao", obj.observacao);
                executacmd.Parameters.AddWithValue("@status", obj.status);
                executacmd.Parameters.AddWithValue("@Data_hora_cad", obj.Data_hora_cad);
                executacmd.Parameters.AddWithValue("@usuario_cad", obj.usuario_cad);
                executacmd.Parameters.AddWithValue("@Data_hora_alt", obj.Data_hora_alt);
                executacmd.Parameters.AddWithValue("@usuario_alt", obj.usuario_alt);
                executacmd.Parameters.AddWithValue("@titular", obj.titular);
                executacmd.Parameters.AddWithValue("@nome_titular", obj.nome_titular);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion
        #region ExcluirCliente
        public void excluirCliente(Cliente obj)
        {
            try
            {
                string sql = @"delete from tb_cliente where id=@id";



                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com sucesso!");
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
        public DataTable listarClientes()
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_cliente order by nome";

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
        #region buscarclientepornome
        public DataTable buscarClientePorNome(string nome)
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_cliente where nome like '%" + @nome + "%'";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
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

using AxiosDental.br.com.projeto.dao;
using AxiosDental.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxiosDental
{
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClienteDAO CL = new ClienteDAO();
            tabelaCliente.AutoGenerateColumns = false;
            tabelaCliente.DataSource = tabelaCliente.Columns;
            tabelaCliente.DataSource = CL.listarClientes();
            


        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            novo();
            ClienteDAO CL = new ClienteDAO();
            tabelaCliente.DataSource = CL.listarClientes();
        }

        public void geraProntuario()
        {
            string str = DateTime.Now.ToString("ddMMyyyyhhmmss");

            string nome = TxtNome.Text;

            //Aqui faço um split separando por espaços
            string[] n = nome.Split(' ');

            //Armazenara as iniciais das palavars 
            string sigla = "";
            //laço para pegar apenas as primeiras letras do nome

            for (int i = 0; i < n.Length; i++)
            {
                //Dispenso a palavras menores que 3 caracteres
                if (n[i].Length > 3)
                {
                    //Pego somente a primeira da palavra
                    sigla = sigla + n[i].Substring(0, 1);
                }
            }
            TxtProntuario.Text =  sigla + str;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.prontuario = TxtProntuario.Text;
            obj.nome = TxtNome.Text;
            obj.rg = TxtRg.Text;
            obj.cpf = TxtCpf.Text; ;
            obj.data_nascimento = dtaniversario.Text;
            obj.email = TxtEmail.Text;
            obj.telefone = TxtTelefone.Text;
            obj.celular = TxtCelular.Text;
            obj.cep = TxtCep.Text;
            obj.endereco = TxtEndereco.Text;
            obj.numero = TxtNumero.Text;
            obj.complemento = TxtComplemento.Text;
            obj.bairro = TxtBairro.Text;
            obj.cidade = TxtCidade.Text;
            obj.estado = CbUf.Text;
            obj.nome_convenio = TxtNomeConvenio.Text;
            obj.plano = TxtPlano.Text;
            obj.num_cart_convenio = TxtNumPlano.Text;
            obj.data_validade_plano = dtValidadePlano.Text;
            obj.nome_sindicato = TxtSindicato.Text;
            obj.num_cart_sindicato = TxtNumSindicato.Text;
            obj.titular = CbTitular.Text;
            obj.nome_titular = TxtNomeTitular.Text;
            obj.observacao = TxtObs.Text;
            obj.status = CbStatus.Text;
            obj.Data_hora_cad = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            obj.usuario_cad = 1;
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);
            //
            //novo();
            ClienteDAO CL = new ClienteDAO();
            tabelaCliente.DataSource = CL.listarClientes();
        }

        private void BtBuscarCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = TxtCep.Text;
                DataSet dados = new DataSet();
                string xml = "http://viacep.com.br/ws/" + cep + "/xml/";

                dados.ReadXml(xml);

                TxtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString().ToUpper();
                TxtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString().ToUpper();
                TxtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString().ToUpper();
                CbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString().ToUpper();
            }
            catch (Exception)
            {

                MessageBox.Show("endereço não encontrado, por favor digite novamente um cep valido!");
            }
        }

        private void TxtNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                geraProntuario();
                TxtRg.Focus();
            }
        }

        private void tabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BtEditar_Click(object sender, EventArgs e)
        {

        }
        public void novo()
        {
            dtaniversario.Text = "";
            CbStatus.Text = "";
            TxtObs.Text = "";
            TxtNomeTitular.Text = "";
            CbTitular.Text = "";
            TxtNumSindicato.Text = "";
            TxtSindicato.Text = "";
            TxtNumPlano.Text = "";
            TxtPlano.Text = "";
            TxtNomeConvenio.Text = "";
            CbUf.Text = "";
            TxtCidade.Text = "";
            TxtBairro.Text = "";
            TxtComplemento.Text = "";
            TxtNumero.Text = "";
            TxtEndereco.Text = "";
            TxtCep.Text = "";
            TxtCelular.Text = "";
            TxtTelefone.Text = "";
            TxtCpf.Text = "";
            TxtRg.Text = "";
            TxtNome.Text = "";
            TxtProntuario.Text = "";
            TxtId.Text = "";
            TxtEmail.Text = "";
            dtValidadePlano.Text = "";
            tabelaCliente.DataSource = null;
            TxtPesquisa.Text = "";
            grpPesquisar.Visible = true;

        }

        private void tabelaCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            grpPesquisar.Visible = false;
        }
    }
}

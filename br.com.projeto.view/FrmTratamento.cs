using AxiosDental.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxiosDental.br.com.projeto.view
{
    public partial class FrmTratamento : Form
    {


        DataTable carrinho = new DataTable();

        public FrmTratamento()
        {
            InitializeComponent();
            carrinho.Columns.Add("IdAtendimentoItem", typeof(int));
            carrinho.Columns.Add("Dente", typeof(string));
            carrinho.Columns.Add("idProcedimento", typeof(int));
            carrinho.Columns.Add("Procedimento", typeof(string));
            carrinho.Columns.Add("Local", typeof(string));
            carrinho.Columns.Add("Observação", typeof(string));
            carrinho.Columns.Add("Status", typeof(string));
        }
        /*             tabelaItensAtendimento.Columns[0].Name = "IdAtendimentoItem";
             tabelaItensAtendimento.Columns[1].Name = "Dente";
             tabelaItensAtendimento.Columns[2].Name = "idTratamento";
             tabelaItensAtendimento.Columns[3].Name = "Tratamento";
             tabelaItensAtendimento.Columns[4].Name = "Local";
             tabelaItensAtendimento.Columns[5].Name = "Observação";
             tabelaItensAtendimento.Columns[6].Name = "Status";";*/
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = false;
            try
            {
                string[] linha = { TxtIdAtenfimentoItem.Text, TxtDescricao.Text, cbTratamento.SelectedValue.ToString(), cbTratamento.Text, cbLocal.Text, TxtObs.Text,cbStatus.Text};
                tabelaItensAtendimento.Rows.Add(linha);
                carrinho.Rows.Add(0, TxtDescricao.Text, int.Parse(cbTratamento.SelectedValue.ToString()), cbTratamento.Text, cbLocal.Text, TxtObs.Text, cbStatus.Text);

            }
            catch (Exception erro)
            {

                throw;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "18 - Terceiro molar superior direito";
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {
            
        }


        private void BtnFechar_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = false;
        }

        private void Btn17_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "17 - Segundo molar superior direito";
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "16 - Primeiro molar superior direito";
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "15 - Segundo pré molar superior direito";
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "14 - Primeiro pré molar superior direito";
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "13 - Canino superior direito";
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "12 - Incisivo lateral superior direito";
            
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "11 - Incisivo central superior direito";
        }

        private void Btn21_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "21 - Incisivo central superior esquerdo";
        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "22 - Incisivo lateral superior esquerdo";
        }

        private void Btn23_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "23 - Canino superior esquerdo";
        }

        private void Btn24_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "24 - Primeiro pré molar superior esquerdo";
        }

        private void Btn25_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "25 - Segundo pré molar superior esquerdo";
        }

        private void Btn26_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "26 - Primeiro molar superior esquerdo";
        }

        private void Btn27_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "27 - Segundo molar superior esquerdo";
        }

        private void Btn28_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "28 - Terceiro molar superior esquerdo";
        }

        private void Btn48_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "48 - Terceiro molar inferior direito";
        }

        private void Btn47_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "47 - Segundo molar inferior direito";
        }

        private void Btn46_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "46 - Primeiro molar inferior direito";
        }

        private void Btn45_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "45 - Segundo pré molar inferior direito";
        }

        private void Btn44_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "44 - Primeiro pré molar inferior direito";
        }

        private void Btn43_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "43 - Canino inferior direito";
        }

        private void Btn42_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "42 - Incisivo lateral inferior direito";
        }

        private void Btn41_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "41 - Incisivo central inferior direito";
        }

        private void Btn31_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "31 - Incisivo central inferior esquerdo";
        }

        private void Btn32_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "32 - Incisivo lateral inferior esquerdo";
        }

        private void Btn33_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "33 - Canino inferior esquerdo";
        }

        private void Btn34_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "34 - Primeiro pré molar inferior esquerdo";
        }

        private void Btn35_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "35 - Segundo pré molar inferior esquerdo";
        }

        private void Btn36_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "36 - Primeiro molar inferior esquerdo";
        }

        private void Btn37_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "37 - Segundo molar inferior esquerdo";
        }

        private void Btn38_Click(object sender, EventArgs e)
        {
            gpTratamentoArcada.Visible = true;
            TxtDescricao.Text = "38 - Terceiro molar inferior esquerdo";
        }

        private void FrmTratamento_Load(object sender, EventArgs e)
        {
            ClienteDAO c_dao = new ClienteDAO();
            cbCliente.DataSource = c_dao.listarClientes();
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";

            ServicoDAO s_dao = new ServicoDAO();
            cbTratamento.DataSource = s_dao.listarServico();
            cbTratamento.DisplayMember = "descricao";
            cbTratamento.ValueMember = "id";
            criarTabela();


        }
        public void criarTabela()
        {
            tabelaItensAtendimento.ColumnCount = 7;
            tabelaItensAtendimento.Columns[0].Name = "IdAtendimentoItem";
            tabelaItensAtendimento.Columns[1].Name = "Local";
            tabelaItensAtendimento.Columns[2].Name = "idTratamento";
            tabelaItensAtendimento.Columns[3].Name = "Tratamento";
            tabelaItensAtendimento.Columns[4].Name = "Posição";
            tabelaItensAtendimento.Columns[5].Name = "Observação";
            tabelaItensAtendimento.Columns[6].Name = "Status";

            tabelaItensAtendimento.Columns[0].Visible = false;
            tabelaItensAtendimento.Columns[2].Visible = false;
            tabelaItensAtendimento.Columns[4].Visible = false;
            tabelaItensAtendimento.Columns[5].Visible = false;
            //tabelaItensAtendimento.Columns[2].Visible = false;

            tabelaItensAtendimento.Columns[1].Width = 200;
            tabelaItensAtendimento.Columns[3].Width = 300;

        }
    }
}

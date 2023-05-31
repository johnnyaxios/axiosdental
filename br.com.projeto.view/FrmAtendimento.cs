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
using System.Xml.Linq;

namespace AxiosDental.br.com.projeto.view
{
    public partial class FrmAtendimento : Form
    {
        public FrmAtendimento()
        {
            InitializeComponent();
        }

        private void FrmAtendimento_Load(object sender, EventArgs e)
        {
            ClienteDAO c_dao = new ClienteDAO();
            cbCliente.DataSource = c_dao.listarClientes();
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";

            LocalTratamentoDAO localTratamentoDAO = new LocalTratamentoDAO();
            cbLocalTratamento.DataSource = localTratamentoDAO.listar();
            cbLocalTratamento.DisplayMember = "descricao";
            cbLocalTratamento.ValueMember = "id";

            ServicoDAO servicoDAO = new ServicoDAO();
            cbTratamento.DataSource = servicoDAO.listarServico();
            cbTratamento.DisplayMember = "descricao";
            cbTratamento.ValueMember = "id";

            PosicaoTratamentoDAO posicaoTratamentoDAO = new PosicaoTratamentoDAO();
            cbPosicao.DataSource = posicaoTratamentoDAO.listar();
            cbPosicao.DisplayMember = "descricao";
            cbPosicao.ValueMember = "id";


            novo();
        }

        public void novo()
        {
            cbCliente.Text = "";
            cbLocalTratamento.Text = "";
            cbTratamento.Text = "";
            cbPosicao.Text = "";
            TxtId.Clear();
            TxtObs.Clear();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            AtendimentoItem obj = new AtendimentoItem();

            obj.atendimento_id = int.Parse(TxtId.Text);
            obj.local_id = int.Parse(cbLocalTratamento.SelectedValue.ToString());
            obj.posicao_id = int.Parse(cbPosicao.SelectedValue.ToString());
            obj.procedimento_id = int.Parse(cbTratamento.SelectedValue.ToString());
            obj.observacao = TxtObs.Text;
            obj.status = cbStatus.Text;

            AtendimentoItemDAO dao = new AtendimentoItemDAO();
            dao.cadastrar(obj);

            AtendimentoItemDAO no = new AtendimentoItemDAO();
            tabela.AutoGenerateColumns = false;
            tabela.DataSource = tabela.Columns;
            tabela.DataSource = no.buscarPorCriterio(int.Parse(TxtId.Text));

            cbLocalTratamento.Text = "";
            cbTratamento.Text = "";
            cbPosicao.Text = "";
            cbStatus.Text = "";
            TxtObs.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atendimento obj = new Atendimento();
            obj.cliente_id = int.Parse(cbCliente.SelectedValue.ToString());
            obj.Data_hora_cad = DateTime.Now.ToShortDateString();
            
            AtendimentoDAO atendimentoDAO = new AtendimentoDAO();
            
            TxtId.Text = atendimentoDAO.cadastrar(obj).ToString();
            if (TxtId.Text != "")
            {
                grTratamento.Enabled = true;
            }

           
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            grTratamento.Enabled = false;
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            Relatorios.FrmRelatorioAtendimento frm = new Relatorios.FrmRelatorioAtendimento();
            
            frm.Show();
        }
    }
}

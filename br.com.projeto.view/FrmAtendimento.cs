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
        public bool statusInicio = false;
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

            AtendimentoDAO no = new AtendimentoDAO();
            tabelaAtendimento.AutoGenerateColumns = false;
            tabelaAtendimento.DataSource = tabelaAtendimento.Columns;
            tabelaAtendimento.DataSource = no.listar();
            GrpAtendimentos.Left = 3;
            GrpAtendimentos.Top = 106;

            novo();
        }

        public void novo()
        {
            TxtId.Clear();
            cbCliente.Text = "";
            TxtStatusAtendimento.Clear();
            CbStatusAtendimento.Text = "";
            cbLocalTratamento.Text = "";
            cbTratamento.Text = "";
            cbPosicao.Text = "";
            txtid_atendimento_item.Clear();
            TxtObs.Clear();
            cbStatus.Text = "";
            tabela.DataSource = "";
            BiIniciar.Enabled = true;
            statusInicio = false;
            cbStatus.Enabled = false;
            btFinalizar.Enabled = false;
            BtExcluir.Enabled = false;
            BtSalvar.Enabled = false;
            
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            AtendimentoItem obj = new AtendimentoItem();
            if (txtid_atendimento_item.Text == "")
            {
            obj.atendimento_id = int.Parse(TxtId.Text);
            obj.local_id = int.Parse(cbLocalTratamento.SelectedValue.ToString());
            obj.posicao_id = int.Parse(cbPosicao.SelectedValue.ToString());
            obj.procedimento_id = int.Parse(cbTratamento.SelectedValue.ToString());
            obj.observacao = TxtObs.Text;
            obj.status = cbStatus.Text;

            AtendimentoItemDAO dao = new AtendimentoItemDAO();
            dao.cadastrar(obj);

            }
            else
            {
                obj.id = int.Parse(txtid_atendimento_item.Text);
                obj.status = cbStatus.Text;
                AtendimentoItemDAO dao = new AtendimentoItemDAO();
                dao.alterarStatus(obj);

            }

            AtendimentoItemDAO no = new AtendimentoItemDAO();
            tabela.AutoGenerateColumns = false;
            tabela.DataSource = tabela.Columns;
            tabela.DataSource = no.buscarPorCriterio(int.Parse(TxtId.Text));

            cbLocalTratamento.Text = "";
            cbTratamento.Text = "";
            cbPosicao.Text = "";
            cbStatus.Text = "";
            TxtObs.Clear();
            txtid_atendimento_item.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbCliente.Text != "")
            {

            Atendimento obj = new Atendimento();
            obj.cliente_id = int.Parse(cbCliente.SelectedValue.ToString());
            obj.Data_hora_cad = DateTime.Now.ToShortDateString();
            obj.status = "Atendimento";
            TxtStatusAtendimento.Text = "Atendimento";
            AtendimentoDAO atendimentoDAO = new AtendimentoDAO();
            
            TxtId.Text = atendimentoDAO.cadastrar(obj).ToString();
            if (TxtId.Text != "")
            {
                grTratamento.Enabled = true;
                BiIniciar.Enabled = false;
            }
            statusInicio = true;
            btFinalizar.Enabled = true;
            BtExcluir.Enabled = true;
            BtSalvar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Favor escolher um cliente para continuar.");
            }
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            Program.idAtendimento = TxtId.Text ;
            if (statusInicio == true)
            {
                Relatorios.FrmRelatorios frm = new Relatorios.FrmRelatorios();
                frm.Show();
                novo();
                GrpAtendimentos.Visible = true;
                AtendimentoDAO no = new AtendimentoDAO();
                tabelaAtendimento.AutoGenerateColumns = false;
                tabelaAtendimento.DataSource = tabelaAtendimento.Columns;
                tabelaAtendimento.DataSource = no.listar();

            }
            else
            {
                grStatusAtendimento.Visible = true;
            }
            

        }

        private void tabelaAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = tabelaAtendimento.CurrentRow.Cells[0].Value.ToString();
            cbCliente.Text = tabelaAtendimento.CurrentRow.Cells[3].Value.ToString();
            TxtStatusAtendimento.Text = tabelaAtendimento.CurrentRow.Cells[4].Value.ToString();

            AtendimentoItemDAO no = new AtendimentoItemDAO();
            tabela.AutoGenerateColumns = false;
            tabela.DataSource = tabela.Columns;
            tabela.DataSource = no.buscarPorCriterio(int.Parse(TxtId.Text));
            GrpAtendimentos.Visible = false;

            if (TxtId.Text != "")
            {
                grTratamento.Enabled = true;
                BiIniciar.Enabled = false;

                cbLocalTratamento.Enabled = false;
                cbTratamento.Enabled = false;
                cbPosicao.Enabled = false;
                cbStatus.Enabled = true;
                TxtObs.Enabled = false;

            }
            btFinalizar.Enabled = true;
            BtExcluir.Enabled = true;
            BtSalvar.Enabled = true;
        }

        private void tabelaAtendimento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Status(object sender, EventArgs e)
        {

        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            AtendimentoDAO no = new AtendimentoDAO();
            tabelaAtendimento.AutoGenerateColumns = false;
            tabelaAtendimento.DataSource = tabelaAtendimento.Columns;
            tabelaAtendimento.DataSource = no.listar();
            GrpAtendimentos.Visible = true;
        }

        private void tabela_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_atendimento_item.Text = tabela.CurrentRow.Cells[0].Value.ToString();
            cbLocalTratamento.Text = tabela.CurrentRow.Cells[2].Value.ToString();
            cbTratamento.Text = tabela.CurrentRow.Cells[6].Value.ToString();
            cbPosicao.Text = tabela.CurrentRow.Cells[4].Value.ToString();
            TxtObs.Text = tabela.CurrentRow.Cells[7].Value.ToString();
            cbStatus.Text = tabela.CurrentRow.Cells[8].Value.ToString();


           
        }

        private void GrpAtendimentos_Enter(object sender, EventArgs e)
        {

        }

        private void BtSalvarStatus_Click(object sender, EventArgs e)
        {
            if (CbStatusAtendimento.Text != "")
            {

            Atendimento obj = new Atendimento();
            obj.id = int.Parse(TxtId.Text.ToString());
            obj.status = CbStatusAtendimento.Text;

            AtendimentoDAO atendimentoDAO = new AtendimentoDAO();
            atendimentoDAO.alterarStatus(obj);
            TxtStatusAtendimento.Text = CbStatusAtendimento.Text;
            }
            grStatusAtendimento.Visible = false;
            novo();
            GrpAtendimentos.Visible = true;
            AtendimentoDAO no = new AtendimentoDAO();
            tabelaAtendimento.AutoGenerateColumns = false;
            tabelaAtendimento.DataSource = tabelaAtendimento.Columns;
            tabelaAtendimento.DataSource = no.listar();

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            grStatusAtendimento.Visible = false;
            CbStatusAtendimento.Text = "";
        }

        private void BtNovo_Click_1(object sender, EventArgs e)
        {
            GrpAtendimentos.Visible = false;
            novo();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {

        }
    }
}

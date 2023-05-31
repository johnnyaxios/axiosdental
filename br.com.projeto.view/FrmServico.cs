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

namespace AxiosDental.br.com.projeto.view
{
    public partial class FrmServico : Form
    {
        public FrmServico()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void CbTitular_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void TbCadCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            TxtCodInterno.Clear();
            TxtDescricao.Clear();
            TxtValor.Clear();
            TxtId.Clear();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Procedimento obj = new Procedimento();
            obj.codigo_interno = TxtCodInterno.Text;
            obj.descricao = TxtDescricao.Text;
            obj.valor = decimal.Parse(TxtValor.Text);
            obj.Data_hora_cad = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            obj.usuario_cad = int.Parse("1");

            ServicoDAO dao = new ServicoDAO();
            dao.cadastrarServico(obj);
            novo();
            ServicoDAO CL = new ServicoDAO();
            tabelaServico.DataSource = CL.listarServico();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            Procedimento obj = new Procedimento();
            obj.id = int.Parse(TxtId.Text);
            ServicoDAO dao = new ServicoDAO();
            dao.excluirServico(obj);

            novo();
            ServicoDAO Sdao = new ServicoDAO();
            tabelaServico.DataSource = Sdao.listarServico();
        }
        public void novo()
        {
            TxtCodInterno.Clear();
            TxtDescricao.Clear();
            TxtValor.Clear();
            TxtId.Clear();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            Procedimento obj = new Procedimento();
            obj.id = int.Parse(TxtId.Text);
            obj.codigo_interno = TxtCodInterno.Text;
            obj.descricao = TxtDescricao.Text;
            obj.valor = decimal.Parse(TxtValor.Text);
            obj.Data_hora_cad = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            obj.usuario_cad = int.Parse("1");

            ServicoDAO dao = new ServicoDAO();
            dao.alterarServico(obj);
            novo();
            ServicoDAO CL = new ServicoDAO();
            tabelaServico.DataSource = CL.listarServico();
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void tabelaServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = tabelaServico.CurrentRow.Cells[0].Value.ToString();
            TxtCodInterno.Text = tabelaServico.CurrentRow.Cells[1].Value.ToString();
            TxtDescricao.Text = tabelaServico.CurrentRow.Cells[2].Value.ToString();
            TxtValor.Text = tabelaServico.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void FrmServico_Load(object sender, EventArgs e)
        {
            ServicoDAO CL = new ServicoDAO();
            tabelaServico.DataSource = CL.listarServico();
        }

        private void tabelaServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtPesquisar_Click_1(object sender, EventArgs e)
        {
            string codInterno = TxtDescricao.Text;

            ServicoDAO dao = new ServicoDAO();
            dao.buscarServocoPorCodInterno(codInterno);

            tabelaServico.DataSource = dao.buscarServocoPorCodInterno(codInterno);
            if (TxtDescricao.Text == "")
            {
                ServicoDAO CL = new ServicoDAO();
                tabelaServico.DataSource = CL.listarServico();
            }
        }
    }
}

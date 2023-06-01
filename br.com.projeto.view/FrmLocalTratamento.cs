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
    public partial class FrmLocalTratamento : Form
    {
        public FrmLocalTratamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocalTratamentoDAO adao = new LocalTratamentoDAO();
            tabela.DataSource = adao.buscarPorCriterio(TxtDescricao.Text);
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            LocalTratamento obj = new LocalTratamento();


            obj.descricao = TxtDescricao.Text;
            if (TxtCodigo.Text != "")
            {
                obj.id = int.Parse(TxtCodigo.Text);

            }

            LocalTratamentoDAO dao = new LocalTratamentoDAO();
            if (TxtCodigo.Text != "")
            {
                dao.alterar(obj);

            }
            else
            {

                dao.cadastrar(obj);
            }
            novo();
            LocalTratamentoDAO no = new LocalTratamentoDAO();
            tabela.AutoGenerateColumns = false;
            tabela.DataSource = tabela.Columns;
            tabela.DataSource = no.listar();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            LocalTratamento obj = new LocalTratamento();
            if (TxtCodigo.Text != "")
            {
                obj.id = int.Parse(TxtCodigo.Text);


            }

            LocalTratamentoDAO dao = new LocalTratamentoDAO();
            dao.deletar(obj);
            novo();
            LocalTratamentoDAO no = new LocalTratamentoDAO();
            tabela.AutoGenerateColumns = false;
            tabela.DataSource = tabela.Columns;
            tabela.DataSource = no.listar();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {

        }

        private void FrmLocalTratamento_Load(object sender, EventArgs e)
        {
            LocalTratamentoDAO no = new LocalTratamentoDAO();
            tabela.AutoGenerateColumns = false;
            tabela.DataSource = tabela.Columns;
            tabela.DataSource = no.listar();
        }
        public void novo()
        {
            TxtCodigo.Clear();
            TxtDescricao.Clear();
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

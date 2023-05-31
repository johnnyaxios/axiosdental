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
    public partial class FrmPosicao : Form
    {
        public FrmPosicao()
        {
            InitializeComponent();
        }

        private void FrmPosicao_Load(object sender, EventArgs e)
        {
            PosicaoTratamentoDAO no = new PosicaoTratamentoDAO();
            tabela.AutoGenerateColumns = false;
            tabela.DataSource = tabela.Columns;
            tabela.DataSource = no.listar();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            PosicaoTratamentoDAO adao = new PosicaoTratamentoDAO();
            tabela.DataSource = adao.buscarPorCriterio(TxtDescricao.Text);
        }
        public void novo()
        {
            TxtCodigo.Clear();
            TxtDescricao.Clear();
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            PosicaoTratamento obj = new PosicaoTratamento();


            obj.descricao = TxtDescricao.Text;
            if (TxtCodigo.Text != "")
            {
                obj.id = int.Parse(TxtCodigo.Text);

            }

            PosicaoTratamentoDAO dao = new PosicaoTratamentoDAO();
            if (TxtCodigo.Text != "")
            {
                dao.alterar(obj);

            }
            else
            {

                dao.cadastrar(obj);
            }
            novo();
            PosicaoTratamentoDAO no = new PosicaoTratamentoDAO();
            tabela.AutoGenerateColumns = false;
            tabela.DataSource = tabela.Columns;
            tabela.DataSource = no.listar();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            PosicaoTratamento obj = new PosicaoTratamento();
            if (TxtCodigo.Text != "")
            {
                obj.id = int.Parse(TxtCodigo.Text);


            }

            PosicaoTratamentoDAO dao = new PosicaoTratamentoDAO();
            dao.deletar(obj);
            novo();
            PosicaoTratamentoDAO no = new PosicaoTratamentoDAO();
            tabela.AutoGenerateColumns = false;
            tabela.DataSource = tabela.Columns;
            tabela.DataSource = no.listar();
        }
    }
}

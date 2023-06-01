using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxiosDental.Relatorios
{
    public partial class FrmRelatorios : Form
    {
        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'axios_dental_devDataSet.atendimento_item'. Você pode movê-la ou removê-la conforme necessário.
            this.atendimento_itemTableAdapter.Fill(this.axios_dental_devDataSet.atendimento_item, Convert.ToInt32(Program.idAtendimento));
            // TODO: esta linha de código carrega dados na tabela 'axios_dental_devDataSet.atendimento_item'. Você pode movê-la ou removê-la conforme necessário.
            this.atendimento_clienteTableAdapter.Fill(this.axios_dental_devDataSet.atendimento_cliente,Convert.ToInt32(Program.idAtendimento));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

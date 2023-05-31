using AxiosDental.br.com.projeto.dao;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxiosDental.Relatorios
{
    public partial class FrmRelatorioAtendimento : Form
    {
        public int _idatendimento;
        public FrmRelatorioAtendimento()
        {
            InitializeComponent();

        }
        public FrmRelatorioAtendimento(int idAtendimento)
        {
            InitializeComponent();
            _idatendimento = idAtendimento;

        }
        private void FrmRelatorioAtendimento_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            _idatendimento = 7;
            this.reportViewer1.LocalReport.DataSources.Clear(); 
            reportViewer1.Reset(); 
            reportViewer1.LocalReport.ReportEmbeddedResource = "AxiosDental.Relatorios.RelAtendimento.rdlc"; 
           
            AtendimentoItemDAO dao = new AtendimentoItemDAO();
            DataTable dt = new DataTable();
            //dt.Load(cmd.ExecuteReader());
            //con.Close();
            ReportDataSource rprtDTSource = new ReportDataSource();
            rprtDTSource.Name = "dsAtendimentoItem";
            rprtDTSource.Value = dao.buscarPorCriterio(int.Parse(_idatendimento.ToString()));
            this.reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
            this.reportViewer1.RefreshReport();




        }
    }
}

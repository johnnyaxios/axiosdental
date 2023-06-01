
namespace AxiosDental.Relatorios
{
    partial class FrmRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.atendimentoitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.axios_dental_devDataSet = new AxiosDental.axios_dental_devDataSet();
            this.atendimento_itemTableAdapter = new AxiosDental.axios_dental_devDataSetTableAdapters.atendimento_itemTableAdapter();
            this.atendimentoclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atendimento_clienteTableAdapter = new AxiosDental.axios_dental_devDataSetTableAdapters.atendimento_clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axios_dental_devDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoclienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.atendimentoitemBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.atendimentoclienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AxiosDental.Relatorios.RptRelatorioAtendimento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // atendimentoitemBindingSource
            // 
            this.atendimentoitemBindingSource.DataMember = "atendimento_item";
            this.atendimentoitemBindingSource.DataSource = this.axios_dental_devDataSet;
            // 
            // axios_dental_devDataSet
            // 
            this.axios_dental_devDataSet.DataSetName = "axios_dental_devDataSet";
            this.axios_dental_devDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atendimento_itemTableAdapter
            // 
            this.atendimento_itemTableAdapter.ClearBeforeFill = true;
            // 
            // atendimentoclienteBindingSource
            // 
            this.atendimentoclienteBindingSource.DataMember = "atendimento_cliente";
            this.atendimentoclienteBindingSource.DataSource = this.axios_dental_devDataSet;
            // 
            // atendimento_clienteTableAdapter
            // 
            this.atendimento_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorios";
            this.Text = "FrmRelatorios";
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axios_dental_devDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoclienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private axios_dental_devDataSet axios_dental_devDataSet;
        private System.Windows.Forms.BindingSource atendimentoitemBindingSource;
        private axios_dental_devDataSetTableAdapters.atendimento_itemTableAdapter atendimento_itemTableAdapter;
        private System.Windows.Forms.BindingSource atendimentoclienteBindingSource;
        private axios_dental_devDataSetTableAdapters.atendimento_clienteTableAdapter atendimento_clienteTableAdapter;
    }
}
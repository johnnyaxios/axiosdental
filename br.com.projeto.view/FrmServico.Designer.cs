namespace AxiosDental.br.com.projeto.view
{
    partial class FrmServico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtNovo = new System.Windows.Forms.Button();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCodInterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.tabelaServico = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(219, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serviços";
            // 
            // BtVoltar
            // 
            this.BtVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtVoltar.ForeColor = System.Drawing.Color.White;
            this.BtVoltar.Location = new System.Drawing.Point(568, 425);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(133, 36);
            this.BtVoltar.TabIndex = 133;
            this.BtVoltar.Text = "Voltar";
            this.BtVoltar.UseVisualStyleBackColor = false;
            // 
            // BtEditar
            // 
            this.BtEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditar.ForeColor = System.Drawing.Color.White;
            this.BtEditar.Location = new System.Drawing.Point(429, 425);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(133, 36);
            this.BtEditar.TabIndex = 132;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = false;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtExcluir
            // 
            this.BtExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExcluir.ForeColor = System.Drawing.Color.White;
            this.BtExcluir.Location = new System.Drawing.Point(290, 425);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(133, 36);
            this.BtExcluir.TabIndex = 131;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = false;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // BtSalvar
            // 
            this.BtSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvar.ForeColor = System.Drawing.Color.White;
            this.BtSalvar.Location = new System.Drawing.Point(151, 425);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(133, 36);
            this.BtSalvar.TabIndex = 130;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = false;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // BtNovo
            // 
            this.BtNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNovo.ForeColor = System.Drawing.Color.White;
            this.BtNovo.Location = new System.Drawing.Point(12, 425);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(133, 36);
            this.BtNovo.TabIndex = 129;
            this.BtNovo.Text = "Novo";
            this.BtNovo.UseVisualStyleBackColor = false;
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(82, 185);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(161, 20);
            this.TxtValor.TabIndex = 164;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 165;
            this.label12.Text = "Valor";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(82, 155);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(500, 20);
            this.TxtDescricao.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 163;
            this.label4.Text = "Descrição";
            // 
            // TxtCodInterno
            // 
            this.TxtCodInterno.Location = new System.Drawing.Point(82, 129);
            this.TxtCodInterno.Name = "TxtCodInterno";
            this.TxtCodInterno.Size = new System.Drawing.Size(161, 20);
            this.TxtCodInterno.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 162;
            this.label3.Text = "Cód. Interno";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(82, 106);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 158;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 161;
            this.label2.Text = "ID";
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtPesquisar.Location = new System.Drawing.Point(588, 151);
            this.BtPesquisar.Name = "BtPesquisar";
            this.BtPesquisar.Size = new System.Drawing.Size(107, 27);
            this.BtPesquisar.TabIndex = 166;
            this.BtPesquisar.Text = "Pesquisar";
            this.BtPesquisar.UseVisualStyleBackColor = false;
            this.BtPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click_1);
            // 
            // tabelaServico
            // 
            this.tabelaServico.AllowUserToAddRows = false;
            this.tabelaServico.AllowUserToDeleteRows = false;
            this.tabelaServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaServico.Location = new System.Drawing.Point(14, 211);
            this.tabelaServico.Name = "tabelaServico";
            this.tabelaServico.ReadOnly = true;
            this.tabelaServico.RowHeadersVisible = false;
            this.tabelaServico.Size = new System.Drawing.Size(681, 208);
            this.tabelaServico.TabIndex = 167;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AxiosDental.Properties.Resources.pagasus6;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 463);
            this.Controls.Add(this.tabelaServico);
            this.Controls.Add(this.BtPesquisar);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCodInterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.BtEditar);
            this.Controls.Add(this.BtExcluir);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.BtNovo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmServico";
            this.Text = "FrmServico";
            this.Load += new System.EventHandler(this.FrmServico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodInterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtPesquisar;
        private System.Windows.Forms.DataGridView tabelaServico;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
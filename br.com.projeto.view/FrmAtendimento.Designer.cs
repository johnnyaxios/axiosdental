namespace AxiosDental.br.com.projeto.view
{
    partial class FrmAtendimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BiIniciar = new System.Windows.Forms.Button();
            this.grTratamento = new System.Windows.Forms.GroupBox();
            this.txtid_atendimento_item = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPosicao = new System.Windows.Forms.ComboBox();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTratamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLocalTratamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.TxtStatusAtendimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grStatusAtendimento = new System.Windows.Forms.GroupBox();
            this.BtSalvarStatus = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.CbStatusAtendimento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabelaAtendimento = new System.Windows.Forms.DataGridView();
            this.id_tratamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronturario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtNovo = new System.Windows.Forms.Button();
            this.BtSair = new System.Windows.Forms.Button();
            this.GrpAtendimentos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.grTratamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.grStatusAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAtendimento)).BeginInit();
            this.GrpAtendimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(218, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta e Tratamentos";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(49, 132);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(367, 21);
            this.cbCliente.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 139;
            this.label3.Text = "Nome";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(49, 106);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "ID";
            // 
            // BtVoltar
            // 
            this.BtVoltar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtVoltar.ForeColor = System.Drawing.Color.White;
            this.BtVoltar.Location = new System.Drawing.Point(503, 474);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(133, 36);
            this.BtVoltar.TabIndex = 157;
            this.BtVoltar.Text = "Voltar";
            this.BtVoltar.UseVisualStyleBackColor = false;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // BtExcluir
            // 
            this.BtExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExcluir.ForeColor = System.Drawing.Color.White;
            this.BtExcluir.Location = new System.Drawing.Point(225, 474);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(133, 36);
            this.BtExcluir.TabIndex = 156;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = false;
            // 
            // BtSalvar
            // 
            this.BtSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvar.ForeColor = System.Drawing.Color.White;
            this.BtSalvar.Location = new System.Drawing.Point(86, 474);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(133, 36);
            this.BtSalvar.TabIndex = 155;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = false;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // BiIniciar
            // 
            this.BiIniciar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BiIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiIniciar.ForeColor = System.Drawing.Color.White;
            this.BiIniciar.Location = new System.Drawing.Point(432, 128);
            this.BiIniciar.Name = "BiIniciar";
            this.BiIniciar.Size = new System.Drawing.Size(92, 27);
            this.BiIniciar.TabIndex = 158;
            this.BiIniciar.Text = "Iniciar";
            this.BiIniciar.UseVisualStyleBackColor = false;
            this.BiIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grTratamento
            // 
            this.grTratamento.Controls.Add(this.txtid_atendimento_item);
            this.grTratamento.Controls.Add(this.label11);
            this.grTratamento.Controls.Add(this.TxtValor);
            this.grTratamento.Controls.Add(this.label5);
            this.grTratamento.Controls.Add(this.cbPosicao);
            this.grTratamento.Controls.Add(this.tabela);
            this.grTratamento.Controls.Add(this.cbStatus);
            this.grTratamento.Controls.Add(this.label9);
            this.grTratamento.Controls.Add(this.label8);
            this.grTratamento.Controls.Add(this.TxtObs);
            this.grTratamento.Controls.Add(this.label7);
            this.grTratamento.Controls.Add(this.cbTratamento);
            this.grTratamento.Controls.Add(this.label6);
            this.grTratamento.Controls.Add(this.cbLocalTratamento);
            this.grTratamento.Controls.Add(this.label4);
            this.grTratamento.Enabled = false;
            this.grTratamento.Location = new System.Drawing.Point(3, 163);
            this.grTratamento.Name = "grTratamento";
            this.grTratamento.Size = new System.Drawing.Size(722, 305);
            this.grTratamento.TabIndex = 159;
            this.grTratamento.TabStop = false;
            this.grTratamento.Text = "Tratamento";
            // 
            // txtid_atendimento_item
            // 
            this.txtid_atendimento_item.Location = new System.Drawing.Point(326, 100);
            this.txtid_atendimento_item.Name = "txtid_atendimento_item";
            this.txtid_atendimento_item.ReadOnly = true;
            this.txtid_atendimento_item.Size = new System.Drawing.Size(100, 20);
            this.txtid_atendimento_item.TabIndex = 167;
            this.txtid_atendimento_item.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 168;
            this.label11.Text = "ID";
            this.label11.Visible = false;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(562, 47);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(142, 20);
            this.TxtValor.TabIndex = 166;
            this.TxtValor.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 165;
            this.label5.Text = "Valor";
            this.label5.Visible = false;
            // 
            // cbPosicao
            // 
            this.cbPosicao.FormattingEnabled = true;
            this.cbPosicao.Location = new System.Drawing.Point(556, 18);
            this.cbPosicao.Name = "cbPosicao";
            this.cbPosicao.Size = new System.Drawing.Size(137, 21);
            this.cbPosicao.TabIndex = 164;
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_local,
            this.local,
            this.id_posicao,
            this.posicao,
            this.procedimento_id,
            this.procedimento,
            this.observacao,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabela.Location = new System.Drawing.Point(15, 123);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabela.RowHeadersVisible = false;
            this.tabela.Size = new System.Drawing.Size(701, 173);
            this.tabela.TabIndex = 163;
            this.tabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_CellContentClick);
            this.tabela.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "item_id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_local
            // 
            this.id_local.DataPropertyName = "id_local";
            this.id_local.HeaderText = "id_local";
            this.id_local.Name = "id_local";
            this.id_local.ReadOnly = true;
            this.id_local.Visible = false;
            // 
            // local
            // 
            this.local.DataPropertyName = "local";
            this.local.HeaderText = "Local Tratamento";
            this.local.Name = "local";
            this.local.ReadOnly = true;
            this.local.Width = 300;
            // 
            // id_posicao
            // 
            this.id_posicao.DataPropertyName = "id_posicao";
            this.id_posicao.HeaderText = "id_posicao";
            this.id_posicao.Name = "id_posicao";
            this.id_posicao.ReadOnly = true;
            this.id_posicao.Visible = false;
            // 
            // posicao
            // 
            this.posicao.DataPropertyName = "posicao";
            this.posicao.HeaderText = "Posição";
            this.posicao.Name = "posicao";
            this.posicao.ReadOnly = true;
            // 
            // procedimento_id
            // 
            this.procedimento_id.DataPropertyName = "id_procedimento";
            this.procedimento_id.HeaderText = "procedimento_id";
            this.procedimento_id.Name = "procedimento_id";
            this.procedimento_id.ReadOnly = true;
            this.procedimento_id.Visible = false;
            // 
            // procedimento
            // 
            this.procedimento.DataPropertyName = "procedimeto";
            this.procedimento.HeaderText = "Procedimento";
            this.procedimento.Name = "procedimento";
            this.procedimento.ReadOnly = true;
            this.procedimento.Width = 300;
            // 
            // observacao
            // 
            this.observacao.DataPropertyName = "observacao";
            this.observacao.HeaderText = "Observação";
            this.observacao.Name = "observacao";
            this.observacao.ReadOnly = true;
            this.observacao.Width = 300;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "",
            "Aguardando",
            "Realizado",
            "Cancelado",
            "Aprovado"});
            this.cbStatus.Location = new System.Drawing.Point(96, 97);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(152, 21);
            this.cbStatus.TabIndex = 162;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 161;
            this.label9.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 160;
            this.label8.Text = "Posição";
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(96, 71);
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(444, 20);
            this.TxtObs.TabIndex = 159;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 158;
            this.label7.Text = "Observação";
            // 
            // cbTratamento
            // 
            this.cbTratamento.FormattingEnabled = true;
            this.cbTratamento.Location = new System.Drawing.Point(96, 44);
            this.cbTratamento.Name = "cbTratamento";
            this.cbTratamento.Size = new System.Drawing.Size(377, 21);
            this.cbTratamento.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 156;
            this.label6.Text = "Tratamento";
            // 
            // cbLocalTratamento
            // 
            this.cbLocalTratamento.FormattingEnabled = true;
            this.cbLocalTratamento.Location = new System.Drawing.Point(106, 17);
            this.cbLocalTratamento.Name = "cbLocalTratamento";
            this.cbLocalTratamento.Size = new System.Drawing.Size(367, 21);
            this.cbLocalTratamento.TabIndex = 155;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 154;
            this.label4.Text = "Local Tratamento";
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.White;
            this.btFinalizar.Location = new System.Drawing.Point(364, 474);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(133, 36);
            this.btFinalizar.TabIndex = 160;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // TxtStatusAtendimento
            // 
            this.TxtStatusAtendimento.Location = new System.Drawing.Point(264, 106);
            this.TxtStatusAtendimento.Name = "TxtStatusAtendimento";
            this.TxtStatusAtendimento.ReadOnly = true;
            this.TxtStatusAtendimento.Size = new System.Drawing.Size(142, 20);
            this.TxtStatusAtendimento.TabIndex = 168;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 167;
            this.label10.Text = "Status Atendimento";
            this.label10.Click += new System.EventHandler(this.Status);
            // 
            // grStatusAtendimento
            // 
            this.grStatusAtendimento.Controls.Add(this.BtSalvarStatus);
            this.grStatusAtendimento.Controls.Add(this.BtCancelar);
            this.grStatusAtendimento.Controls.Add(this.CbStatusAtendimento);
            this.grStatusAtendimento.Controls.Add(this.label12);
            this.grStatusAtendimento.Location = new System.Drawing.Point(260, 109);
            this.grStatusAtendimento.Name = "grStatusAtendimento";
            this.grStatusAtendimento.Size = new System.Drawing.Size(200, 100);
            this.grStatusAtendimento.TabIndex = 169;
            this.grStatusAtendimento.TabStop = false;
            this.grStatusAtendimento.Text = "Status do Atendimento";
            this.grStatusAtendimento.Visible = false;
            // 
            // BtSalvarStatus
            // 
            this.BtSalvarStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtSalvarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvarStatus.ForeColor = System.Drawing.Color.White;
            this.BtSalvarStatus.Location = new System.Drawing.Point(6, 66);
            this.BtSalvarStatus.Name = "BtSalvarStatus";
            this.BtSalvarStatus.Size = new System.Drawing.Size(92, 27);
            this.BtSalvarStatus.TabIndex = 166;
            this.BtSalvarStatus.Text = "Salvar";
            this.BtSalvarStatus.UseVisualStyleBackColor = false;
            this.BtSalvarStatus.Click += new System.EventHandler(this.BtSalvarStatus_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.Color.Red;
            this.BtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.Location = new System.Drawing.Point(102, 66);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(92, 27);
            this.BtCancelar.TabIndex = 165;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // CbStatusAtendimento
            // 
            this.CbStatusAtendimento.FormattingEnabled = true;
            this.CbStatusAtendimento.Items.AddRange(new object[] {
            "",
            "Aprovado",
            "Reprovado",
            "Finalizado"});
            this.CbStatusAtendimento.Location = new System.Drawing.Point(17, 35);
            this.CbStatusAtendimento.Name = "CbStatusAtendimento";
            this.CbStatusAtendimento.Size = new System.Drawing.Size(177, 21);
            this.CbStatusAtendimento.TabIndex = 164;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 163;
            this.label12.Text = "Status";
            // 
            // tabelaAtendimento
            // 
            this.tabelaAtendimento.AllowUserToAddRows = false;
            this.tabelaAtendimento.AllowUserToDeleteRows = false;
            this.tabelaAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaAtendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tratamento,
            this.pronturario,
            this.id_paciente,
            this.nome,
            this.status_atendimento});
            this.tabelaAtendimento.Location = new System.Drawing.Point(12, 25);
            this.tabelaAtendimento.Name = "tabelaAtendimento";
            this.tabelaAtendimento.ReadOnly = true;
            this.tabelaAtendimento.RowHeadersVisible = false;
            this.tabelaAtendimento.Size = new System.Drawing.Size(695, 337);
            this.tabelaAtendimento.TabIndex = 0;
            this.tabelaAtendimento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaAtendimento_CellContentClick);
            this.tabelaAtendimento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaAtendimento_CellDoubleClick);
            // 
            // id_tratamento
            // 
            this.id_tratamento.DataPropertyName = "id_atendimento";
            this.id_tratamento.HeaderText = "id_tratamento";
            this.id_tratamento.Name = "id_tratamento";
            this.id_tratamento.ReadOnly = true;
            this.id_tratamento.Visible = false;
            // 
            // pronturario
            // 
            this.pronturario.DataPropertyName = "prontuario";
            this.pronturario.HeaderText = "Pronturario";
            this.pronturario.Name = "pronturario";
            this.pronturario.ReadOnly = true;
            this.pronturario.Width = 150;
            // 
            // id_paciente
            // 
            this.id_paciente.DataPropertyName = "id_cliente";
            this.id_paciente.HeaderText = "id_paciente";
            this.id_paciente.Name = "id_paciente";
            this.id_paciente.ReadOnly = true;
            this.id_paciente.Visible = false;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 400;
            // 
            // status_atendimento
            // 
            this.status_atendimento.DataPropertyName = "status";
            this.status_atendimento.HeaderText = "Status";
            this.status_atendimento.Name = "status_atendimento";
            this.status_atendimento.ReadOnly = true;
            // 
            // BtNovo
            // 
            this.BtNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNovo.ForeColor = System.Drawing.Color.White;
            this.BtNovo.Location = new System.Drawing.Point(429, 368);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(133, 36);
            this.BtNovo.TabIndex = 155;
            this.BtNovo.Text = "Novo";
            this.BtNovo.UseVisualStyleBackColor = false;
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click_1);
            // 
            // BtSair
            // 
            this.BtSair.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSair.ForeColor = System.Drawing.Color.White;
            this.BtSair.Location = new System.Drawing.Point(568, 368);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(133, 36);
            this.BtSair.TabIndex = 156;
            this.BtSair.Text = "Sair";
            this.BtSair.UseVisualStyleBackColor = false;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // GrpAtendimentos
            // 
            this.GrpAtendimentos.Controls.Add(this.BtSair);
            this.GrpAtendimentos.Controls.Add(this.BtNovo);
            this.GrpAtendimentos.Controls.Add(this.tabelaAtendimento);
            this.GrpAtendimentos.Location = new System.Drawing.Point(3, 106);
            this.GrpAtendimentos.Name = "GrpAtendimentos";
            this.GrpAtendimentos.Size = new System.Drawing.Size(716, 410);
            this.GrpAtendimentos.TabIndex = 161;
            this.GrpAtendimentos.TabStop = false;
            this.GrpAtendimentos.Text = "Lista de Atendimentos";
            this.GrpAtendimentos.Enter += new System.EventHandler(this.GrpAtendimentos_Enter);
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
            // FrmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 516);
            this.Controls.Add(this.GrpAtendimentos);
            this.Controls.Add(this.grStatusAtendimento);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.grTratamento);
            this.Controls.Add(this.BiIniciar);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.BtExcluir);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtStatusAtendimento);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.Name = "FrmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAtendimento";
            this.Load += new System.EventHandler(this.FrmAtendimento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grTratamento.ResumeLayout(false);
            this.grTratamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.grStatusAtendimento.ResumeLayout(false);
            this.grStatusAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAtendimento)).EndInit();
            this.GrpAtendimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BiIniciar;
        private System.Windows.Forms.GroupBox grTratamento;
        private System.Windows.Forms.ComboBox cbPosicao;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTratamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLocalTratamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_local;
        private System.Windows.Forms.DataGridViewTextBoxColumn local;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStatusAtendimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid_atendimento_item;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grStatusAtendimento;
        private System.Windows.Forms.Button BtSalvarStatus;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.ComboBox CbStatusAtendimento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView tabelaAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tratamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronturario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_atendimento;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.Button BtSair;
        private System.Windows.Forms.GroupBox GrpAtendimentos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
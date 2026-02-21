namespace Gerador_de_documentos_net
{
    partial class GorcamentosForm
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
            label5 = new Label();
            txtBusca = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            lbProdutos = new ListBox();
            txtCPF = new TextBox();
            txtNome = new TextBox();
            txtCNPJ = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnCarregar = new Button();
            btnDEL = new Button();
            dataGridView1 = new DataGridView();
            lblID = new Label();
            lblID1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 3);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 7;
            label5.Text = "Busca";
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(5, 19);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(766, 23);
            txtBusca.TabIndex = 6;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCarregar, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDEL, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(792, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(578, 625);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblID1);
            groupBox1.Controls.Add(lbProdutos);
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtCNPJ);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 326);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 22);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 20;
            label6.Text = "Produtos do orçamento";
            // 
            // lbProdutos
            // 
            lbProdutos.FormattingEnabled = true;
            lbProdutos.ItemHeight = 15;
            lbProdutos.Location = new Point(227, 42);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(336, 199);
            lbProdutos.TabIndex = 19;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(6, 105);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(179, 23);
            txtCPF.TabIndex = 12;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(179, 23);
            txtNome.TabIndex = 11;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(6, 168);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(179, 23);
            txtCNPJ.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 14;
            label2.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 87);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 16;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 150);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 15;
            label3.Text = "CNPJ";
            // 
            // btnCarregar
            // 
            btnCarregar.Dock = DockStyle.Fill;
            btnCarregar.Location = new Point(3, 335);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(572, 84);
            btnCarregar.TabIndex = 23;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // btnDEL
            // 
            btnDEL.Dock = DockStyle.Fill;
            btnDEL.Location = new Point(3, 425);
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(572, 84);
            btnDEL.TabIndex = 25;
            btnDEL.Text = "Deletar";
            btnDEL.UseVisualStyleBackColor = true;
            btnDEL.Click += btnDEL_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(763, 580);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(27, 226);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 15);
            lblID.TabIndex = 31;
            // 
            // lblID1
            // 
            lblID1.AutoSize = true;
            lblID1.Location = new Point(6, 226);
            lblID1.Name = "lblID1";
            lblID1.Size = new Size(21, 15);
            lblID1.TabIndex = 30;
            lblID1.Text = "ID:";
            // 
            // GorcamentosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 625);
            Controls.Add(label5);
            Controls.Add(txtBusca);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "GorcamentosForm";
            Text = "FormGorcamentos";
            WindowState = FormWindowState.Maximized;
            Load += GorcamentosForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtBusca;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCarregar;
        private Button btnDEL;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtCPF;
        private TextBox txtNome;
        private TextBox txtCNPJ;
        private Label label2;
        private Label label4;
        private Label label3;
        private ListBox lbProdutos;
        private Label label6;
        private Label lblID;
        private Label lblID1;
    }
}
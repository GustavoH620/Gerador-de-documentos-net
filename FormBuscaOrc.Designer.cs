namespace Gerador_de_documentos_net
{
    partial class FormBuscaOrc
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
            btnSelecionar = new Button();
            txtBusca = new TextBox();
            lbProdutos = new ListBox();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtCNPJ = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(350, 487);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(500, 212);
            btnSelecionar.TabIndex = 6;
            btnSelecionar.Text = "Selecionar e continuar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Dock = DockStyle.Fill;
            txtBusca.Location = new Point(3, 3);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(1187, 23);
            txtBusca.TabIndex = 5;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // lbProdutos
            // 
            lbProdutos.FormattingEnabled = true;
            lbProdutos.ItemHeight = 15;
            lbProdutos.Location = new Point(6, 25);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(360, 199);
            lbProdutos.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(179, 23);
            txtNome.TabIndex = 11;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(6, 105);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(179, 23);
            txtCPF.TabIndex = 12;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 150);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 15;
            label3.Text = "CNPJ";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 22);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 18;
            label5.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(227, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(86, 23);
            txtID.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCNPJ);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(597, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 230);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do cliente";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 45);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1187, 192);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(txtBusca, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.5F));
            tableLayoutPanel1.Size = new Size(1193, 240);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel2.Location = new Point(8, 245);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1188, 236);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbProdutos);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(588, 230);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens do orçamento";
            // 
            // FormBuscaOrc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 749);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(btnSelecionar);
            Controls.Add(tableLayoutPanel1);
            Name = "FormBuscaOrc";
            Text = "Busca de Orçamentos";
            Load += FormBuscaOrc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSelecionar;
        private TextBox txtBusca;
        private ListBox lbProdutos;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtCNPJ;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
    }
}
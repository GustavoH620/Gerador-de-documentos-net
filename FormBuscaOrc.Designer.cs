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
            label1 = new Label();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtCNPJ = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(575, 441);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(154, 212);
            btnSelecionar.TabIndex = 6;
            btnSelecionar.Text = "Selecionar e continuar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(4, 12);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(784, 23);
            txtBusca.TabIndex = 5;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // lbProdutos
            // 
            lbProdutos.FormattingEnabled = true;
            lbProdutos.ItemHeight = 15;
            lbProdutos.Location = new Point(12, 287);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(523, 139);
            lbProdutos.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 265);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 10;
            label1.Text = "Itens do Orçamento";
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1154, 150);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            groupBox1.Location = new Point(12, 441);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 212);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do cliente";
            // 
            // FormBuscaOrc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 749);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(lbProdutos);
            Controls.Add(btnSelecionar);
            Controls.Add(txtBusca);
            Name = "FormBuscaOrc";
            Text = "FormBuscaOrc";
            Load += FormBuscaOrc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSelecionar;
        private TextBox txtBusca;
        private ListBox lbProdutos;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtCNPJ;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
    }
}
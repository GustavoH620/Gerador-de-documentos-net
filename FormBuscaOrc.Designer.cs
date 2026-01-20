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
            btnBuscar = new Button();
            btnSelecionar = new Button();
            txtBusca = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(4, 41);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(154, 31);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(634, 456);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(154, 31);
            btnSelecionar.TabIndex = 6;
            btnSelecionar.Text = "Selecionar e voltar";
            btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(4, 12);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(784, 23);
            txtBusca.TabIndex = 5;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(4, 325);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(559, 334);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(660, 78);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(523, 139);
            listBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(660, 56);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 10;
            label1.Text = "Itens do Orçamento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(660, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(660, 325);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(660, 388);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(660, 242);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 14;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(660, 370);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 15;
            label3.Text = "CNPJ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(660, 307);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 16;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(881, 242);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 18;
            label5.Text = "ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(881, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 23);
            textBox4.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(551, 150);
            dataGridView1.TabIndex = 19;
            // 
            // FormBuscaOrc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 749);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnSelecionar);
            Controls.Add(txtBusca);
            Name = "FormBuscaOrc";
            Text = "FormBuscaOrc";
            Load += FormBuscaOrc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnSelecionar;
        private TextBox txtBusca;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private DataGridView dataGridView1;
    }
}
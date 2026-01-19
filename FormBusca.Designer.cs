namespace Gerador_de_documentos_net
{
    partial class FormBusca
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
            txtBusca = new TextBox();
            lblTopico = new Label();
            btnSelecionar = new Button();
            btnBuscar = new Button();
            groupBox1 = new GroupBox();
            txtCNPJ = new TextBox();
            label14 = new Label();
            txtCEP = new TextBox();
            label13 = new Label();
            cbEstado = new ComboBox();
            label11 = new Label();
            txtCidade = new TextBox();
            label4 = new Label();
            txtBairro = new TextBox();
            label10 = new Label();
            txtRua = new TextBox();
            label9 = new Label();
            txtCPF = new TextBox();
            lblCPF = new Label();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            txtTelefone = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(6, 21);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(784, 23);
            txtBusca.TabIndex = 1;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // lblTopico
            // 
            lblTopico.AutoSize = true;
            lblTopico.Location = new Point(6, 3);
            lblTopico.Name = "lblTopico";
            lblTopico.Size = new Size(38, 15);
            lblTopico.TabIndex = 2;
            lblTopico.Text = "label1";
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(636, 465);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(154, 31);
            btnSelecionar.TabIndex = 3;
            btnSelecionar.Text = "Selecionar e voltar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(6, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(154, 31);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtCNPJ);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtCEP);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtRua);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(lblCPF);
            groupBox1.Controls.Add(txtNomeCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(6, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 338);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do cliente";
            groupBox1.Visible = false;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(272, 186);
            txtCNPJ.Margin = new Padding(4, 3, 4, 3);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(224, 23);
            txtCNPJ.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(272, 168);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 26;
            label14.Text = "CNPJ";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(272, 139);
            txtCEP.Margin = new Padding(4, 3, 4, 3);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(224, 23);
            txtCEP.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(272, 121);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 24;
            label13.Text = "CEP";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            cbEstado.Location = new Point(7, 287);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(224, 23);
            cbEstado.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 267);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 11;
            label11.Text = "Estado";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(7, 233);
            txtCidade.Margin = new Padding(4, 3, 4, 3);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(224, 23);
            txtCidade.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 9;
            label4.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(7, 180);
            txtBairro.Margin = new Padding(4, 3, 4, 3);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(224, 23);
            txtBairro.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 162);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 7;
            label10.Text = "Bairro";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(7, 132);
            txtRua.Margin = new Padding(4, 3, 4, 3);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(224, 23);
            txtRua.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 114);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 5;
            label9.Text = "Rua";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(7, 89);
            txtCPF.Margin = new Padding(4, 3, 4, 3);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(224, 23);
            txtCPF.TabIndex = 2;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(7, 71);
            lblCPF.Margin = new Padding(4, 0, 4, 0);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(7, 42);
            txtNomeCliente.Margin = new Padding(4, 3, 4, 3);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(224, 23);
            txtNomeCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do cliente";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(272, 42);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(224, 23);
            txtTelefone.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(272, 89);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 71);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // FormBusca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(groupBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnSelecionar);
            Controls.Add(lblTopico);
            Controls.Add(txtBusca);
            Name = "FormBusca";
            Text = "FormBusca";
            Load += FormBusca_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBusca;
        private Label lblTopico;
        private Button btnSelecionar;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private TextBox txtCNPJ;
        private Label label14;
        private TextBox txtCEP;
        private Label label13;
        private ComboBox cbEstado;
        private Label label11;
        private TextBox txtCidade;
        private Label label4;
        private TextBox txtBairro;
        private Label label10;
        private TextBox txtRua;
        private Label label9;
        private TextBox txtCPF;
        private Label lblCPF;
        private TextBox txtNomeCliente;
        private Label label1;
        private TextBox txtTelefone;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
    }
}
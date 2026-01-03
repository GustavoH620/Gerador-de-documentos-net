namespace Gerador_de_Documentos_net
{
    partial class Formconfig
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
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            lblCaminhoLogo = new Label();
            groupBox1 = new GroupBox();
            cbEstado = new ComboBox();
            label11 = new Label();
            txtCidade = new TextBox();
            label4 = new Label();
            txtBairro = new TextBox();
            label10 = new Label();
            txtRua = new TextBox();
            label9 = new Label();
            txtTelefone = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnSalvar = new Button();
            pbLogo = new PictureBox();
            label2 = new Label();
            txtNomeVendedor = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button1
            // 
            button1.Location = new Point(16, 110);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(261, 57);
            button1.TabIndex = 0;
            button1.Text = "Selecionar logo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCaminhoLogo
            // 
            lblCaminhoLogo.AutoSize = true;
            lblCaminhoLogo.BorderStyle = BorderStyle.FixedSingle;
            lblCaminhoLogo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaminhoLogo.Location = new Point(16, 170);
            lblCaminhoLogo.Margin = new Padding(4, 0, 4, 0);
            lblCaminhoLogo.Name = "lblCaminhoLogo";
            lblCaminhoLogo.Size = new Size(2, 17);
            lblCaminhoLogo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtRua);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(pbLogo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNomeVendedor);
            groupBox1.Controls.Add(lblCaminhoLogo);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 723);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações da Empresa / Vendedor";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            cbEstado.Location = new Point(16, 431);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(224, 23);
            cbEstado.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 411);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 37;
            label11.Text = "Estado";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(16, 377);
            txtCidade.Margin = new Padding(4, 3, 4, 3);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(224, 23);
            txtCidade.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 359);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 36;
            label4.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(16, 324);
            txtBairro.Margin = new Padding(4, 3, 4, 3);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(224, 23);
            txtBairro.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 306);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 34;
            label10.Text = "Bairro";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(16, 276);
            txtRua.Margin = new Padding(4, 3, 4, 3);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(224, 23);
            txtRua.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 258);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 31;
            label9.Text = "Rua";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(16, 484);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(224, 23);
            txtTelefone.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 466);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 26;
            label5.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(16, 538);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 520);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 30;
            label6.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(457, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 6;
            label1.Text = "Logo preview";
            label1.Click += label1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(16, 623);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(133, 57);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(554, 40);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(305, 210);
            pbLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 209);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome Empresa / Vendedor";
            // 
            // txtNomeVendedor
            // 
            txtNomeVendedor.Location = new Point(17, 227);
            txtNomeVendedor.Name = "txtNomeVendedor";
            txtNomeVendedor.Size = new Size(223, 23);
            txtNomeVendedor.TabIndex = 2;
            // 
            // Formconfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 749);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Formconfig";
            Text = "config";
            Load += config_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCaminhoLogo;
        private GroupBox groupBox1;
        private PictureBox pbLogo;
        private Label label2;
        private TextBox txtNomeVendedor;
        private Button btnSalvar;
        private Label label1;
        private ComboBox cbEstado;
        private Label label11;
        private TextBox txtCidade;
        private Label label4;
        private TextBox txtBairro;
        private Label label10;
        private TextBox txtRua;
        private Label label9;
        private TextBox txtTelefone;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
    }
}
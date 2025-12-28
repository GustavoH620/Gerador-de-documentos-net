namespace Gerador_de_Documentos_forms
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
            btnSalvar.Location = new Point(16, 559);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(133, 57);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(375, 40);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(540, 359);
            pbLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 22);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome Empresa / Vendedor";
            // 
            // txtNomeVendedor
            // 
            txtNomeVendedor.Location = new Point(16, 40);
            txtNomeVendedor.Name = "txtNomeVendedor";
            txtNomeVendedor.Size = new Size(261, 23);
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
    }
}
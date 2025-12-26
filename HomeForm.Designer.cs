namespace Gerador_de_Documentos_forms
{
    partial class HomeForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnConfig = new Button();
            lblEstagio = new Label();
            btnOrc = new Button();
            btnCom = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(btnConfig);
            panel1.Controls.Add(lblEstagio);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 898);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(36, 141);
            btnConfig.Margin = new Padding(4, 3, 4, 3);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(211, 54);
            btnConfig.TabIndex = 1;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // lblEstagio
            // 
            lblEstagio.AutoSize = true;
            lblEstagio.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstagio.Location = new Point(14, 22);
            lblEstagio.Margin = new Padding(4, 0, 4, 0);
            lblEstagio.Name = "lblEstagio";
            lblEstagio.Size = new Size(117, 42);
            lblEstagio.TabIndex = 0;
            lblEstagio.Text = "Home";
            // 
            // btnOrc
            // 
            btnOrc.Location = new Point(833, 121);
            btnOrc.Margin = new Padding(4, 3, 4, 3);
            btnOrc.Name = "btnOrc";
            btnOrc.Size = new Size(268, 323);
            btnOrc.TabIndex = 1;
            btnOrc.Text = "Orçamentos";
            btnOrc.UseVisualStyleBackColor = true;
            btnOrc.Click += btnOrc_Click;
            // 
            // btnCom
            // 
            btnCom.Location = new Point(479, 121);
            btnCom.Margin = new Padding(4, 3, 4, 3);
            btnCom.Name = "btnCom";
            btnCom.Size = new Size(268, 323);
            btnCom.TabIndex = 2;
            btnCom.Text = "Comunicado";
            btnCom.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(1168, 749);
            Controls.Add(btnCom);
            Controls.Add(btnOrc);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeForm";
            Text = "Form1";
            Load += HomeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEstagio;
        private System.Windows.Forms.Button btnOrc;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnConfig;
    }
}


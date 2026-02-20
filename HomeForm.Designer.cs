namespace Gerador_de_Documentos_net
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
            btnOrc = new Button();
            btnGer = new Button();
            btnConfig = new Button();
            lblEstagio = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(btnOrc);
            panel1.Controls.Add(btnGer);
            panel1.Controls.Add(btnConfig);
            panel1.Controls.Add(lblEstagio);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 1300);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnOrc
            // 
            btnOrc.FlatStyle = FlatStyle.System;
            btnOrc.Location = new Point(36, 201);
            btnOrc.Margin = new Padding(4, 3, 4, 3);
            btnOrc.Name = "btnOrc";
            btnOrc.Size = new Size(211, 78);
            btnOrc.TabIndex = 1;
            btnOrc.Text = "Orçamentos";
            btnOrc.UseVisualStyleBackColor = true;
            btnOrc.Click += btnOrc_Click;
            // 
            // btnGer
            // 
            btnGer.Location = new Point(36, 285);
            btnGer.Margin = new Padding(4, 3, 4, 3);
            btnGer.Name = "btnGer";
            btnGer.Size = new Size(211, 78);
            btnGer.TabIndex = 2;
            btnGer.Text = "Gerenciamento";
            btnGer.UseVisualStyleBackColor = true;
            btnGer.Click += btnGer_Click;
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(36, 117);
            btnConfig.Margin = new Padding(4, 3, 4, 3);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(211, 78);
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
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(1168, 560);
            Controls.Add(panel1);
            IsMdiContainer = true;
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
        private System.Windows.Forms.Button btnGer;
        private System.Windows.Forms.Button btnConfig;
    }
}


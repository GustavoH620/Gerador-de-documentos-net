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
            lbResultados = new ListBox();
            txtBusca = new TextBox();
            lblTopico = new Label();
            btnSelecionar = new Button();
            SuspendLayout();
            // 
            // lbResultados
            // 
            lbResultados.FormattingEnabled = true;
            lbResultados.ItemHeight = 15;
            lbResultados.Location = new Point(6, 50);
            lbResultados.Name = "lbResultados";
            lbResultados.Size = new Size(784, 349);
            lbResultados.TabIndex = 0;
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
            btnSelecionar.Location = new Point(637, 408);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(154, 31);
            btnSelecionar.TabIndex = 3;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // FormBusca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelecionar);
            Controls.Add(lblTopico);
            Controls.Add(txtBusca);
            Controls.Add(lbResultados);
            Name = "FormBusca";
            Text = "FormBusca";
            Load += FormBusca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbResultados;
        private TextBox txtBusca;
        private Label lblTopico;
        private Button btnSelecionar;
    }
}
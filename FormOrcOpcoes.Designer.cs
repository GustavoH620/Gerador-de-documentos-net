namespace Gerador_de_documentos_net
{
    partial class FormOrcOpcoes
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
            btnCarregar = new Button();
            btnNovoOrc = new Button();
            SuspendLayout();
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(225, 145);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(218, 333);
            btnCarregar.TabIndex = 0;
            btnCarregar.Text = "Carregar Orçamento";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // btnNovoOrc
            // 
            btnNovoOrc.Location = new Point(707, 145);
            btnNovoOrc.Name = "btnNovoOrc";
            btnNovoOrc.Size = new Size(218, 333);
            btnNovoOrc.TabIndex = 1;
            btnNovoOrc.Text = "Novo Orçamento";
            btnNovoOrc.UseVisualStyleBackColor = true;
            btnNovoOrc.Click += btnNovoOrc_Click;
            // 
            // FormOrcOpcoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 565);
            Controls.Add(btnNovoOrc);
            Controls.Add(btnCarregar);
            Name = "FormOrcOpcoes";
            Text = "FormOrcOpcoes";
            Load += FormOrcOpcoes_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCarregar;
        private Button btnNovoOrc;
    }
}
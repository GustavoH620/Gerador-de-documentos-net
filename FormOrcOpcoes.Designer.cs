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
            btnCarregar.Location = new Point(137, 145);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(108, 81);
            btnCarregar.TabIndex = 0;
            btnCarregar.Text = "Carregar Orçamento";
            btnCarregar.UseVisualStyleBackColor = true;
            // 
            // btnNovoOrc
            // 
            btnNovoOrc.Location = new Point(361, 145);
            btnNovoOrc.Name = "btnNovoOrc";
            btnNovoOrc.Size = new Size(108, 81);
            btnNovoOrc.TabIndex = 1;
            btnNovoOrc.Text = "Novo Orçamento";
            btnNovoOrc.UseVisualStyleBackColor = true;
            btnNovoOrc.Click += btnNovoOrc_Click;
            // 
            // FormOrcOpcoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNovoOrc);
            Controls.Add(btnCarregar);
            Name = "FormOrcOpcoes";
            Text = "FormOrcOpcoes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCarregar;
        private Button btnNovoOrc;
    }
}
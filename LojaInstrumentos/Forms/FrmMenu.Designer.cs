namespace LojaInstrumentos
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnVenda = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 40);
            label1.Name = "label1";
            label1.Size = new Size(291, 32);
            label1.TabIndex = 0;
            label1.Text = "Instrumentos do Bigode";
            label1.Click += label1_Click;
            // 
            // btnVenda
            // 
            btnVenda.Location = new Point(240, 152);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(291, 23);
            btnVenda.TabIndex = 1;
            btnVenda.Text = "Venda de instrumentos";
            btnVenda.UseVisualStyleBackColor = true;
            btnVenda.Click += button1_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(240, 192);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(291, 23);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Relatório de Vendas";
            btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(348, 343);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(btnVenda);
            Controls.Add(label1);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loja de Instrumentos - Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVenda;
        private Button btnRelatorio;
        private Button btnSair;
    }
}

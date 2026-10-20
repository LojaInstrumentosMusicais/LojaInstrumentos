namespace LojaInstrumentos.Forms
{
    partial class FrmVenda
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
            btnRegistrar = new Button();
            btnRelatorio = new Button();
            lblInstrumento = new Label();
            lblTotal = new Label();
            cmbInstrumento = new ComboBox();
            txtPreco = new TextBox();
            nudQuantidade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(212, 309);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(155, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar venda";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(416, 309);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(155, 23);
            btnRelatorio.TabIndex = 1;
            btnRelatorio.Text = "Consultar vendas";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // lblInstrumento
            // 
            lblInstrumento.AutoSize = true;
            lblInstrumento.Location = new Point(162, 72);
            lblInstrumento.Name = "lblInstrumento";
            lblInstrumento.Size = new Size(72, 15);
            lblInstrumento.TabIndex = 2;
            lblInstrumento.Text = "Instrumento";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(227, 269);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(76, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: R$ 0,00";
            // 
            // cmbInstrumento
            // 
            cmbInstrumento.FormattingEnabled = true;
            cmbInstrumento.Location = new Point(162, 114);
            cmbInstrumento.Name = "cmbInstrumento";
            cmbInstrumento.Size = new Size(205, 23);
            cmbInstrumento.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(414, 202);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(157, 23);
            txtPreco.TabIndex = 5;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(162, 202);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(175, 23);
            nudQuantidade.TabIndex = 6;
            nudQuantidade.ValueChanged += nudQuantidade_ValueChanged;
            // 
            // FrmVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(cmbInstrumento);
            Controls.Add(lblTotal);
            Controls.Add(lblInstrumento);
            Controls.Add(btnRelatorio);
            Controls.Add(btnRegistrar);
            Name = "FrmVenda";
            Text = "FrmVenda";
            Load += FrmVenda_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnRelatorio;
        private Label lblInstrumento;
        private Label lblTotal;
        private ComboBox cmbInstrumento;
        private TextBox txtPreco;
        private NumericUpDown nudQuantidade;
    }
}
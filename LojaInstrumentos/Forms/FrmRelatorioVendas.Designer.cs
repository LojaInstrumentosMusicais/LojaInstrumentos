namespace LojaInstrumentos.Forms
{
    partial class FrmRelatorioVendas
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
            dgvVendas = new DataGridView();
            btnAtualizar = new Button();
            btnVoltar = new Button();
            lblTotalVendas = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            SuspendLayout();
            // 
            // dgvVendas
            // 
            dgvVendas.AllowUserToAddRows = false;
            dgvVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendas.Location = new Point(93, 12);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.ReadOnly = true;
            dgvVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendas.Size = new Size(620, 150);
            dgvVendas.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(345, 258);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(197, 258);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Location = new Point(494, 262);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(132, 15);
            lblTotalVendas.TabIndex = 3;
            lblTotalVendas.Text = "Total de vendas: R$ 0,00";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(312, 188);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(110, 15);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Relatório de Vendas";
            // 
            // FrmRelatorioVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblTotalVendas);
            Controls.Add(btnVoltar);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvVendas);
            Name = "FrmRelatorioVendas";
            Text = "FrmRelatorioVendas";
            Load += FrmRelatorioVendas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVendas;
        private Button btnAtualizar;
        private Button btnVoltar;
        private Label lblTotalVendas;
        private Label lblTitulo;
    }
}
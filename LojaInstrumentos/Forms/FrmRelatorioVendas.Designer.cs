
namespace LojaInstrumentos.Form
{
    partial class FrmRelatorioVendas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new System.Windows.Forms.Label();
            dgvVendas = new System.Windows.Forms.DataGridView();
            lblTotalVendas = new System.Windows.Forms.Label();
            btnAtualizar = new System.Windows.Forms.Button();
            btnVoltar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(215, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Relatório de Vendas";

            // dgvVendas
            dgvVendas.AllowUserToAddRows = false;
            dgvVendas.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendas.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendas.Location = new System.Drawing.Point(25, 70);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.ReadOnly = true;
            dgvVendas.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvVendas.Size = new System.Drawing.Size(830, 320);
            dgvVendas.TabIndex = 1;

            // lblTotalVendas
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblTotalVendas.Location = new System.Drawing.Point(25, 410);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new System.Drawing.Size(185, 20);
            lblTotalVendas.TabIndex = 2;
            lblTotalVendas.Text = "Total de vendas: R$ 0,00";

            // btnAtualizar
            btnAtualizar.Location = new System.Drawing.Point(600, 410);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new System.Drawing.Size(120, 35);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;

            // btnVoltar
            btnVoltar.Location = new System.Drawing.Point(735, 410);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new System.Drawing.Size(120, 35);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;

            // FrmRelatorioVendas
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 471);
            Controls.Add(lblTitulo);
            Controls.Add(dgvVendas);
            Controls.Add(lblTotalVendas);
            Controls.Add(btnAtualizar);
            Controls.Add(btnVoltar);
            Name = "FrmRelatorioVendas";
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sonora | Relatório de Vendas";
            Load += FrmRelatorioVendas_Load;

            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnVoltar;
    }
}

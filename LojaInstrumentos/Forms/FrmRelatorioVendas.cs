
using System;
using System.Globalization;
using System.Windows.Forms;
using LojaInstrumentos.Models;

namespace LojaInstrumentos.Form
{
    public partial class FrmRelatorioVendas : System.Windows.Forms.Form
    {
        public FrmRelatorioVendas()
        {
            InitializeComponent();
            ConfigurarTabela();
        }

        private void FrmRelatorioVendas_Load(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void ConfigurarTabela()
        {
            dgvVendas.AutoGenerateColumns = true;
            dgvVendas.ReadOnly = true;
            dgvVendas.AllowUserToAddRows = false;
            dgvVendas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvVendas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CarregarVendas()
        {
            dgvVendas.DataSource = null;
            dgvVendas.DataSource = RepositorioVendas.Vendas;

            if (dgvVendas.Columns["Id"] != null)
                dgvVendas.Columns["Id"].HeaderText = "Código";

            if (dgvVendas.Columns["Data"] != null)
            {
                dgvVendas.Columns["Data"].HeaderText = "Data da venda";
                dgvVendas.Columns["Data"].DefaultCellStyle.Format =
                    "dd/MM/yyyy HH:mm";
            }

            if (dgvVendas.Columns["Instrumento"] != null)
                dgvVendas.Columns["Instrumento"].HeaderText = "Instrumento";

            if (dgvVendas.Columns["Quantidade"] != null)
                dgvVendas.Columns["Quantidade"].HeaderText = "Quantidade";

            if (dgvVendas.Columns["PrecoUnitario"] != null)
            {
                dgvVendas.Columns["PrecoUnitario"].HeaderText =
                    "Preço unitário";
                dgvVendas.Columns["PrecoUnitario"].DefaultCellStyle.Format =
                    "C2";
                dgvVendas.Columns["PrecoUnitario"]
                    .DefaultCellStyle.FormatProvider =
                    CultureInfo.GetCultureInfo("pt-BR");
            }

            if (dgvVendas.Columns["Total"] != null)
            {
                dgvVendas.Columns["Total"].HeaderText = "Total";
                dgvVendas.Columns["Total"].DefaultCellStyle.Format = "C2";
                dgvVendas.Columns["Total"].DefaultCellStyle.FormatProvider =
                    CultureInfo.GetCultureInfo("pt-BR");
            }

            decimal totalVendido = 0;

            foreach (var venda in RepositorioVendas.Vendas)
                totalVendido += venda.Total;

            lblTotalVendas.Text = "Total de vendas: " +
                totalVendido.ToString(
                    "C2",
                    CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

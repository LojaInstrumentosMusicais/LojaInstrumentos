
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace LojaInstrumentos.Form
{
    public partial class FrmVenda : System.Windows.Forms.Form
    {
        private readonly Dictionary<string, decimal> _instrumentos = new()
        {
            { "Violão", 599.90m },
            { "Guitarra", 1299.90m },
            { "Teclado", 899.90m },
            { "Bateria", 2499.90m },
            { "Baixo", 1199.90m }
        };

        public FrmVenda()
        {
            InitializeComponent();

            ConfigurarInstrumentos();

            cmbInstrumento.SelectedIndexChanged +=
                cmbInstrumento_SelectedIndexChanged;
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void ConfigurarInstrumentos()
        {
            cmbInstrumento.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbInstrumento.Items.Clear();

            foreach (string instrumento in _instrumentos.Keys)
            {
                cmbInstrumento.Items.Add(instrumento);
            }

            cmbInstrumento.SelectedIndex = -1;

            nudQuantidade.Minimum = 1;
            nudQuantidade.Maximum = 100;
            nudQuantidade.Value = 1;

            txtPreco.ReadOnly = true;
            txtPreco.Text = "R$ 0,00";

            lblTotal.Text = "Total: R$ 0,00";
        }

        private void cmbInstrumento_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void nudQuantidade_ValueChanged(
            object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            if (cmbInstrumento.SelectedItem == null)
            {
                txtPreco.Text = "R$ 0,00";
                lblTotal.Text = "Total: R$ 0,00";
                return;
            }

            string instrumento =
                cmbInstrumento.SelectedItem.ToString()!;

            decimal preco = _instrumentos[instrumento];
            int quantidade = (int)nudQuantidade.Value;
            decimal total = preco * quantidade;

            txtPreco.Text = preco.ToString(
                "C2", CultureInfo.GetCultureInfo("pt-BR"));

            lblTotal.Text = "Total: " + total.ToString(
                "C2", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "A tela de relatório será integrada na próxima etapa.",
                "Sonora",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

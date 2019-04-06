using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle
{
    public partial class Form1 : Form
    {
        Double TotalUn;

        public Form1()
        {
            InitializeComponent();
            IniciaValores();
        }

        private void IniciaValores()
        {
            txtPesoTotalFumo.Text = "0";
            txtValorTotalFumo.Text = "0";

            txtValorTotalPalha.Text = "0";
            txtQtdTotalPalha.Text = "0";

            txtValorTotalEmbalagem.Text = "0";
            txtQtdTotalEmbalagem.Text = "0";

            cboFornecedorEmbalagem.SelectedIndex = -1;
            cboFornecedorFumo.SelectedIndex = -1;
            cboFornecedorPallha.SelectedIndex = -1;
        }

        private void txtPesoFumo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPesoTotalFumo.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtValorTotalFumo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValorTotalFumo.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtPesoUnFumo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPesoUnFumo.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtValorUnFumo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValorUnFumo.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtQtdTotalPalha_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtQtdTotalPalha.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtValorTotalPalha_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValorTotalPalha.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtQtdUnPalha_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtQtdUnPalha.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtValorUnPalha_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValorUnPalha.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtQtdTotalEmbalagem_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtQtdTotalEmbalagem.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtValorTotalEmbalagem_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValorTotalEmbalagem.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtQtdUnEmbalagem_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtQtdUnEmbalagem.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void txtValorUnEmbalagem_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValorUnEmbalagem.Text)) txtPesoTotalFumo.Text = "0,0";
        }

        private void CalculaValores()
        {
            TotalUn = 0;

            Double VrTotal, QtdTotal;
            // Fumo

            VrTotal = Convert.ToDouble(txtValorTotalFumo.Text);
            QtdTotal = Convert.ToDouble(txtPesoTotalFumo.Text);

            TotalUn = VrTotal * 1000 / QtdTotal;

            // Palha

            VrTotal = Convert.ToDouble(txtValorTotalPalha.Text);
            QtdTotal = Convert.ToDouble(txtQtdTotalPalha.Text);

            TotalUn += VrTotal / QtdTotal;

            // Embalagem

            VrTotal = Convert.ToDouble(txtValorTotalEmbalagem.Text);
            QtdTotal = Convert.ToDouble(txtQtdTotalEmbalagem.Text);

            TotalUn += VrTotal / QtdTotal;

            lblTotalUn.Text = TotalUn.ToString("N2");
        }

        private void CalculaGeral(Int32 Unidade)
        {
            lblTotal.Text = (TotalUn * Unidade).ToString("N2");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalculaGeral(Convert.ToInt32(num.Value));
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46
                                         && e.KeyChar != 8)
                    e.Handled = true;
        }
    }
}

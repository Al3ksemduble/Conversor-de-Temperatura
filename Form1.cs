using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Temperatura
{
    public partial class FrmTemp : Form
    {
        public FrmTemp()
        {
            InitializeComponent();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTemp.Text))
            {
                MessageBox.Show("Por favor, digite uma temperatura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTemp.Text, out decimal temperatura))
            {
                MessageBox.Show("Por favor, digite uma temperatura válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbCel.Checked)
            {
                decimal tempCelsius = (temperatura - 32) * 5 / 9;
                lblResult.Text = ($"A temperatura de Fahrenheit para Celsius é {tempCelsius:F2} °C");
            }
            else if (rbFahr.Checked)
            {
                decimal tempFahrenheit = (temperatura * 9 / 5) + 32;
                lblResult.Text = ($"A temperatura De Celsius para Fahrenheit é {tempFahrenheit:F2} °F");
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma unidade de temperatura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTemp.Clear();
        }
    }
}

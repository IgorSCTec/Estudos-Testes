using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho
{
    public partial class lblValor : Form
    {
        public lblValor()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double valor1 = 0;
            double valor2 = 0;
            double valor3 = 0;
            double valor4 = 0;
            double valor5 = 0;
            double valor6 = 0;
            double valor7 = 0;

            if (chbRapadura.Checked == false && chbInhame.Checked == false && chbCupuacu.Checked == false && chbSandalias.Checked == false && chbBolacha.Checked == false && chbSabao.Checked == false && chbPinico.Checked == false)
            {
                MessageBox.Show("Selecione algum item e digite a quantidade");
            }
            if (chbRapadura.Checked)
            {
                valor1 = 1.50 * int.Parse(txtRapadura.Text);
            }
            if (chbInhame.Checked)
            {
                valor2 = 3.00 * int.Parse(txtInhame.Text);
            }
            if (chbCupuacu.Checked)
            {
                valor3 = 1.10 * int.Parse(txtCupuacu.Text);
            }
            if (chbSandalias.Checked)
            {
                valor4 = 12.35 * int.Parse(txtSandalias.Text);
            }
            if (chbBolacha.Checked)
            {
                valor5 = 1.85 * int.Parse(txtBolacha.Text);
            }
            if (chbSabao.Checked)
            {
                valor6 = 0.80 * int.Parse(txtSabao.Text);
            }
            if (chbPinico.Checked)
            {
                valor7 = 11.17 * int.Parse(txtPinico.Text);
            }

            double resultado = valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7;
            lblResultado.Text = "Total a pagar: " + resultado;

        }
    }
}

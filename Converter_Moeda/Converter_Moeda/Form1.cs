using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_Moeda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            double cotacao = double.Parse(txtCotacao.Text);

            if(rdbMReal.Checked == true && rdbCDolar.Checked == true)
            {
                double resultado = valor / cotacao;
                MessageBox.Show("Valor em Dolar: " + resultado);
            }

            if (rdbMDolar.Checked == true && rdbCReal.Checked == true)
            {
                double resultado = valor * cotacao;
                MessageBox.Show("Valor em Real: " + resultado);
            }

            if(rdbMReal.Checked == true && rdbCReal.Checked == true)
            {
                MessageBox.Show("O valor inserido já está em Real");
            }

            if(rdbMDolar.Checked == true && rdbCDolar.Checked == true)
            {
                MessageBox.Show("O valor inserido já está em Dolar");
            }
        }
    }
}

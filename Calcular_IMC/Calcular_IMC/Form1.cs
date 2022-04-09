using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double imc = double.Parse(txtPeso.Text) / (double.Parse(txtAltura.Text) * double.Parse(txtAltura.Text));

            if (imc < 17)
                pictureIMC.Load("PictureBox/MuitoAbaixo.png");

            if (imc >= 17 && imc <= 18.49)
                pictureIMC.Load("PictureBox/Abaixo.png");

            if (imc >= 18.50 && imc <= 24.99)
                pictureIMC.Load("PictureBox/Normal.png");

            if (imc >= 25 && imc <= 29.99)
                pictureIMC.Load("PictureBox/Sobrepeso.png");

            if (imc >= 30 && imc <= 34.99)
                pictureIMC.Load("PictureBox/Obesidade1.png");

            if (imc >= 35 && imc <= 39.99)
                pictureIMC.Load("PictureBox/Obesidade2.png");

            if (imc > 40)
                pictureIMC.Load("PictureBox/Obesidade3.png");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbSexo.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            pictureIMC.Load("PictureBox/IMC.png");
        }
    }
}

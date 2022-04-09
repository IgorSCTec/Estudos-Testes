using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AumentodeSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(cbCargo.Text == "Gerente")
            {
                if (txtSalario.Text == "" || txtNome.Text == "")
                {
                    MessageBox.Show("Preencha todas as informações");
                }
                else
                {
                    var salarioAntigo = double.Parse(txtSalario.Text);
                    double aumento = double.Parse(txtSalario.Text) * 0.05;
                    rtbResultado.Text = $"Nome: {txtNome.Text}\nCargo: {cbCargo.Text}\nSalário: {salarioAntigo}\nAumento: 5%\nTotal: {(salarioAntigo + aumento)}\n_____________________________";
                }
            }
            if (cbCargo.Text == "Técnico")
            {
                if (txtSalario.Text == "" || txtNome.Text == "")
                {
                    MessageBox.Show("Preencha todas as informações");
                }
                else
                {
                    var salarioAntigo = double.Parse(txtSalario.Text);
                    double aumento = double.Parse(txtSalario.Text) * 0.075;
                    rtbResultado.Text = $"Nome: {txtNome.Text}\nCargo: {cbCargo.Text}\nSalário: {salarioAntigo}\nAumento: 7,5%\nTotal: {(salarioAntigo + aumento)}\n_____________________________";
                }
            }
            if (cbCargo.Text == "Auxiliar")
            {
                if (txtSalario.Text == "" || txtNome.Text == "")
                {
                    MessageBox.Show("Preencha todas as informações");
                }
                else
                {
                    var salarioAntigo = double.Parse(txtSalario.Text);
                    double aumento = double.Parse(txtSalario.Text) * 0.10;
                    rtbResultado.Text = $"Nome: {txtNome.Text}\nCargo: {cbCargo.Text}\nSalário: {salarioAntigo}\nAumento: 10%\nTotal: {(salarioAntigo + aumento)}\n_____________________________";
                }
            }
            if (cbCargo.Text == "Outros")
            {
                if (txtSalario.Text == "" || txtNome.Text == "")
                {
                    MessageBox.Show("Preencha todas as informações");
                }
                else
                {
                    var salarioAntigo = double.Parse(txtSalario.Text);
                    double aumento = double.Parse(txtSalario.Text) * 0.04;
                    rtbResultado.Text = $"Nome: {txtNome.Text}\nCargo: {cbCargo.Text}\nSalário: {salarioAntigo}\nAumento: 4%\nTotal: {(salarioAntigo + aumento)}\n_____________________________";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbCargo.Text = "";
            txtNome.Text = "";
            txtSalario.Text = "";
            rtbResultado.Text = "";
        }
    }
}

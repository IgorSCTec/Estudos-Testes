using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotulo_CPF_CNPJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Física")
            {
                lblCNPJ.Visible = false;
                lblCPF.Visible = true;
                txtDocumento.Visible = true;
            }
            else
            {
                lblCPF.Visible = false;
                lblCNPJ.Visible = true;
                txtDocumento.Visible = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaTP_Senhor_Senhora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            if(rdbMasculino.Checked)
            {
                lblMasculino.Visible = true;
                lblMasculino.Text = ("Seja bem vindo Senhor " + textBox1.Text);
            }

            if (rdbFeminino.Checked)
            {
                lblFeminino.Visible = true;
                lblFeminino.Text = ("Seja bem vindo Senhora " + textBox1.Text);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaForms
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double notaPre = double.Parse( txtPre.Text);
            double notaProva = double.Parse( txtProva.Text);
            double notaFinal = notaPre * 0.05 + notaProva * 0.25;
            lblResp.Text = $"Olá {txtNome.Text} sua nota é: {notaFinal}";

        }
    }
}

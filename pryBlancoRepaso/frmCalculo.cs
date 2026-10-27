using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryBlancoRepaso
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {
            int monto;
            monto =int.Parse(txtmonto.Text);
            float resultado;
            resultado = monto * 0.10f;
            resultado = monto * 0.21f;
            
            MessageBox.Show("El resultado es: " + resultado);
        }
    }
}

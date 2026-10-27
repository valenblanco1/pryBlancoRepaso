using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryBlancoRepaso
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            int codigo;
            string nombre;
            codigo = Convert.ToInt32(txtcodigo.Text);

            nombre = txtnombre.Text;
            codigo = int.Parse(txtcodigo.Text);

            MessageBox.Show("Codigo: " + codigo + " Nombre: " + nombre);
        }
    }
}

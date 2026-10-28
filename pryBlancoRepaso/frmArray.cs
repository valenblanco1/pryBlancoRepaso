using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryBlancoRepaso
{
    public partial class frmArray : Form
    {
        string[] VectorGrupoA = new string[4];
        string[] VectorGrupoB = new string[3];
        string[] VectorGrupoC = new string[3];
        public frmArray()
        {
            InitializeComponent();
        }

        private void cmoGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboGrupo.Text)
            {
                case "Grupo A":
                    lstResultado.Items.Clear();
                    //lstResultado.Items.Add("CPU");
                    //lstResultado.Items.Add("Micro");
                    //lstResultado.Items.Add("Placa");
                    //lstResultado.Items.Add("Memoria");



                    for (int i = 0; i < VectorGrupoA.Length; i++)
                    {
                        lstResultado.Items.Add(VectorGrupoA[i]);


                    }
                    break;
                case "Grupo B":
                    lstResultado.Items.Clear();
                    //lstResultado.Items.Add("Visual");
                    //lstResultado.Items.Add("C#");
                    //lstResultado.Items.Add("Desktop");


                    for (int i = 0; i < VectorGrupoB.Length; i++)
                    {
                        lstResultado.Items.Add(VectorGrupoB[i]);


                    }
                    break;
                case "Grupo C":
                    lstResultado.Items.Clear();
                    //lstResultado.Items.Add("Server");
                    //lstResultado.Items.Add("AWS");
                    //lstResultado.Items.Add("Cloud");


                    for (int i = 0; i < VectorGrupoC.Length; i++)


                    {
                        lstResultado.Items.Add(VectorGrupoC[i]);
                    }
                    break;
                default:
                    break;
            }

        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            cboGrupo.Items.Add("Grupo A");
            cboGrupo.Items.Add("Grupo B");
            cboGrupo.Items.Add("Grupo C");

            cboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;

            VectorGrupoA[0] = "CPU";
            VectorGrupoA[1] = "Micro";
            VectorGrupoA[2] = "Placa";
            VectorGrupoA[3] = "Memoria";

            VectorGrupoB[0] = "Visual";
            VectorGrupoB[1] = "C#";
            VectorGrupoB[2] = "Desktop";

            VectorGrupoC[0] = "Server";
            VectorGrupoC[1] = "AWS";
            VectorGrupoC[2] = "Cloud";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height = 400;
        }
        int indiceGrabar = 0;
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (cboGrabar.Text)

            {
                case "Grupo A":
                    VectorGrupoA[indiceGrabar] = txtGrabar.Text;
                    indiceGrabar++;
                    lblMensaje.Text = "Almacenado..." + txtGrabar.Text;
                    txtGrabar.Text = "";
                    break;
                case "Grupo B":
                    VectorGrupoB[indiceGrabar] = txtGrabar.Text;
                    indiceGrabar++;
                    lblMensaje.Text = "Almacenado..." + txtGrabar.Text;
                    txtGrabar.Text = "";
                    break;
                case "Grupo C":
                    VectorGrupoC[indiceGrabar] = txtGrabar.Text;
                    indiceGrabar++;
                    lblMensaje.Text = "Almacenado..." + txtGrabar.Text;
                    txtGrabar.Text = "";
                    break;

            }
        }

        private void cboGrabar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGrupo.Items.Add("Grupo A");
            cboGrupo.Items.Add("Grupo B");
            cboGrupo.Items.Add("Grupo C");
        }
    }
}

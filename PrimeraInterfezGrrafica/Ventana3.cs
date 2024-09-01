using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraInterfezGrrafica
{
    public partial class Ventana3 : Form
    {
        public Ventana3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string texto;
            texto = txtbxTrabajo.Text; 
            lstvwMuestraDatos.Items.Add(texto);
            texto = dtFechaIngreso.Text;
            lstvwMuestraDatos.Items.Add(texto);
            texto = numAntig.Text;
            lstvwMuestraDatos.Items.Add(texto);
            texto = txtbxLugarTrabajo.Text;
            lstvwMuestraDatos.Items.Add(texto);
        }

        private void MuestraDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstvwMuestraDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}

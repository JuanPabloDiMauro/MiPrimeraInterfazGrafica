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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormVentana2_Load(object sender, EventArgs e)
        {

        }

        private void MsPerfil_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya hay un perfil abierto, cierrelo para abrir uno nuevo");
                    return;
                }
            }

            Form1 ventana = new Form1();    
            ventana.MdiParent = this;
            ventana.Show();
            
        }
    }
}

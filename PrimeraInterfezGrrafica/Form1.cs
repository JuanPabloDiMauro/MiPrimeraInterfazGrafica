using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraInterfezGrrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto;
            texto = "Nombre: " + TextBoxNameUser.Text + ", Fecha de nacimiento: " + dateTimeFechaNac.Text;
            if(CheckBoxMascota1.Checked == true || CheckBoxMascota2.Checked == true || checkBoxMascota3.Checked == true) 
            {
                texto += ", mascotas:";
                if (CheckBoxMascota1.Checked == true) texto += " " + CheckBoxMascota1.Text;
                if (CheckBoxMascota2.Checked == true) texto += " " + CheckBoxMascota2.Text;
                if (checkBoxMascota3.Checked == true) texto += " " + checkBoxMascota3.Text;
                texto += ", tiene " + numericUpDownCantMascotas.Value + " mascotas";
            }
            texto += ", Estado Civil: ";
            if (rbtEstadoCivil1.Checked == true)
            {
                texto += rbtEstadoCivil1.Text;
            }
            else
            {
                if(rbtEstadoCivil2.Checked == true)
                {
                    texto += rbtEstadoCivil2.Text;
                }
                else
                {
                    texto += rbtEstadoCivil3.Text;
                }
            }

            MessageBox.Show(texto);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void lblIngrTrabajo_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mascotas(object sender, EventArgs e)
        {

        }

        private void TextBoxNameUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void SubMenuPerfil_Click(object sender, EventArgs e)
        {
            
        }
    }
}

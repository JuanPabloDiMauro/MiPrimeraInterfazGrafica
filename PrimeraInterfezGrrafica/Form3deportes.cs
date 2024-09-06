using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrimeraInterfezGrrafica
{
    public partial class Form3deportes : Form
    {
        public Form3deportes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form3deportes_Load(object sender, EventArgs e)
        {
            ParticipantesNegocio participantesNegocio = new ParticipantesNegocio();
            dgvPartNegocio.DataSource = participantesNegocio.Listar();
        }
    }
}

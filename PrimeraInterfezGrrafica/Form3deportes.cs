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

        private List<Participantes> listaParticipantes;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form3deportes_Load(object sender, EventArgs e)
        {
            ParticipantesNegocio participantesNegocio = new ParticipantesNegocio();
            listaParticipantes = participantesNegocio.Listar();
            dgvPartNegocio.DataSource = listaParticipantes;
            dgvPartNegocio.Columns["UrlImagen"].Visible = false;
            PbParticipantes.Load(listaParticipantes[0].UrlImagen);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPartNegocio_SelectionChanged(object sender, EventArgs e)
        {
            Participantes participantes = (Participantes)dgvPartNegocio.CurrentRow.DataBoundItem;
            CargarImagen(participantes.UrlImagen);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                PbParticipantes.Load(imagen);

            }
            catch (Exception ex)
            {

                PbParticipantes.Load("https://www.seekpng.com/png/detail/966-9665317_placeholder-image-person-jpg.png");
            }
        }
    }
}

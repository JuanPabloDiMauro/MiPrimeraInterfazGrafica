using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PrimeraInterfezGrrafica
{
    class ParticipantesNegocio
    {
        public List<Participantes> Listar() { 
            
            List<Participantes> lista = new List<Participantes>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando =new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=DESKTOP-9O798KJ\\SQLEXPRESS02; database=POKEDEX_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select nombre, P.descripcion, UrlImagen, E.Descripcion tipo, D.Descripcion debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdDebilidad and D.Id = P.IdDebilidad ";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Participantes participantes = new Participantes();
                    participantes.nombre = (string)lector["nombre"];
                    participantes.descripcion = (string)lector["descripcion"];
                    participantes.UrlImagen = (string)lector["UrlImagen"];
                    participantes.tipo = new elemento();
                    participantes.tipo.descripcion = (string)lector["descripcion"];
                    participantes.debilidad = new elemento();
                    participantes.debilidad.descripcion = (string)lector["debilidad"];

                    //participantes.FechaNacimiento = (DateTime)lector["Fecha de nacimiento"];

                    lista.Add(participantes);  
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }  
    }
}

using ServiciosEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GestorBD
    {
        static SqlConnection CO = new SqlConnection("Data Source=.;Initial Catalog=BaseProyecto;Integrated Security=True;MultipleActiveResultSets=True;");
        private static GestorBD instancia;
        public static GestorBD Instancia
        {
            get
            {
                if (instancia == null) instancia = new GestorBD();
                return instancia;
            }
        }
        public void AbrirConexion()
        {
            CO.ConnectionString = "Data Source=.;Initial Catalog=BaseProyecto;Integrated Security=True;MultipleActiveResultSets=True;";
            CO.Open();
        }
        public void CerrarConexion()
        {
            CO.Close();
        }
        public SqlConnection ReturnConexion()
        {
            return CO;
        }
        public bool ValidarUsuario(string Email, string Contra)
        {
            bool x = false;
            string query = $"SELECT * FROM Usuario WHERE Email = @Email AND Contrasenia = @Contrasenia";
            using (SqlCommand CM = new SqlCommand(query, CO))
            {
                CM.Parameters.AddWithValue("@Email", Email);
                CM.Parameters.AddWithValue("@Contrasenia", Contra);
                this.AbrirConexion();
                using (SqlDataReader DR = CM.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        if (DR != null)
                        {
                            x = true;
                            break;
                        }
                    }
                }
            }
            this.CerrarConexion();
            return x;
        }
        public Usuario ObtenerUsuario(string Email)
        {
            Usuario U = null;
            string Query = $"SELECT * FROM Usuario WHERE Email = @Email";
            using (SqlCommand CM = new SqlCommand(Query, CO))
            {
                this.AbrirConexion();
                CM.Parameters.AddWithValue("@Email", Email);
                using (SqlDataReader DR = CM.ExecuteReader())
                {
                    if (DR.Read())
                    {
                        U = new Usuario();
                        U.DNI = int.Parse(DR[0].ToString());
                        U.Nombre = DR[1].ToString();
                        U.Apellido = DR[2].ToString();
                        U.Email = DR[3].ToString();
                        U.Contraseña = DR[4].ToString();
                        U.Tipo = DR[5].ToString();
                        U.IsHabilitado = Convert.ToBoolean(DR[6].ToString());
                        U.Estado = Convert.ToBoolean(DR[7].ToString());
                        U.Intentos = int.Parse(DR[8].ToString());
                        U.cambioContrasenia = Convert.ToBoolean(DR[9].ToString());
                        U.ultimoLogin = Convert.ToDateTime(DR[10].ToString());
                    }
                }
            }
            this.CerrarConexion();
            return U;
        }
    }
}

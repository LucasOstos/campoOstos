using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiciosEntidades;

namespace DAL
{
    public class PermisosBD
    {
        private static PermisosBD instance;
        public static PermisosBD Instancia
        {
            get
            {
                if (instance == null)
                {
                    instance = new PermisosBD();
                }
                return instance;
            }
        }
        public List<Permiso> ObtenerPermisos()
        {
            List<Permiso> permisos = new List<Permiso>();
            string query = "SELECT * FROM Permiso";

            using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Permiso permiso = new PermisoSimple(int.Parse(dr["Cod_Permiso"].ToString()), dr["Nombre_Permiso"].ToString());
                        permisos.Add(permiso);
                    }
                }
                GestorBD.Instancia.CerrarConexion();
            }
            return permisos;
        }
        /*public void ExistenciaPermiso(string nombrePermiso)
        {
            string query = $"SELECT * FROM Permiso WHERE NombrePermiso = '{nombrePermiso}'";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader DR = CM.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        GestorBD.Instancia.CerrarConexion();
                        if (DR != null) return true;
                        else return false;
                    }
                }
            }
            GestorBD.Instancia.CerrarConexion();
            return false;
        }*/
        public void AgregarPermisoAPerfil(int codPerfil, Permiso pPermiso)
        {
            string query;
            if (pPermiso is PermisoSimple)
            {
                query = "INSERT INTO PermisoPerfil (Cod_Perfil, Cod_Permiso) VALUES (@CodPerfil, @CodPermiso)";
                using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
                {
                    cmd.Parameters.AddWithValue("@CodPerfil", codPerfil);
                    cmd.Parameters.AddWithValue("@CodPermiso", pPermiso.Codigo);
                    GestorBD.Instancia.AbrirConexion();
                    cmd.ExecuteNonQuery();
                    GestorBD.Instancia.CerrarConexion();
                }
            }
            else if(pPermiso is PermisoCompuesto)
            {
                query = "INSERT INTO FamiliaPerfil (Cod_Perfil, Cod_Familia) VALUES (@CodPerfil, @CodFamilia)";
                using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
                {
                    cmd.Parameters.AddWithValue("@CodPerfil", codPerfil);
                    cmd.Parameters.AddWithValue("@CodFamilia", pPermiso.Codigo);
                    GestorBD.Instancia.AbrirConexion();
                    cmd.ExecuteNonQuery();
                    GestorBD.Instancia.CerrarConexion();
                }
            }

        }
        public void QuitarPermisoAPerfil(int codPerfil, Permiso pPermiso)
        {
            string query;
            if (pPermiso is PermisoSimple)
            {
                query = "DELETE FROM PermisoPerfil WHERE Cod_Perfil = @CodPerfil AND Cod_Permiso = @CodPermiso";
                using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
                {
                    cmd.Parameters.AddWithValue("@CodPerfil", codPerfil);
                    cmd.Parameters.AddWithValue("@CodPermiso", pPermiso.Codigo);
                    GestorBD.Instancia.AbrirConexion();
                    cmd.ExecuteNonQuery();
                    GestorBD.Instancia.CerrarConexion();
                }
            }
            else if (pPermiso is PermisoCompuesto)
            {
                query = "DELETE FROM FamiliaPerfil WHERE Cod_Perfil = @CodPerfil AND Cod_Familia = @CodFamilia";
                using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
                {
                    cmd.Parameters.AddWithValue("@CodPerfil", codPerfil);
                    cmd.Parameters.AddWithValue("@CodFamilia", pPermiso.Codigo);
                    GestorBD.Instancia.AbrirConexion();
                    cmd.ExecuteNonQuery();
                    GestorBD.Instancia.CerrarConexion();
                }
            }

        }        
        public void CrearPerfil(Permiso permiso)
        {
            string query = "INSERT INTO Perfil (Cod_Perfil, Nombre_Perfil) VALUES (@Cod_Perfil, @Nombre_Perfil)";
            using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                cmd.Parameters.AddWithValue("@Cod_Perfil", permiso.Codigo);
                cmd.Parameters.AddWithValue("@Nombre_Perfil", permiso.Nombre);
                GestorBD.Instancia.AbrirConexion();
                cmd.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }

            foreach (Permiso p in permiso.ObtenerHijos())
            {
                if (p is PermisoSimple)
                {
                    string insertPermiso = "INSERT INTO PermisoPerfil (Cod_Perfil, Cod_Permiso) VALUES (@Cod_Perfil, @Cod_Permiso)";
                    using (SqlCommand cmd = new SqlCommand(insertPermiso, GestorBD.Instancia.ReturnConexion()))
                    {
                        cmd.Parameters.AddWithValue("@Cod_Perfil", permiso.Codigo);
                        cmd.Parameters.AddWithValue("@Cod_Permiso", p.Codigo);
                        GestorBD.Instancia.AbrirConexion();
                        cmd.ExecuteNonQuery();
                        GestorBD.Instancia.CerrarConexion();
                    }
                }
                else if (p is PermisoCompuesto)
                {
                    string insertFamilia = "INSERT INTO FamiliaPerfil (Cod_Perfil, Cod_Familia) VALUES (@Cod_Perfil, @Cod_Familia)";
                    using (SqlCommand cmd = new SqlCommand(insertFamilia, GestorBD.Instancia.ReturnConexion()))
                    {
                        cmd.Parameters.AddWithValue("@Cod_Perfil", permiso.Codigo);
                        cmd.Parameters.AddWithValue("@Cod_Familia", p.Codigo);
                        GestorBD.Instancia.AbrirConexion();
                        cmd.ExecuteNonQuery();
                        GestorBD.Instancia.CerrarConexion();
                    }
                }
            }
        }
        public void EliminarPerfil(Permiso pPermiso)
        {
            string borrarRelacionPermisosPerfil = "DELETE FROM PermisoPerfil WHERE Cod_Perfil = @CodPerfil";
            string borrarRelacionFamiliasPerfil = "DELETE FROM FamiliaPerfil WHERE Cod_Perfil = @CodPerfil";
            string borrarPerfil = "DELETE FROM Perfil WHERE Cod_Perfil = @CodPerfil";

            GestorBD.Instancia.AbrirConexion();
            SqlTransaction transaccion = GestorBD.Instancia.ReturnConexion().BeginTransaction();
            using (SqlCommand CM = new SqlCommand(borrarRelacionPermisosPerfil, GestorBD.Instancia.ReturnConexion(), transaccion))
            {
                CM.Parameters.AddWithValue("@CodPerfil", pPermiso.Codigo);
                CM.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(borrarRelacionFamiliasPerfil, GestorBD.Instancia.ReturnConexion(), transaccion))
            {
                cmd.Parameters.AddWithValue("@CodPerfil", pPermiso.Codigo);
                cmd.ExecuteNonQuery();
            }

            using (SqlCommand cmd = new SqlCommand(borrarPerfil, GestorBD.Instancia.ReturnConexion(), transaccion))
            {
                cmd.Parameters.AddWithValue("@CodPerfil", pPermiso.Codigo);
                cmd.ExecuteNonQuery();
            }
            transaccion.Commit();
            GestorBD.Instancia.CerrarConexion();
        }
        public List<Permiso> ObtenerPerfilesRelaciones()
        {
            List<Permiso> perfiles = new List<Permiso>();

            string query = "SELECT * FROM Perfil";
            using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PermisoCompuesto perfil = new PermisoCompuesto(int.Parse(dr["Cod_Perfil"].ToString()), dr["Nombre_Perfil"].ToString());
                        List<Permiso> hijos = ObtenerHijosDePerfil(perfil.Codigo);
                        foreach (Permiso hijo in hijos)
                        {
                            perfil.Agregar(hijo);
                        }
                        perfiles.Add(perfil);
                    }                    
                }
                GestorBD.Instancia.CerrarConexion();
            }

            return perfiles;
        }
        private List<Permiso> ObtenerHijosDePerfil(int codPerfil)
        {
            List<Permiso> hijos = new List<Permiso>();

            string queryPermisos = "SELECT P.Cod_Permiso, P.Nombre_Permiso FROM Permiso P INNER JOIN PermisoPerfil PP ON P.Cod_Permiso = PP.Cod_Permiso WHERE PP.Cod_Perfil = @Cod_Perfil";
            using (SqlCommand cmd = new SqlCommand(queryPermisos, GestorBD.Instancia.ReturnConexion()))
            {
                cmd.Parameters.AddWithValue("@Cod_Perfil", codPerfil);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        hijos.Add(new PermisoSimple(int.Parse(dr["Cod_Permiso"].ToString()), dr["Nombre_Permiso"].ToString()));
                    }
                }
            }

            string queryFamilias = "SELECT F.Cod_Familia, F.Nombre_Familia FROM Familia F INNER JOIN FamiliaPerfil FP ON F.Cod_Familia = FP.Cod_Familia WHERE FP.Cod_Perfil = @Cod_Perfil";
            using (SqlCommand cmd = new SqlCommand(queryFamilias, GestorBD.Instancia.ReturnConexion()))
            {
                cmd.Parameters.AddWithValue("@Cod_Perfil", codPerfil);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PermisoCompuesto familia = new PermisoCompuesto(int.Parse(dr["Cod_Familia"].ToString()), dr["Nombre_Familia"].ToString());

                        List<Permiso> hijosFamilia = ObtenerHijosDeFamilia(familia.Codigo);
                        foreach (Permiso hijo in hijosFamilia)
                        {
                            familia.Agregar(hijo);
                        }
                        hijos.Add(familia);
                    }
                }
            }
            return hijos;
        }
        public int ObtenerCodigoPerfil()
        {
            int numero = 1;
            string query = "SELECT ISNULL(MAX(Cod_Perfil), 0) + 1 FROM Perfil";
            using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                numero = (int)cmd.ExecuteScalar();
                GestorBD.Instancia.CerrarConexion();
            }
            return numero;
        }
        public List<Permiso> ObtenerFamiliasRelaciones()
        {
            List<Permiso> familias = new List<Permiso>();

            string query = "SELECT * FROM Familia";
            using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PermisoCompuesto familia = new PermisoCompuesto(int.Parse(dr["Cod_Familia"].ToString()), dr["Nombre_Familia"].ToString());
                        // Obtener hijos de esta familia
                        List<Permiso> hijos = ObtenerHijosDeFamilia(int.Parse(dr["Cod_Familia"].ToString()));
                        foreach (Permiso hijo in hijos)
                        {
                            familia.Agregar(hijo);
                        }

                        familias.Add(familia);
                    }
                }
                GestorBD.Instancia.CerrarConexion();
            }

            return familias;
        }
        private List<Permiso> ObtenerHijosDeFamilia(int codFamilia)
        {
            List<Permiso> hijos = new List<Permiso>();

            string queryPermisos = "SELECT P.Cod_Permiso, P.Nombre_Permiso FROM Permiso P INNER JOIN PermisoFamilia PF ON P.Cod_Permiso = PF.Cod_Permiso WHERE PF.Cod_Familia = @Cod";
            using (SqlCommand cmd = new SqlCommand(queryPermisos, GestorBD.Instancia.ReturnConexion()))
            {
                cmd.Parameters.AddWithValue("@Cod", codFamilia);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PermisoSimple permiso = new PermisoSimple(int.Parse(dr["Cod_Permiso"].ToString()), dr["Nombre_Permiso"].ToString());
                        hijos.Add(permiso);
                    }
                }
            }

            string queryFamilias = "SELECT F.Cod_Familia, F.Nombre_Familia FROM Familia F INNER JOIN FamiliaFamilia FF ON F.Cod_Familia = FF.Cod_FamiliaIncluida WHERE FF.Cod_FamiliaPrincipal = @Cod";
            using (SqlCommand cmd = new SqlCommand(queryFamilias, GestorBD.Instancia.ReturnConexion()))
            {
                cmd.Parameters.AddWithValue("@Cod", codFamilia);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PermisoCompuesto familiaHija = new PermisoCompuesto(int.Parse(dr["Cod_Familia"].ToString()), dr["Nombre_Familia"].ToString());
                        List<Permiso> hijosDeHija = ObtenerHijosDeFamilia(familiaHija.Codigo);
                        foreach (Permiso h in hijosDeHija)
                        {
                            familiaHija.Agregar(h);
                        }
                        hijos.Add(familiaHija);
                    }
                }
            }
            return hijos;
        }

    }
}

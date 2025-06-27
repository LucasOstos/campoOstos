using BE;
using ServiciosEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LectorDatos
    {
        private static LectorDatos Instancia;
        public static LectorDatos Datos
        {
            get
            {
                if (Instancia == null) Instancia = new LectorDatos();
                return Instancia;
            }
        }

        #region USUARIOS
        public List<Usuario> LeerUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string query = "SELECT * FROM Usuario";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader DR = CM.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        Usuario U = new Usuario(int.Parse(DR[0].ToString()), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(),
                                                DR[5].ToString(), Convert.ToBoolean(DR[6].ToString()), Convert.ToBoolean(DR[7].ToString()), int.Parse(DR[8].ToString()), Convert.ToBoolean(DR[9].ToString()), Convert.ToDateTime(DR[10].ToString()), DR[11].ToString());
                        listaUsuarios.Add(U);
                    }
                }
            }
            GestorBD.Instancia.CerrarConexion();
            return listaUsuarios;
        }
        public List<Usuario> LeerUsuariosBloqueados()
        {
            List<Usuario> listaUsuariosBloqueados = new List<Usuario>();
            string query = "SELECT * FROM Usuario WHERE Estado = 1";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader DR = CM.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        Usuario U = new Usuario(int.Parse(DR[0].ToString()), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(),
                                                DR[5].ToString(), Convert.ToBoolean(DR[6].ToString()), Convert.ToBoolean(DR[7].ToString()), int.Parse(DR[8].ToString()), Convert.ToBoolean(DR[9].ToString()), Convert.ToDateTime(DR[10].ToString()), DR[11].ToString());
                        listaUsuariosBloqueados.Add(U);
                    }
                }
            }
            GestorBD.Instancia.CerrarConexion();
            return listaUsuariosBloqueados;
        }
        public void AgregarUsuario(Usuario pUsuario)
        {
            string query = "INSERT INTO Usuario (DNI, Nombre, Apellido, Email, Contrasenia, Tipo, isHabilitado, Estado, Intentos, cambioContrasenia, ultimoLogin, Idioma) VALUES (@DNI, @Nombre, @Apellido, @Email, @Contrasenia, @Tipo, @isHabilitado, @Estado, @Intentos, @cambioContrasenia, @ultimoLogin, @Idioma)";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@DNI", pUsuario.DNI);
                CM.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
                CM.Parameters.AddWithValue("@Apellido", pUsuario.Apellido);
                CM.Parameters.AddWithValue("@Email", pUsuario.Email);
                CM.Parameters.AddWithValue("@Contrasenia", pUsuario.Contraseña);
                CM.Parameters.AddWithValue("@Tipo", pUsuario.Tipo);
                CM.Parameters.AddWithValue("@isHabilitado", pUsuario.IsHabilitado);
                CM.Parameters.AddWithValue("@Estado", pUsuario.Estado);
                CM.Parameters.AddWithValue("@Intentos", pUsuario.Intentos);
                CM.Parameters.AddWithValue("@cambioContrasenia", pUsuario.cambioContrasenia);
                CM.Parameters.AddWithValue("@ultimoLogin", pUsuario.ultimoLogin);
                CM.Parameters.AddWithValue("@Idioma", pUsuario.Idioma);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        public void BorrarUsuario(int DNI_UsuarioBorrar)
        {
            string query = $"DELETE FROM Usuario WHERE DNI = {DNI_UsuarioBorrar}";
            using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                cmd.ExecuteNonQuery();
            }
            GestorBD.Instancia.CerrarConexion();
        }
        public void ModificarUsuario(int pDNI, Usuario usuarioModificado)
        {
            string query = $"UPDATE Usuario SET DNI = @DNI, Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Tipo = @Tipo, Estado = @Estado WHERE DNI = {pDNI}";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@DNI", usuarioModificado.DNI);
                CM.Parameters.AddWithValue("@Nombre", usuarioModificado.Nombre);
                CM.Parameters.AddWithValue("@Apellido", usuarioModificado.Apellido);
                CM.Parameters.AddWithValue("@Email", usuarioModificado.Email);
                CM.Parameters.AddWithValue("@Tipo", usuarioModificado.Tipo);
                CM.Parameters.AddWithValue("@Estado", usuarioModificado.Estado);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        public void CambiarContraseña(int pDNI, Usuario pUsuario)
        {
            string query = $"UPDATE Usuario SET Contrasenia = @Contrasenia, cambioContrasenia = @cambioContrasenia WHERE DNI = {pDNI}";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@Contrasenia", pUsuario.Contraseña);
                CM.Parameters.AddWithValue("@cambioContrasenia", pUsuario.cambioContrasenia);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        public void Desbloquear(Usuario pUsuario)
        {
            string query = $"UPDATE Usuario SET Contrasenia = @Contrasenia, Estado = @Estado, Intentos = @Intentos WHERE DNI = {pUsuario.DNI}";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@Contrasenia", pUsuario.Contraseña);
                CM.Parameters.AddWithValue("@Estado", pUsuario.Estado);
                CM.Parameters.AddWithValue("@Intentos", pUsuario.Intentos);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        public void BloquearUsuario(bool Estado, int pDNI)
        {
            string query = $"UPDATE Usuario SET Estado = 1 WHERE DNI = {pDNI}";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@Estado", Estado);
                CM.Parameters.AddWithValue("@DNI", pDNI);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        public void ActualizarIntentos(int Intentos, int pDNI)
        {
            string query = $"UPDATE Usuario SET Intentos = @Intentos WHERE DNI = {pDNI}";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@Intentos", Intentos);
                CM.Parameters.AddWithValue("@DNI", pDNI);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        public void CambiarEstado(bool pEstado, string pEmail)
        {
            string query = $"UPDATE Usuario SET isHabilitado = @isHabilitado WHERE Email = '{pEmail}'";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@isHabilitado", pEstado);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        public void ActualizarIdiomaUsuario(string nuevoIdioma, Usuario pUsuario)
        {
            string query = $"UPDATE Usuario SET Idioma = @Idioma WHERE DNI = {pUsuario.DNI}";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@Idioma", nuevoIdioma);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        #endregion

        #region CLIENTES
        public List<Cliente> LeerClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            string query = "SELECT * FROM Cliente";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader DR = CM.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        Cliente C = new Cliente();
                        C.DNI = int.Parse(DR[0].ToString());
                        C.Nombre = DR[1].ToString();
                        C.Apellido = DR[2].ToString();
                        C.Celular = int.Parse(DR[3].ToString());
                        C.Email = DR[4].ToString();
                        listaClientes.Add(C);
                    }
                }
            }
            GestorBD.Instancia.CerrarConexion();
            return listaClientes;
        }
        public void AgregarCliente(Cliente C)
        {
            string query = "INSERT INTO Cliente (ClienteDNI, ClienteNombre, ClienteApellido, ClienteCelular, ClienteEmail) VALUES (@ClienteDNI, @ClienteNombre, @ClienteApellido, @ClienteCelular, @ClienteEmail)";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@ClienteDNI", C.DNI);
                CM.Parameters.AddWithValue("@ClienteNombre", C.Nombre);
                CM.Parameters.AddWithValue("@ClienteApellido", C.Apellido);
                CM.Parameters.AddWithValue("@ClienteCelular", C.Celular);
                CM.Parameters.AddWithValue("@ClienteEmail", C.Email);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        public void BorrarCliente(int DNICliente)
        {
            string query = $"DELETE FROM Cliente WHERE ClienteDNI = {DNICliente}";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
            }
            GestorBD.Instancia.CerrarConexion();
        }
        public void ModificarCliente(Cliente clienteMod)
        {
            string query = $"UPDATE Cliente SET ClienteDNI = @ClienteDNI, ClienteNombre = @ClienteNombre, ClienteApellido = @ClienteApellido, ClienteCelular = @ClienteCelular, ClienteEmail = @ClienteEmail WHERE ClienteDNI = {clienteMod.DNI}";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@ClienteDNI", clienteMod.DNI);
                CM.Parameters.AddWithValue("@ClienteNombre", clienteMod.Nombre);
                CM.Parameters.AddWithValue("@ClienteApellido", clienteMod.Apellido);
                CM.Parameters.AddWithValue("@ClienteCelular", clienteMod.Celular);
                CM.Parameters.AddWithValue("@ClienteEmail", clienteMod.Email);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        #endregion

        #region PRODUCTOS
        public List<Producto> ObtenerProductosPorTipo(string Tipo)
        {
            List<Producto> listaProducto = new List<Producto>();
            string query = "SELECT * FROM Producto WHERE TipoProducto LIKE @TipoProducto + '%'";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@TipoProducto", Tipo);
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader DR = CM.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        Producto P = new Producto(int.Parse(DR[0].ToString()), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), int.Parse(DR[4].ToString()), int.Parse(DR[5].ToString()));                        
                        listaProducto.Add(P);
                    }
                }
            }
            GestorBD.Instancia.CerrarConexion();
            return listaProducto;
        }
        public Producto ObtenerProductoPorNombre(string pNombre)
        {
            Producto p = null;
            string query = "SELECT * FROM Producto WHERE NombreProducto LIKE @NombreProducto + '%'";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@NombreProducto", pNombre);
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader DR = CM.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        p = new Producto(int.Parse(DR[0].ToString()), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), int.Parse(DR[4].ToString()), int.Parse(DR[5].ToString()));
                    }
                }
            }
            GestorBD.Instancia.CerrarConexion();
            return p;
        }
        public Producto ObtenerProducto(int pCodigo)
        {
            Producto P = null;
            string query = "SELECT * FROM Producto WHERE CodigoProducto = @CodigoProducto";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@CodigoProducto", pCodigo);
                GestorBD.Instancia.AbrirConexion();
                using (SqlDataReader DR = CM.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        P = new Producto(int.Parse(DR[0].ToString()), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), int.Parse(DR[4].ToString()), int.Parse(DR[5].ToString()));                        
                    }
                }
            }
            GestorBD.Instancia.CerrarConexion();
            return P;
        }
        public void StockProducto(int prodCodigo, int prodCantidad)
        {
            string query = $"UPDATE Producto SET CantidadProducto = @CantidadProducto WHERE CodigoProducto = {prodCodigo}";
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                CM.Parameters.AddWithValue("@CodigoProducto", prodCodigo);
                CM.Parameters.AddWithValue("@CantidadProducto", prodCantidad);
                GestorBD.Instancia.AbrirConexion();
                CM.ExecuteNonQuery();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        #endregion

        #region FACTURA
        public int ObtenerProximoNumeroFactura()
        {
            int numero = 1;
            string query = "SELECT ISNULL(MAX(NumFactura), 0) + 1 FROM Factura";            
            using (SqlCommand cmd = new SqlCommand(query, GestorBD.Instancia.ReturnConexion()))
            {
                GestorBD.Instancia.AbrirConexion();
                numero = (int)cmd.ExecuteScalar();
                GestorBD.Instancia.CerrarConexion();
            }
            return numero;
        }

        public void GuardarFactura(Cliente pCliente, Factura pFactura)
        {
            string query = "INSERT INTO Factura (NumFactura, DNICliente, FechaEmision, Total) VALUES (@NumFactura, @DNICliente, @FechaEmision, @Total)";
            GestorBD.Instancia.AbrirConexion();
            SqlTransaction transaccion = GestorBD.Instancia.ReturnConexion().BeginTransaction();
            using (SqlCommand CM = new SqlCommand(query, GestorBD.Instancia.ReturnConexion(), transaccion))
            {
                CM.Parameters.AddWithValue("@NumFactura", pFactura.NumFactura);
                CM.Parameters.AddWithValue("@DNICliente", pCliente.DNI);
                CM.Parameters.AddWithValue("@FechaEmision", pFactura.FechaEmision);
                CM.Parameters.AddWithValue("@Total", pFactura.PrecioTotal);
                
                CM.ExecuteNonQuery();

                foreach(DetalleFactura detale in pFactura.detallesFactura)
                {
                    SqlCommand cmDetalle = new SqlCommand("INSERT INTO DetalleFactura (NumFactura, CodProducto) VALUES (@NumFactura, @CodProducto)", GestorBD.Instancia.ReturnConexion(), transaccion);
                    cmDetalle.Parameters.AddWithValue("@NumFactura", pFactura.NumFactura);
                    cmDetalle.Parameters.AddWithValue("@CodProducto", detale.Producto.Codigo);
                    cmDetalle.ExecuteNonQuery();
                }
                transaccion.Commit();
                GestorBD.Instancia.CerrarConexion();
            }
        }
        #endregion

    }
}

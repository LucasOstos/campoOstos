using BLL;
using SERVICIOS;
using ServiciosEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI
{
    public partial class GuiPermisos : Form, IObserver
    {
        public GuiPermisos()
        {
            InitializeComponent();            
        }
        private void GuiPermisos_Load(object sender, EventArgs e)
        {
            Traductor.Instancia.Suscribir(this);
            Traductor.Instancia.Notificar(Sesion.Instancia.Usuario.Idioma);
            ActualizarIdioma();
            CargarPermisosFamilia();
            CargarFamilias();
            CargarPerfiles();
        }

        #region Funciones
        private void CargarFamilias()
        {
            cbFamilias.Items.Clear();
            foreach (Permiso P in GestorPermiso.Instancia.Familias())
            {
                cbFamilias.Items.Add(P.Nombre);
            }
        }
        private void CargarPerfiles()
        {
            cbPerfiles.Items.Clear();
            cbPerfiles.DisplayMember = "Nombre";
            foreach (Permiso P in GestorPermiso.Instancia.Perfiles())
            {
                cbPerfiles.Items.Add(P);
            }
        }                
        private void CargarPermisosFamilia()
        {
            lbPermisosPerfil.Items.Clear();
            lbPermisosFamilia.Items.Clear();
            foreach (Permiso P in GestorPermiso.Instancia.Permisos())
            {
                lbPermisosPerfil.Items.Add(P);
                lbPermisosFamilia.Items.Add(P);                
            }
            foreach (Permiso p in GestorPermiso.Instancia.Familias())
            {
                lbPermisosPerfil.Items.Add(p);
                lbPermisosFamilia.Items.Add(p);
            }
        }
        public List<string> ListarPermisosRecursivo(Permiso permiso)
        {
            List<string> lista = new List<string>();
            AgregarPermisosRecursivo(permiso, lista);
            return lista;
        }
        private void AgregarPermisosRecursivo(Permiso permiso, List<string> lista)
        {
            if (!lista.Contains(permiso.Nombre))
            {
                lista.Add(permiso.Nombre);
            }

            if (permiso.EsCompuesto())
            {
                foreach (var hijo in permiso.ObtenerHijos())
                {
                    AgregarPermisosRecursivo(hijo, lista);
                }
            }
        }
        private void MostrarPermisosPerfil()
        {
            string nombrePerfil = cbPerfiles.Text;
            Permiso perfilSeleccionado = GestorPermiso.Instancia.Perfiles().Find(p => p.Nombre == nombrePerfil);

            if (perfilSeleccionado != null)
            {
                listBoxPermisosPerfil.Items.Clear();
                List<string> permisos = ListarPermisosRecursivo(perfilSeleccionado);
                foreach (var nombrePermiso in permisos)
                {
                    if (nombrePermiso != cbPerfiles.Text)
                    {
                        listBoxPermisosPerfil.Items.Add(nombrePermiso);
                    }
                }
            }
        }
        private void LimpiarDatos()
        {            
            tbNombrePerfil.Clear();
            listBoxPermisosPerfil.Items.Clear();
        }
        private bool PermisoYaExisteEnLista(Permiso permisoNuevo)
        {
            foreach (object item in listBoxPermisosPerfil.Items)
            {
                if (item is Permiso existente)
                {
                    if (existente.Nombre == permisoNuevo.Nombre)
                        return true;

                    if (existente.EsCompuesto())
                    {
                        foreach (Permiso hijo in existente.ObtenerHijosRecursivo())
                        {
                            if (hijo.Nombre == permisoNuevo.Nombre)
                                return true;
                        }
                    }

                    if (permisoNuevo.EsCompuesto())
                    {
                        foreach (Permiso hijoNuevo in permisoNuevo.ObtenerHijosRecursivo())
                        {
                            if (existente.Nombre == hijoNuevo.Nombre)
                                return true;

                            if (existente.EsCompuesto())
                            {
                                foreach (Permiso hijoExistente in existente.ObtenerHijosRecursivo())
                                {
                                    if (hijoExistente.Nombre == hijoNuevo.Nombre)
                                        return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        #endregion

        private void btnCrearPerfil_Click(object sender, EventArgs e)
        {
            string nombrePerfil = tbNombrePerfil.Text.Trim();
            if(!string.IsNullOrWhiteSpace(nombrePerfil))
            {
                if(listBoxPermisosPerfil.Items.Count > 0)
                {
                    if(GestorPermiso.Instancia.Perfiles().Find(x => x.Nombre == nombrePerfil) == null)
                    {
                        Permiso perfilNuevo = new PermisoCompuesto(0, nombrePerfil);                        
                        foreach(Permiso p in listBoxPermisosPerfil.Items)
                        {
                            perfilNuevo.Agregar(p);
                        }
                        GestorPermiso.Instancia.CrearPerfil(perfilNuevo);
                        LimpiarDatos();
                        MessageBox.Show("Perfil creado con éxito");
                        CargarPerfiles();
                    }
                    else { MessageBox.Show("El perfil ya existe"); LimpiarDatos(); }
                }
                else { MessageBox.Show("Debe agregar al menos un permiso al perfil."); }
            }
            else { MessageBox.Show("Debe ingresar un nombre para el perfil."); }
            
        }
        private void btnAgregarPermisosPerfil_Click(object sender, EventArgs e)
        {
            if(cbPerfiles.SelectedItem == null) //CREANDO UN PERFIL
            {
                if (lbPermisosPerfil.SelectedItem != null)
                {
                    string itemPermiso = lbPermisosPerfil.SelectedItem.ToString();
                    bool esFamilia = itemPermiso.StartsWith("[Familia]");
                    string nombrePermiso = itemPermiso.Substring(itemPermiso.IndexOf("]") + 2);
                    Permiso seleccionado = esFamilia ? GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombrePermiso) : GestorPermiso.Instancia.Permisos().Find(p => p.Nombre == nombrePermiso);
                    if (!PermisoYaExisteEnLista(seleccionado))
                    {
                        if(seleccionado.EsCompuesto())
                        {
                            listBoxPermisosPerfil.Items.Add(seleccionado);
                            foreach (Permiso p in seleccionado.ObtenerHijos())
                            {
                                listBoxPermisosPerfil.Items.Add(p);
                            }
                        }
                        else { listBoxPermisosPerfil.Items.Add(seleccionado); }
                    }
                    else { MessageBox.Show("El permiso ya fue agregado."); }
                }
                else { MessageBox.Show("Debe seleccionar un permiso"); }
            }
            else if(cbPerfiles.SelectedItem != null) //MODIFICANDO UN PERFIL
            {
                string nombrePerfil = cbPerfiles.Text;
                Permiso perfil = GestorPermiso.Instancia.Perfiles().Find(p => p.Nombre == nombrePerfil);
                string itemPermiso = lbPermisosPerfil.SelectedItem.ToString();
                bool esFamilia = itemPermiso.StartsWith("[Familia]");
                string nombrePermiso = itemPermiso.Substring(itemPermiso.IndexOf("]") + 2);
                Permiso permiso = esFamilia ? GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombrePermiso) : GestorPermiso.Instancia.Permisos().Find(p => p.Nombre == nombrePermiso);
                if (!GestorPermiso.Instancia.PermisoExistente(perfil.Codigo, permiso))
                {
                    perfil.Agregar(permiso);
                    GestorPermiso.Instancia.AgregarPermisosPerfil(perfil.Codigo, permiso);
                    MostrarPermisosPerfil();
                }
                else { MessageBox.Show("El permiso o familia ya está asignada al perfil o a una familia incluida en el perfil."); }
            }            
        }
        private void btnQuitarPermisosPerfil_Click(object sender, EventArgs e)
        {
            string nombrePerfil = cbPerfiles.Text;
            Permiso perfil = GestorPermiso.Instancia.Perfiles().Find(p => p.Nombre == nombrePerfil);
            string nombrePermiso = listBoxPermisosPerfil.Text;
            Permiso permiso = perfil.ObtenerHijos().Find(p => p.Nombre == nombrePermiso);
            if (permiso != null)
            {
                perfil.Quitar(permiso);
                GestorPermiso.Instancia.QuitarPermisosPerfil(perfil.Codigo, permiso);
                MostrarPermisosPerfil();
            }
        }
        private void btnBorrarPerfil_Click(object sender, EventArgs e)
        {
            string nombrePerfil = cbPerfiles.Text;
            Permiso perfil = GestorPermiso.Instancia.Perfiles().Find(p => p.Nombre == nombrePerfil);
            GestorPermiso.Instancia.EliminarPerfil(perfil);
            LimpiarDatos();
            MessageBox.Show("Perfil eliminado correctamente.");
            CargarPerfiles();
        }
        private void btnCrearFamilia_Click(object sender, EventArgs e)
        {
            /*if (tbNombrePerfil.Text == "")
            {
                MessageBox.Show(Traducir("MsgNombrePermisoVacio"));
            }
            else
            {
                if (checkedListBox1.Items.Contains(tbNombrePerfil.Text))
                {
                    MessageBox.Show(Traducir("MsgPermisoExistente"));
                }
                else
                {
                    List<string> items = new List<string>();
                    foreach (var CI in checkedListBox1.CheckedItems)
                    {
                        items.Add(CI.ToString());
                    }
                    GestorPermiso.Instancia.AgregarPermisoCompuesto(tbNombrePerfil.Text, items, false);
                    MostrarPermisos();
                    tbNombrePerfil.Clear();
                }
            }*/
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Idiomas
        public void ActualizarIdioma()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() != typeof(ComboBox))
                {
                    if (c.GetType() != typeof(TextBox))
                    {
                        if (c.GetType() != typeof(Label))
                        {
                            if (c.GetType() == typeof(Button))
                            {
                                c.Text = Traducir(c.Name);
                            }
                        }
                        c.Text = Traducir(c.Name);
                    }
                }
            }
        }        
        private string Traducir(string paraTraducir)
        {
            return Traductor.Instancia.Traducir(paraTraducir);
        }
        #endregion

        #region Eventos
        private void cbPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarPermisosPerfil();
        }        
        private void cbFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreFamilia = cbFamilias.Text;
            Permiso familiaSeleccionada = GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombreFamilia);

            if (familiaSeleccionada != null)
            {
                listBoxPermisosFamilia.Items.Clear();
                List<string> permisos = ListarPermisosRecursivo(familiaSeleccionada);
                foreach (var nombrePermiso in permisos)
                {
                    if(nombrePermiso != cbFamilias.Text)
                    {
                        listBoxPermisosFamilia.Items.Add(nombrePermiso);
                    }
                }
            }
        }
        #endregion

    }
}

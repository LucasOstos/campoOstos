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
        private void MostrarPermisosFamilia()
        {
            string nombreFamilia = cbFamilias.Text;
            Permiso familiaSeleccionado = GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombreFamilia);

            if (familiaSeleccionado != null)
            {
                listBoxPermisosFamilia.Items.Clear();
                List<string> permisos = ListarPermisosRecursivo(familiaSeleccionado);
                foreach (var nombrePermiso in permisos)
                {
                    if (nombrePermiso != cbFamilias.Text)
                    {
                        listBoxPermisosFamilia.Items.Add(nombrePermiso);
                    }
                }
            }
        }
        private void LimpiarDatos()
        {            
            tbNombrePerfil.Clear();
            listBoxPermisosPerfil.Items.Clear();
        }
        private void LimpiarDatosFamilia()
        {
            tbNombreFamilia.Clear();
            listBoxPermisosFamilia.Items.Clear();
        }
        private bool PermisoYaExisteEnLista(Permiso permisoNuevo, ListBox lb)
        {
            foreach (object item in lb.Items)
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
                        MessageBox.Show(Traducir("MsgPerfilCreado"));
                        CargarPerfiles();
                    }
                    else { MessageBox.Show(Traducir("MsgPerfilExistente")); LimpiarDatos(); }
                }
                else { MessageBox.Show(Traducir("MsgSinPermisos")); }
            }
            else { MessageBox.Show(Traducir("MsgSinNombre")); }
            
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
                    if (!PermisoYaExisteEnLista(seleccionado, listBoxPermisosPerfil))
                    {
                        listBoxPermisosPerfil.Items.Add(seleccionado);
                    }
                    else { MessageBox.Show(Traducir("MsgPermisoAgregado")); }
                }
                else { MessageBox.Show(Traducir("MsgPermisoNoElegido")); }
            }
            else //MODIFICANDO UN PERFIL
            {
                string nombrePerfil = cbPerfiles.Text;
                Permiso perfil = GestorPermiso.Instancia.Perfiles().Find(p => p.Nombre == nombrePerfil);
                string itemPermiso = lbPermisosPerfil.SelectedItem.ToString();
                bool esFamilia = itemPermiso.StartsWith("[Familia]");
                string nombrePermiso = itemPermiso.Substring(itemPermiso.IndexOf("]") + 2);
                Permiso permiso = esFamilia ? GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombrePermiso) : GestorPermiso.Instancia.Permisos().Find(p => p.Nombre == nombrePermiso);
                if (!GestorPermiso.Instancia.PermisoExistentePerfil(perfil.Codigo, permiso))
                {
                    perfil.Agregar(permiso);
                    GestorPermiso.Instancia.AgregarPermisosPerfil(perfil.Codigo, permiso);
                    MostrarPermisosPerfil();
                }
                else { MessageBox.Show(Traducir("MsgYaAgregado")); }
            }            
        }
        private void btnQuitarPermisosPerfil_Click(object sender, EventArgs e)
        {
            string nombrePerfil = cbPerfiles.Text;
            Permiso perfil = GestorPermiso.Instancia.Perfiles().Find(p => p.Nombre == nombrePerfil);
            if(perfil != null)
            {
                string nombrePermiso = listBoxPermisosPerfil.Text;
                Permiso permiso = perfil.ObtenerHijos().Find(p => p.Nombre == nombrePermiso);
                if (permiso != null)
                {
                    perfil.Quitar(permiso);
                    GestorPermiso.Instancia.QuitarPermisosPerfil(perfil.Codigo, permiso);
                    MostrarPermisosPerfil();
                }
            }
            else { listBoxPermisosPerfil.Items.Remove(listBoxPermisosPerfil.SelectedItem); }
        }
        private void btnBorrarPerfil_Click(object sender, EventArgs e)
        {
            string nombrePerfil = cbPerfiles.Text;
            Permiso perfil = GestorPermiso.Instancia.Perfiles().Find(p => p.Nombre == nombrePerfil);
            GestorPermiso.Instancia.EliminarPerfil(perfil);
            LimpiarDatos();
            MessageBox.Show(Traducir("MsgPerfilEliminado"));
            CargarPerfiles();
        }
        private void btnCrearFamilia_Click(object sender, EventArgs e)
        {
            string nombreFamilia = tbNombreFamilia.Text.Trim();
            if (!string.IsNullOrWhiteSpace(nombreFamilia))
            {
                if (listBoxPermisosFamilia.Items.Count > 0)
                {
                    if (GestorPermiso.Instancia.Familias().Find(x => x.Nombre == nombreFamilia) == null)
                    {
                        Permiso familiaNueva = new PermisoCompuesto(0, nombreFamilia);
                        foreach (Permiso p in listBoxPermisosFamilia.Items)
                        {
                            familiaNueva.Agregar(p);
                        }
                        GestorPermiso.Instancia.CrearFamilia(familiaNueva);
                        LimpiarDatosFamilia();
                        MessageBox.Show(Traducir("MsgFamiliaCreada"));
                        CargarFamilias();
                        CargarPermisosFamilia();
                    }
                    else { MessageBox.Show(Traducir("MsgFamiliaExistente")); LimpiarDatos(); }
                }
                else { MessageBox.Show(Traducir("MsgSinPermisos")); }
            }
            else { MessageBox.Show(Traducir("MsgSinNombre")); }
        }
        private void btnAgregarPermisosFamilia_Click(object sender, EventArgs e)
        {
            if(cbFamilias.SelectedItem == null)
            {
                if(lbPermisosFamilia.SelectedItem != null)
                {
                    string itemPermiso = lbPermisosFamilia.SelectedItem.ToString();
                    bool esFamilia = itemPermiso.StartsWith("[Familia]");
                    string nombrePermiso = itemPermiso.Substring(itemPermiso.IndexOf("]") + 2);
                    Permiso seleccionado = esFamilia ? GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombrePermiso) : GestorPermiso.Instancia.Permisos().Find(p => p.Nombre == nombrePermiso);
                    if(!PermisoYaExisteEnLista(seleccionado, listBoxPermisosFamilia))
                    {
                        listBoxPermisosFamilia.Items.Add(seleccionado);
                    }
                    else { MessageBox.Show(Traducir("MsgPermisoAgregado")); }
                }
                else { MessageBox.Show(Traducir("MsgPermisoNoElegido")); }
            }
            else
            {
                string nombreFamilia = cbFamilias.Text;
                Permiso familia = GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombreFamilia);
                string itemPermiso = lbPermisosFamilia.SelectedItem.ToString();
                bool esFamilia = itemPermiso.StartsWith("[Familia]");
                string nombrePermiso = itemPermiso.Substring(itemPermiso.IndexOf("]") + 2);
                Permiso permiso = esFamilia ? GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombrePermiso) : GestorPermiso.Instancia.Permisos().Find(p => p.Nombre == nombrePermiso);
                if(!GestorPermiso.Instancia.PermisoExistenteFamilia(familia.Codigo, permiso))
                {
                    familia.Agregar(permiso);
                    GestorPermiso.Instancia.AgregarPermisosFamilia(familia.Codigo, permiso);
                    MostrarPermisosFamilia();
                }
                else { MessageBox.Show(Traducir("MsgIncluida")); }
            }
        }
        private void btnQuitarPermisosFamilia_Click(object sender, EventArgs e)
        {
            string nombreFamilia = cbFamilias.Text;
            Permiso familia = GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombreFamilia);
            if (familia != null)
            {
                string nombrePermiso = listBoxPermisosFamilia.Text;
                Permiso permiso = familia.ObtenerHijos().Find(p => p.Nombre == nombrePermiso);
                if (permiso != null)
                {
                    familia.Quitar(permiso);
                    GestorPermiso.Instancia.QuitarPermisosFamilia(familia.Codigo, permiso);
                    MostrarPermisosFamilia();
                }
            }
            else { listBoxPermisosFamilia.Items.Remove(listBoxPermisosFamilia.SelectedItem); }
        }
        private void btnBorrarFamilia_Click(object sender, EventArgs e)
        {
            string nombreFamilia = cbFamilias.Text;
            Permiso familia = GestorPermiso.Instancia.Familias().Find(p => p.Nombre == nombreFamilia);
            GestorPermiso.Instancia.EliminarFamilia(familia);
            listBoxPermisosFamilia.Items.Clear();
            MessageBox.Show(Traducir("MsgFamiliaEliminada"));
            CargarFamilias();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargarFamilias();
            CargarPerfiles();
            listBoxPermisosFamilia.Items.Clear();
            listBoxPermisosPerfil.Items.Clear();
        }
    }
}

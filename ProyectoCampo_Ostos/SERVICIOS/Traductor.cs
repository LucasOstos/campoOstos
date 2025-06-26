using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SERVICIOS
{
    public class Traductor : ISujetoTraductor
    {
        private static Traductor instancia;
        public static Traductor Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Traductor();
                }
                return instancia;
            }
        }
        List<IObserver> listaObservadores;
        Dictionary<string, string> traducciones;
        string Idioma;
        string DireccionArchivoJson;
        string ContenidoArchivoJson;
        public Traductor()
        {
            listaObservadores = new List<IObserver>();
            Idioma = "Español";
            DireccionArchivoJson = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\Idiomas\{Idioma}.json"));
            ContenidoArchivoJson = File.ReadAllText(DireccionArchivoJson);
            traducciones = JsonConvert.DeserializeObject<Dictionary<string, string>>(ContenidoArchivoJson);
        }
        public void CargarTraducciones(object sender, string nuevoIdioma)
        {
            if (File.Exists(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\Idiomas\{nuevoIdioma}.json"))))
            {
                DireccionArchivoJson = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\Idiomas\{nuevoIdioma}.json"));
                ContenidoArchivoJson = File.ReadAllText(DireccionArchivoJson);
                traducciones.Clear();
                traducciones = JsonConvert.DeserializeObject<Dictionary<string, string>>(ContenidoArchivoJson);
            }
        }
        public string Traducir(string paraTraducir)
        {
            try
            {
                if (traducciones.Count == 0) CargarTraducciones(null, "Español");
                string translation = "";
                return translation = traducciones[paraTraducir];
            }
            catch (Exception) { return paraTraducir; }
        }
        public void Suscribir(IObserver pObservador)
        {
            listaObservadores.Add(pObservador);
        }
        public void Desuscribir(IObserver pObservador)
        {
            if (listaObservadores.Contains(pObservador))
            {
                listaObservadores.Remove(pObservador);
            }
        }
        public void Notificar(string idioma)
        {
            Sesion.Instancia.EstablecerIdioma(idioma);
            foreach (IObserver observador in listaObservadores)
            {
                observador.ActualizarIdioma();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiciosEntidades;

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
        public Traductor()
        {
            listaObservadores = new List<IObserver>();
            string Idioma = Sesion.Instancia.Usuario.Idioma;
            string rutaJson = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\Idiomas\{Idioma}.json"));
            string contenidoJson = File.ReadAllText(rutaJson);
            traducciones = JsonConvert.DeserializeObject<Dictionary<string, string>>(contenidoJson);
        }
        public void CargarTraducciones(string nuevoIdioma)
        {
            if (File.Exists(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\Idiomas\{nuevoIdioma}.json"))))
            {
                string rutaJson = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\Idiomas\{nuevoIdioma}.json"));
                string contenidoJson = File.ReadAllText(rutaJson);
                traducciones.Clear();
                traducciones = JsonConvert.DeserializeObject<Dictionary<string, string>>(contenidoJson);
            }
        }
        public string Traducir(string paraTraducir)
        {
            try
            {
                if (traducciones.Count == 0) CargarTraducciones(Sesion.Instancia.Usuario.Idioma);
                string traduccion = "";
                return traduccion = traducciones[paraTraducir];
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

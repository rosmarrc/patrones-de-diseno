using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_singleton
{
    public sealed class ConexionBasedeDatos
    {
       public string Nombre { get; set; }
        private ConexionBasedeDatos()
        {
            
        }

        private static ConexionBasedeDatos? Instancia;

        public static ConexionBasedeDatos ObtenerInstancia(string nombre)
        {
            if (Instancia == null)
            {
                Instancia = new ConexionBasedeDatos();
                Instancia.Nombre = nombre;

            }
            return Instancia;
        }
    }
}

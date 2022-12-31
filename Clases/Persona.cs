using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion3.Clases
{
    internal abstract class Persona
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int AnioNacimiento { get; set; }
        private DateTime FechaHoy = DateTime.Today;

        public Persona (int dni, string nombre, string apellido, int anioNacimiento)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            AnioNacimiento = anioNacimiento;
        }

        public int Edad()
        {
            return FechaHoy.Year - AnioNacimiento;
        }

        public abstract void MostrarDatos();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion3.Clases
{
    internal class Alumno: Persona
    {
        public int[] examenes = new int[10] { 2, 5, 6, 6, 7, 8, 10, 6, 6, 5 };
        public Alumno(int dni, string nombre, string apellido, int anioNacimiento) : base (dni, nombre, apellido, anioNacimiento)
        {

        }

        public double Promedio()
        {
            return examenes.Average();
        }

        public string ListaNotas()
        {
            string lista = "";
            int contador = 1;
            foreach (int examen in examenes)
            {
                lista += $"{contador++}° examen: {examen}.\n";
            }
            return lista;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Lista de notas:\n{ListaNotas()}\nPromedio: {Promedio()}");
        }
    }
}

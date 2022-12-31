using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion3.Clases
{
    internal class GrupoPersonas
    {
        public List <Alumno> Alumnos { get; set; }

        public GrupoPersonas(List<Alumno> alumnos)
        {
            Alumnos = alumnos;
        }

        private Boolean EsMayor(Alumno alumno)
        {
            Boolean mayor = false;
            if(alumno.Edad() >= 18)
            {
                mayor = true;
            }

            return mayor;
        }

        private int ContadorMayores()
        {
            int contador = 0;
            foreach(Alumno alumno in Alumnos)
            {
                if (EsMayor(alumno))
                {
                    contador++;
                }
            }
            return contador;
        }

        public void MostrarEdadesMayoresYMenores()
        {
            Console.WriteLine($"La cantidad de personas mayores es: {ContadorMayores()} y la cantidad de menores es {Alumnos.Count - ContadorMayores()}");
        }

        private string AlumnoConNombreMasLargo()
        {
            int contador = 0;
            string nombreMasLargo = "";
            foreach(Alumno alumno in Alumnos)
            {
               if (alumno.Nombre.Length > contador)
                {
                    contador = alumno.Nombre.Length;
                    nombreMasLargo = alumno.Nombre;
                } 
            }

            return nombreMasLargo;
        }

        private string AlumnoConNombreMasCorto()
        {
            int contador = 999;
            string nombreMasCorto = "";
            foreach (Alumno alumno in Alumnos)
            {
                if (alumno.Nombre.Length < contador)
                {
                    contador = alumno.Nombre.Length;
                    nombreMasCorto = alumno.Nombre;
                }
            }

            return nombreMasCorto;
        }

        public void MostrarNombreMasLargoYCorto()
        {
            Console.WriteLine($"El alumno con el nombre mas largo es {AlumnoConNombreMasLargo()} y el del nombre mas corto es {AlumnoConNombreMasCorto()}");
        }
    }
}

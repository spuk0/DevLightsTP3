using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion3.Clases
{
    internal class Matrices
    {
        public char[,] matrizLetras = new char[5, 5];
        public int[,] matrizDiasMes = new int[5, 7];
        public int[,] matrizTablasMultiplicar = new int[10, 10]; 


        //P en pares e I en impares.
        private void LlenarMatriz()
        {
            for(int filas = 0; filas < matrizLetras.GetLength(0); filas++)
            {
                for(int columnas = 0; columnas < matrizLetras.GetLength(1); columnas++)
                {
                    if((filas + columnas) % 2 == 0)
                    {
                        matrizLetras[filas, columnas] = 'P';
                    }
                    else
                    {
                        matrizLetras[filas, columnas] = 'I';
                    }
                }
            }
        }

        //Muestra la matriz que tiene P e I.
        public void MostrarDatos()
        {
            LlenarMatriz();
            for (int filas = 0; filas < matrizLetras.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matrizLetras.GetLength(1); columnas++)
                {
                    Console.Write(matrizLetras[filas, columnas] + "\t");
                }
                Console.WriteLine();
            }
        }

        /*Genera al azar temperaturas de cada dia del mes.*/
        public void temperaturaMayo()
        {
            var random = new Random();

            for (int i = 0; i < matrizDiasMes.GetLength(0); i++)
            {
                int value = random.Next(7, 38);
                for(int j = 0; j< matrizDiasMes.GetLength(1);j++)
                {
                    matrizDiasMes[i, j] = value;
                }
            }
        }

        //Para determinar el dia segun el numero.
        private string QueDiaEs(int indice)
        {
            string dia = "";
            switch (indice)
            {
                case 0:
                    dia = "lunes";
                    break;
                case 1:
                    dia = "martes";
                    break;
                case 2:
                    dia = "miercoles";
                    break;
                case 3:
                    dia = "jueves";
                    break;
                case 4:
                    dia = "viernes";
                    break;
                case 5:
                    dia = "sabado";
                    break;
                case 6:
                    dia = "domingo";
                    break;
            }
            return dia;
        }

        //Temperatura mas alta de la semana elegida.
        public void TempMasAltaSemana()
        {
            Console.WriteLine("Elija la semana de la cual desee saber la temperatura mas alta: " +
                "\n1: Semana 1." +
                "\n2: Semana 2." +
                "\n3: Semana 3." +
                "\n4: Semana 4." +
                "\n5: Semana 5.");

            int semana = int.Parse(Console.ReadLine());
            int valorMayor = 0;
            string diaQueSeProdujo = "";
            for (int j = 0; j < matrizDiasMes.GetLength(1); j++)
            {
                if (matrizDiasMes[semana-1, j] > valorMayor)
                {
                    valorMayor = matrizDiasMes[semana-1, j];
                    diaQueSeProdujo = QueDiaEs(j);

                }
            }


            Console.WriteLine($"En la semana {semana}, la temperatura mayor encontrada fue de {valorMayor} y se produjo el {diaQueSeProdujo}");

        }

        //Temperatura mas alta del mes.
        public void TempMasAlta()
        {
            int valorMayor = 0;
            string diaQueSeProdujo = "";
            for(int i = 0; i < matrizDiasMes.GetLength(0); i++)
            {
                for(int j = 0; j< matrizDiasMes.GetLength(1); j++)
                {
                    if (matrizDiasMes[i,j] > valorMayor)
                    {
                        valorMayor = matrizDiasMes[i, j];
                        diaQueSeProdujo = QueDiaEs(j);
                        
                    }
                }
            }

            Console.WriteLine($"La temperatura mayor encontrada en el mes fue de {valorMayor} y se produjo un {diaQueSeProdujo}");
        }


        //Temperatura mas baja del mes
        public void TempMasBaja()
        {
            int valorMenor = 40;
            string diaQueSeProdujo = "";

            for (int i = 0; i < matrizDiasMes.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDiasMes.GetLength(1); j++)
                {
                    if (matrizDiasMes[i, j] < valorMenor)
                    {
                        valorMenor = matrizDiasMes[i, j];
                        diaQueSeProdujo = QueDiaEs(j);
                    }
                }
            }

            Console.WriteLine($"La temperatura menor encontrada en el mes fue de {valorMenor} y se produjo un {diaQueSeProdujo}");
        }

        //Promedio de temperaturas de la semana seleccionada.
        public double PromedioTemperaturasSemana()
        {
            Console.WriteLine("Elija la semana de la cual desee saber la temperatura promedio " +
                "\n1: Semana 1." +
                "\n2: Semana 2." +
                "\n3: Semana 3." +
                "\n4: Semana 4." +
                "\n5: Semana 5.");

            int semana = int.Parse(Console.ReadLine());
            double promedio = 0;
            double sumando = 0;

            for (int j = 0; j < matrizDiasMes.GetLength(1); j++)
            {
                sumando += matrizDiasMes[semana, j];
            }
            promedio = sumando / matrizDiasMes.GetLength(1);
            return promedio;
        }

        private void TablaMultiplicar()
        {
            for(int i = 1; i< matrizTablasMultiplicar.GetLength(0); i++)
            {
                for(int j = 0; j< matrizTablasMultiplicar.GetLength(1); j++)
                {
                    matrizTablasMultiplicar[i, j] = i * j;
                }
            }

        }

        public void MostrarTablaDeMultiplicar()
        {
            TablaMultiplicar();
            for (int i = 1; i < matrizTablasMultiplicar.GetLength(0); i++)
            {              
                for (int j = 0; j < matrizTablasMultiplicar.GetLength(1); j++)
                {
                    Console.Write(matrizTablasMultiplicar[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}

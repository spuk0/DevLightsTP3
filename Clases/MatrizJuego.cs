using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion3.Clases
{
    internal class MatrizJuego
    {
        public string[,] matriz = new string[10, 10];
        private static Random random = new Random();
        public MatrizJuego()
        {
            MatrizGuia();
        }

        private int CompletarValoresAlAzar()
        {
            var seed = Environment.TickCount;
            var randomCantidad = new Random(seed);
            var randomI = new Random(seed);
            var randomJ = new Random();
            var cantidad = new Random();
            int lugaresDisponibles = matriz.GetLength(0) / 2;
            int cantidadDeX = cantidad.Next(1, lugaresDisponibles);

            for(int i = 0; i<cantidadDeX; i++)
            {
                var valueI = randomI.Next(0, lugaresDisponibles);
                var valueJ = randomJ.Next(0, lugaresDisponibles);
                matriz[valueI, valueJ] = "x";
            }

            return cantidadDeX;
        }

        private void MatrizGuia()
        {
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = $"[{i}-{j}]";
                }
            }
        }

        private void MatrizAsteriscos()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = "*";
                }
            }
        }

        public void MostrarMatriz()
        {

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void Play()
        {
            MostrarMatriz();
            MatrizAsteriscos();
            byte intentos = 0;
            byte aciertos = 0;
            var cantidadDeX = CompletarValoresAlAzar();
            int coordenadaI = 0;
            int coordenadaJ = 0;
            Console.WriteLine($"Se escondieron {cantidadDeX} 'x' en la matriz de arriba, la cual esta ordenada con el formato [i-j].\nIngresar las posiciones de I y de J para intentar encontrar las X." +
                "\nCoordenada de I: ");
            coordenadaI = int.Parse(Console.ReadLine());
            Console.WriteLine("Coordenada de J: ");
            coordenadaJ = int.Parse(Console.ReadLine());

            while (intentos < 3 && aciertos < cantidadDeX - 1)
            {
                if (matriz[coordenadaI, coordenadaJ] == "x")
                {
                    aciertos++;
                    Console.WriteLine($"¡Bien!, te faltan {cantidadDeX - aciertos}");
                    Console.WriteLine("Sigamos. Ingresar coordenada en I:");
                    coordenadaI = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresar coordenada en J: ");
                    coordenadaJ = int.Parse(Console.ReadLine());
                }
                else
                {
                    intentos++;
                    Console.WriteLine($"Equivocado, pero no te rindas, te quedan {intentos}/3 intentos");
                    Console.WriteLine("Sigamos. Ingresar coordenada en I:");
                    coordenadaI = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresar coordenada en J: ");
                    coordenadaJ = int.Parse(Console.ReadLine());
                }
            }
            if (intentos == 3) { Console.WriteLine("¡Perdiste!, aqui las verdaderas ubicaciones"); }
            if (aciertos == cantidadDeX) { Console.WriteLine("¡Ganaste!, mira la tabla"); }
            MostrarMatriz();
        }

    }
}

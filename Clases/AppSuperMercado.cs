using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion3.Clases
{
    internal class AppSuperMercado
    {
        public List <ProductoMercado> ListaDeCompras { get; set; }

        //Constructor que recibe una lista.
        public AppSuperMercado(List<ProductoMercado> listaDeCompras)
        {
            ListaDeCompras = listaDeCompras;
        }

        public AppSuperMercado(ProductoMercado producto)
        {
            ListaDeCompras = new List<ProductoMercado>();
            ListaDeCompras.Add(producto);
        }

        //Constructor que no recibe nada
        public AppSuperMercado()
        {
            ListaDeCompras = new List<ProductoMercado>();
            ProductoMercado listaVacia = new ProductoMercado("Lista vacia");
            ListaDeCompras.Add(listaVacia);
        }

        public void AgregarProductoALista(ProductoMercado elemento)
        {
            ListaDeCompras.Add(elemento);
            Console.WriteLine($"Se agrego ´{elemento.NombreProducto}´ a la lista");
        }

        public void RemoverElemento(ProductoMercado elemento)
        {
            Console.WriteLine($"Se removio ´{elemento.NombreProducto}´");
            ListaDeCompras.Remove(elemento);
            
        }

        public void Comprar()
        {
            Console.WriteLine("Escribir nombre del producto a comprar");
            string nombre = Console.ReadLine();
            bool estaEnLista = false;

            foreach (ProductoMercado elemento in ListaDeCompras)
            {
                if (elemento.NombreProducto == nombre)
                {
                    elemento.Comprado = true;
                    estaEnLista = true;
                    Console.WriteLine($"Compraste {elemento.NombreProducto}");
                    break;
                }             
            }

            if (!estaEnLista)
            {
                Console.WriteLine($"´{nombre}´ no esta en la lista.");
                AgregarProductoALista(new ProductoMercado(nombre));
                Comprar();
            }
        }

        public void MostrarLista()
        {
            foreach(ProductoMercado elemento in ListaDeCompras)
            {
                if (elemento.Comprado)
                {
                    Console.WriteLine(elemento.NombreProducto + ". -Comprado");
                }
                else
                {
                    Console.WriteLine(elemento.NombreProducto + ". -Falta comprar");
                }
            }
        }




    }
}

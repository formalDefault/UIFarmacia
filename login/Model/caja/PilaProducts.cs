using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Model.caja
{
     public static class PilaProducts 
    {
        private static varCaja topStack = new varCaja();
        private static varCaja topStackCantidades = new varCaja();

        static PilaProducts()
        {
            topStack = null;
            topStackCantidades = null;
        }

        //pila de ids de productos
        public static Boolean Push(int id)
        {
            varCaja Nuevo = new varCaja();
            bool verificacion = seeStack().Any(x => x == id);
            if(!verificacion)
            {
                Nuevo.StackIdProduct = id; 
                Nuevo.siguiente = topStack;
                topStack = Nuevo;
                return true;
            }
            else
            {
                MessageBox.Show("Id existente");
                return false;
            }
            
        }

        public static List<int> seeStack()
        {
            varCaja actual = new varCaja();
            actual = topStack;
            List<int> lista = new List<int>();    

            if(topStack != null)
            {
                while (actual != null)
                { 
                    lista.Add(actual.StackIdProduct);
                    actual = actual.siguiente;
                }
            }
            //else
            //{
            //    MessageBox.Show("La pila esta vacia");
            //}
            return lista;
        }

        public static void popStack(int idProduct)
        {
            varCaja actual = new varCaja();
            actual = topStack;  
            varCaja anterior = new varCaja();
            anterior = null;
            bool encontrado = false;
            int idToDelete = idProduct;
            if (topStack != null)
            {
                while (actual != null && encontrado != true)
                { 
                    if (actual.StackIdProduct == idToDelete)
                    {
                        if (actual == topStack)
                        {
                            topStack = topStack.siguiente;
                        }
                        else
                        {
                            anterior.siguiente = actual.siguiente;
                        }
                        //MessageBox.Show("Producto eliminado del carrito"); //quitar
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.siguiente;
                } 
                if (!encontrado)
                {
                    MessageBox.Show("Error: El id: "+idProduct+" no esta en la pila");
                }
            }
            else
            {
                MessageBox.Show("Error: La pila esta vacia");
            }
        }


        //pila de cantidades de productos
        public static Boolean PushCantidad(int id)
        {
            varCaja NuevoCantidad = new varCaja();
            bool verificacion = seeStackCantidades().Any(x => x == id);
            if (!verificacion)
            {
                NuevoCantidad.StackCantidad = id;
                NuevoCantidad.siguienteCantidad = topStackCantidades;
                topStackCantidades = NuevoCantidad;
                return true;
            }
            else
            {
                MessageBox.Show("Id existente");
                return false;
            } 
        }

        public static List<int> seeStackCantidades()
        {
            varCaja cantidadActual = new varCaja();
            cantidadActual = topStackCantidades;
            List<int> listaCantidades = new List<int>();

            if (topStack != null)
            {
                while (cantidadActual != null)
                {
                    listaCantidades.Add(cantidadActual.StackCantidad);
                    cantidadActual = cantidadActual.siguienteCantidad;
                }
            } 
            return listaCantidades;
        }
         
        public static void popStackCantidades(int idProduct)
        {
            varCaja cantidadActual = new varCaja();
            cantidadActual = topStackCantidades;
            varCaja cantidadAnterior = new varCaja();
            cantidadAnterior = null;
            bool encontrado = false;
            int idToDelete = idProduct;
            if (topStackCantidades != null)
            {
                while (cantidadActual != null && encontrado != true)
                {
                    if (cantidadActual.StackCantidad == idToDelete)
                    {
                        if (cantidadActual == topStackCantidades)
                        {
                            topStackCantidades = topStackCantidades.siguienteCantidad;
                        }
                        else
                        {
                            cantidadAnterior.siguienteCantidad = cantidadActual.siguienteCantidad;
                        }
                        //MessageBox.Show("Producto eliminado del carrito"); //quitar
                        encontrado = true;
                    }
                    cantidadAnterior = cantidadActual;
                    cantidadActual = cantidadActual.siguienteCantidad;
                }
                if (!encontrado)
                {
                    MessageBox.Show("Error: El id: " + idProduct + " no esta en la pila");
                }
            }
            else
            {
                MessageBox.Show("Error: La pila esta vacia");
            }
        }

    }
}

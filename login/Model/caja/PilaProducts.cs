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

        static PilaProducts()
        {
            topStack = null; 
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
                //MessageBox.Show("Id existente"); //quitar
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
         
         
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Model.caja
{
    class PilaProducts
    {
        private varCaja topStack = new varCaja();
        
        public PilaProducts()
        {
            topStack = null;
        }

        public void Push(int id)
        {
            varCaja stack = new varCaja();
            stack.StackIdProduct = id;
            stack.StackNext = null;
            topStack = stack;
        }

        public void seeStack()
        {
            varCaja stack = new varCaja();
            stack = topStack;

            if(topStack != null)
            {
                while(stack != null)
                {
                    MessageBox.Show("id de producto: " + stack.StackIdProduct);
                    stack = stack.StackNext;
                }
            }
            else
            {
                MessageBox.Show("La pila esta vacia");
            }
        }

        public void popStack(int idProduct)
        {
            varCaja actual = new varCaja();
            actual = topStack;  
            varCaja anterior = new varCaja();
            anterior = topStack;
            bool encontrado = false;
            int idToDelete = idProduct;
            if(topStack != null)
            {
                while (actual != null && encontrado != true)
                {
                    if(actual.StackIdProduct == idToDelete)
                    {
                        if(actual == topStack)
                        {
                            topStack = topStack.StackNext;
                        }
                        else
                        {
                            anterior.StackNext = actual.StackNext;
                        }
                        MessageBox.Show("Producto eliminado del carrito");
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.StackNext;  
                }
                if (!encontrado)
                {
                    MessageBox.Show("Error: El id no esta en la pila");
                }
            }
            else
            {
                MessageBox.Show("Error: La pila esta vacia");
            }
        }
    }
}

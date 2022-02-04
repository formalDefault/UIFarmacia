using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace login.Model.inventario
{
    class varInventario
    {
        private static int idCompra;
        private static Stack<int> idEntradas = new Stack<int>();
        private static Stack<int> idproductos = new Stack<int>();

        public int IdCompra { get => idCompra; set => idCompra = value; }

        //funciones de la pila idEntradas
        public void pushStackEntradas(int setId) { idEntradas.Push(setId); }

        public void popStackEntradas() { idEntradas.Pop(); }

        public int peekStackEntradas() { return idEntradas.Peek(); }
          
        public int countStackEntradas() { return idEntradas.Count; }

        //funciones de la pila idProductos
        public void pushStackProductos(int setId) { idproductos.Push(setId); }

        public void popStackProductos() { idproductos.Pop(); }

        public int peekStackProductos() { return idproductos.Peek(); }
          
        public int countStackProductos() { return idproductos.Count; }

    }
}

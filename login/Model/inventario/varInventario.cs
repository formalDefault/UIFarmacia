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

        public int IdCompra { get => idCompra; set => idCompra = value; }

        public void pushStack(int setId) { idEntradas.Push(setId); }

        public void popStack() { idEntradas.Pop(); }

        public int peekStack() { return idEntradas.Peek(); }
          
        public int countStack() { return idEntradas.Count; }

    }
}

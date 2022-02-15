namespace login.Model.caja
{
    public class varCaja
    { 
        private static int idVenta;
        

        public int IdVenta { get => idVenta; set => idVenta = value; }


        //funciones de la pila idProductos
        private int stackIdProduct;
        private varCaja stackNext;

        public int StackIdProduct { get => stackIdProduct; set => stackIdProduct = value; }
        public varCaja siguiente { get => stackNext; set => stackNext = value; }

        //funciones de la pila cantidad de producto
        private int stackCantidad;
        private varCaja stackCantidaNext;

        public int StackCantidad { get => stackCantidad; set => stackCantidad = value; }
        public varCaja siguienteCantidad { get => stackCantidaNext; set => stackCantidaNext = value; }
         

        //funciones de la pila salidas
        private static Stack<int> idSalidas = new Stack<int>();

        public void pushStackSalidas(int setId) { idSalidas.Push(setId); }

        public void popStackSalidas() { idSalidas.Pop(); }

        public int peekStackSalidas() { return idSalidas.Peek(); }

        public int countStackSalidas() { return idSalidas.Count; }

    }
}

namespace login.Model.caja
{
    public class varCaja
    { 
        private static int idVenta;
        private int stackIdProduct;
        private varCaja stackNext;
        private static Stack<int> idSalidas = new Stack<int>();

        public int IdVenta { get => idVenta; set => idVenta = value; }   
        public int StackIdProduct { get => stackIdProduct; set => stackIdProduct = value; }
        public varCaja siguiente { get => stackNext; set => stackNext = value; }

        //funciones de la pila idProductos
        public void pushStackSalidas(int setId) { idSalidas.Push(setId); }

        public void popStackSalidas() { idSalidas.Pop(); }

        public int peekStackSalidas() { return idSalidas.Peek(); }

        public int countStackSalidas() { return idSalidas.Count; }

    }
}

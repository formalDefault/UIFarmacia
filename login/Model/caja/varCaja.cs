namespace login.Model.caja
{
    public class varCaja
    {
        private int stackIdProduct;
        private varCaja stackNext;
        private static int idVenta;


        public int StackIdProduct { get => stackIdProduct; set => stackIdProduct = value; }
        public varCaja StackNext { get => stackNext; set => stackNext = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Model.caja
{
    public class varCaja
    {
        private static int id;
        private static int codigo;
        private static String nombre = "";
        private static String descripcion = "";
        private static int costo;
        private static int retail;
        private static int mayoreo;
        private static String categoria = "";
        private static int periodoDevolucion_dias;

        public int Id { get => id; set => id = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Descripcion { get => descripcion; set => descripcion = value; }
        public int Costo { get => costo; set => costo = value; }
        public int Retail { get => retail; set => retail = value; }
        public int Mayoreo { get => mayoreo; set => mayoreo = value; }
        public String Categoria { get => categoria; set => categoria = value; }
        public int PeriodoDevolucion_dias { get => periodoDevolucion_dias; set => periodoDevolucion_dias = value; }
    }
}

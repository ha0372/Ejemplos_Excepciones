using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploI_Suma.Operacion
{
    class OperacionSuma
    {
        private Double dato1;
        private Double dato2;

        public double Dato1 { get => dato1; set => dato1 = value; }
        public double Dato2 { get => dato2; set => dato2 = value; }

        public Double suma()
        {
            Double total = Dato1 + Dato2;

            return total;
        }
    }
}

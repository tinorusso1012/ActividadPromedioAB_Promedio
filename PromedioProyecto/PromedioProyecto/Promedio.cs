using System;
using System.Threading.Tasks;

namespace PromedioProyecto
{
    class Promedio
    {
        int cont;
        double acumulador;
        public Promedio()
        {
            this.cont = 0;
            this.acumulador = 0;
        }

        public void AcumularNumero(double num)
        {
            
            this.acumulador += num;
            cont++;
            
            
        }

        public double CalcularPromedio()
        {
            double resultado = 0;
            if (cont > 0)
            {
                resultado = this.acumulador / this.cont;
            }
            return resultado;
        }
    }
}

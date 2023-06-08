using System;
using PromedioProyecto;

namespace PromedioProyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            Promedio miPromedio = new Promedio();

            Console.WriteLine("Bienvenido al ejercicio Promedio :D\n");

            Console.WriteLine("Elija una de las siguientes Opciones: \n");
            bool verificar = true;
            while (verificar)
            {
                Console.WriteLine("1- Ingresar un numero \n");

                Console.WriteLine("2- Mostrar Promedio \n");

                Console.WriteLine("3- Terminar Programa \n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingresa un numero: \n");
                        double numero = Convert.ToDouble(Console.ReadLine());
                        miPromedio.AcumularNumero(numero);
                        Console.WriteLine("Numero Acumulado con exito \n");
                        Console.WriteLine("Presiona una tecla para volver al Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        double promedio = miPromedio.CalcularPromedio();
                        Console.WriteLine("El Promedio Actual es de: {0} \n", promedio);
                        Console.WriteLine("Presiona una tecla para volver al Menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3: verificar = false;
                        break;
                    default:
                        Console.WriteLine("Ingreso un Valor Incorrecto sera redirigido al Menu Principal: \n");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                
            }

        }
    }
}

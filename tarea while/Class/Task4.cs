


using System.Threading;

namespace tarea_while.Class
{
    public class Task4
    {
        public void tarea4()
        {
            Console.Write("Ingrese la cantidad de empleados: ");
            int cantidadEmpleados = Convert.ToInt32(Console.ReadLine());

            int sueldos100a300 = 0;
            int sueldosMas300 = 0;
            int totalSueldos = 0;

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.Write($"Ingrese el sueldo del empleado {i + 1}: ");
                int sueldo = Convert.ToInt32(Console.ReadLine());

                totalSueldos += sueldo;

                if (sueldo >= 100 && sueldo <= 300)
                {
                    sueldos100a300++;
                }
                else if (sueldo > 300)
                {
                    sueldosMas300++;
                }
            }

            Console.WriteLine($"Cantidad de empleados que cobran entre $100 y $300: {sueldos100a300}");
            Console.WriteLine($"Cantidad de empleados que cobran más de $300: {sueldosMas300}");
            Console.WriteLine($"Importe total que la empresa gasta en sueldos: ${totalSueldos}");
        }
    }
   




    }


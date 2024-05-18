
namespace tarea_while.Class
{
    public class Task2
    {
        public void tarea2()
        {
            Console.Write("Ingrese la cantidad de piezas a procesar: ");
            int cantidadPiezas = Convert.ToInt32(Console.ReadLine());

            int piezasAptas = 0;

            for (int i = 0; i < cantidadPiezas; i++)
            {
                Console.Write($"Ingrese la longitud de la pieza {i + 1}: ");
                double longitud = Convert.ToDouble(Console.ReadLine());

                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    piezasAptas++;
                }
            }

            Console.WriteLine($"La cantidad de piezas aptas es: {piezasAptas}");
        }
    }
}


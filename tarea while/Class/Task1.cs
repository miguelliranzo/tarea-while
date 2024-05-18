

namespace tarea_while.Class
{
    public class Task1
    {
        public void tarea1() {

            int cantidadValores = 10;
            int suma = 0;

            Console.WriteLine("Ingrese 10 valores:");

            for (int i = 0; i < cantidadValores; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                suma += valor;
            }

            double promedio = (double)suma / cantidadValores;

            Console.WriteLine($"La suma de los valores ingresados es: {suma}");
            Console.WriteLine($"El promedio de los valores ingresados es: {promedio}");



        }
    }
}

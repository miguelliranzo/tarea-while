

namespace tarea_while.Class
{
    public class Task3
    {
        public void tarea3()
        {
            int cantidadAlumnos = 10;
            int notasMayoresOIgualesA7 = 0;
            int notasMenoresA7 = 0;

            Console.WriteLine("Ingrese las notas de 10 alumnos:");

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.Write($"Nota del alumno {i + 1}: ");
                int nota = Convert.ToInt32(Console.ReadLine());

                if (nota >= 7)
                {
                    notasMayoresOIgualesA7++;
                }
                else
                {
                    notasMenoresA7++;
                }
            }

            Console.WriteLine($"Cantidad de alumnos con notas mayores o iguales a 7: {notasMayoresOIgualesA7}");
            Console.WriteLine($"Cantidad de alumnos con notas menores a 7: {notasMenoresA7}");
        }
    }
}


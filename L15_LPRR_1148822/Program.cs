using System;

class Program
{
    static void Main()
    {
        string opcion;

        Console.WriteLine("Un gusto tenerlo de nuevo, seleccione una opcion: ");
        Console.WriteLine("Presione 1 Nombres y edades de personas");
        Console.WriteLine("Presione 2 Notas de estudiantes");
        Console.WriteLine("Presione 3 salir");

        opcion = Console.ReadLine();
        switch (opcion)
        {
            case "1":
                string[] nombres = new string[5];
                double[] edad = new double[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese los nombres de la personas");
                    nombres[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad de las personas");
                    edad[i] = int.Parse(Console.ReadLine());
                }
                double mayor = 0;
                int Verdadero = 0;
                string permayor = "";
                for (int i = 0; i < 5; i++)
                {
                    if (mayor < edad[i])
                    {
                        mayor = edad[i];
                        Verdadero = i + 1;
                        permayor = nombres[i];

                    }
                }
                Console.WriteLine("La persona de mayor edad es: " + permayor);
                double promedio = 0;
                double sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum + edad[i];
                }

                promedio = sum / 5;
                Console.WriteLine("El promedio de edades es " + promedio);
                break;

            case "2":
                string[] nombres2 = new string[5];
                double[] notas = new double[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese los nombres y apellidos de las personas");
                    nombres2[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese las notas de las personas");
                    notas[i] = double.Parse(Console.ReadLine());
                }

                for (int i = 0; i < 5; i++)
                {
                    if (notas[i] >= 71)
                    {
                        Console.WriteLine(nombres2[i] + " gano la clase con " + notas[i] + " puntos ");
                    }
                    else
                    {
                        Console.WriteLine(nombres2[i] + " perdio la clase con " + notas[i] + " puntos ");
                    }
                }
                double Mayor = 0;
                int Verdadero2 = 0;
                string Mejor = "";
                for (int i = 0; i < 5; i++)
                {
                    if (Mayor < notas[i])
                    {
                        Mayor = notas[i];
                        Verdadero2 = i + 1;
                        Mejor = nombres2[i];

                    }
                }
                Console.WriteLine("La mejor nota es de " + Mejor);

                double Mayor2 = 0;
                int Verdadero3 = 0;
                string Mejor2 = "";
                for (int i = 0; i < 5; i++)
                {
                    if (Mayor2 > notas[i])
                    {
                        Mayor2 = notas[i];
                        Verdadero3 = i + 1;
                        Mejor2 = nombres2[i];

                    }
                }
                Console.WriteLine("La peor nota es de: " + Mejor2);

                double promedio2 = 0;
                double sum2 = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum2 = sum2 + notas[i];
                }

                promedio2 = sum2 / 5;
                Console.WriteLine("El promedio de las notas es " + promedio2);
                break;
            case "3":
                {
                    Console.WriteLine("Esperamos verte pronto :)");
                    Environment.Exit(0);
                    break;
                }
            default:
                Console.WriteLine("ERROR :/");
                break;
        }
    }
}

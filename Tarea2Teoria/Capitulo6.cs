
namespace Tarea2
{
    public class Capituloc6
    {
        private int[][] jagged = new int[3][];

        public static void RellenarArreglo(int [][] arreglo)
        {
            arreglo[0] = new int[] { 9, 3, 1, 7, 2, 4 };
            arreglo[1] = new int[] { 2, 9 };
            arreglo[2] = new int[] { 3, 5, 2, 9 };
        }

        public static void Imprimir(int[][] arreglo)
        {
            for (int n = 0; n < 3; n++)
            {
                Console.WriteLine("Array {0}", n + 1);
                for (int m = 0; m < arreglo[n].GetLength(0); m++)
                {
                    Console.WriteLine("Posicion {0}: {1} ", m + 1, arreglo[n][m]);
                }
            }
        }

        public void Ejercicio5()
        {
            RellenarArreglo(jagged);
            Imprimir(jagged);
        }

        public static void Ejercicio1()
        {
            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m= 0;
            string valor = "";
            float suma = 0.0f;
            float promedio = 0.0f;
  

            Console.Write("Dame la cantidad de salones: ");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            float[][] califi = new float[salones][];

            for(n = 0; n < salones; n++)
            {
                Console.Write("Damme la cantidad de alumnos para el salon {0}: ",n+1);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
                califi[n] = new float[cantidad];
            }

            for(n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n+1);
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    Console.Write("Dame la calificacion: ");
                    valor = Console.ReadLine();
                    califi[n][m] = Convert.ToSingle(valor);
                }
            }

            Console.WriteLine("--Informacion--");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n+1);
                for(m = 0; m < califi[n].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m + 1, califi[n][m]);
                }
            }

            cantidad = 0;
            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    suma += califi[n][m];
                    cantidad++;
                }
            }
            promedio = suma / (cantidad);
            Console.WriteLine("El promedio es: {0}", promedio);
        }

        public static void Ejercicio2()
        {
            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m = 0;
            string valor = "";
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;

            Console.Write("Dame la cantidad de salones: ");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            float[][] califi = new float[salones][];

            for (n = 0; n < salones; n++)
            {
                Console.Write("Damme la cantidad de alumnos para el salon {0}: ", n + 1);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
                califi[n] = new float[cantidad];
            }

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n + 1);
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    Console.Write("Dame la calificacion: ");
                    valor = Console.ReadLine();
                    califi[n][m] = Convert.ToSingle(valor);
                }
            }

            Console.WriteLine("--Informacion--");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n + 1);
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m + 1, califi[n][m]);
                }
            }

            cantidad = 0;
            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    suma += califi[n][m];
                    cantidad++;
                }
            }
            promedio = suma / (cantidad);
            Console.WriteLine("El promedio es: {0}",promedio);

            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    if (califi[n][m] < minima)
                        minima = califi[n][m];
                }
            }

            Console.WriteLine("La calificacion minima es: {0}", minima);
        }

        public static void Ejercicio3()
        {
            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m = 0;
            string valor = "";
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;

            Console.Write("Dame la cantidad de salones: ");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            float[][] califi = new float[salones][];

            for (n = 0; n < salones; n++)
            {
                Console.Write("Damme la cantidad de alumnos para el salon {0}: ", n + 1);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
                califi[n] = new float[cantidad];
            }

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n + 1);
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    Console.Write("Dame la calificacion: ");
                    valor = Console.ReadLine();
                    califi[n][m] = Convert.ToSingle(valor);
                }
            }

            Console.WriteLine("--Informacion--");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n + 1);
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m + 1, califi[n][m]);
                }
                
            }

            cantidad = 0;
            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    suma += califi[n][m];
                    cantidad++;
                }
            }
            promedio = suma / (cantidad);

            Console.WriteLine("El promedio es: {0}", promedio);

            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    if (califi[n][m] < minima)
                        minima = califi[n][m];
                }
            }

            Console.WriteLine("La calificacion minima es: {0}", minima);

            for (n = 0; n < salones; n++) 
            {
                for (m = 0; m < califi[n].GetLength(0); m++)
                {
                    if (califi[n][m] > maxima)
                        maxima = califi[n][m];
                }
            }

            Console.WriteLine("La calificacion maxima es: {0}",maxima);
        }
    }
}

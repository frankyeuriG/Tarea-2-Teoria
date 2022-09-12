
using System.Collections;

namespace Tarea2
{
   public class Capituloc7
    {
        public static void Ejercicio1()
        {
            ArrayList lista = new ArrayList();

            int cantidad = 0;
            float calificacion = 0;
            string valor = "";
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 100.0f;
            float maxima = 0.0f;

            Console.Write("Dame la cantidad de alumnos: ");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            for (int n = 0; n < cantidad; n++)
            {
                Console.Write("Dame la calificacion del alummno {0}: ", n + 1);
                valor = Console.ReadLine();
                calificacion = Convert.ToInt32(valor);
                lista.Add(calificacion);
            }

            Console.WriteLine("--Calificaciones--");
            for (int m = 0; m < lista.Count; m++)
            {
                Console.WriteLine("Calificacion {0}: {1}", lista.IndexOf(lista[m])+1, lista[m]);
            }

            cantidad = 0;
            for (int m = 0; m < lista.Count ; m++)
            {
                suma += (float)lista[m];
            }
            promedio = suma / (lista.Count);
            Console.WriteLine("El promedio es: {0}", promedio);

            for (int n = 0; n < lista.Count; n++)
            {
                if ((float)lista[n] < minima)
                    minima = (float)lista[n];
            }

            Console.WriteLine("La calificacion minima es: {0}", minima);

            for (int n = 0; n < lista.Count; n++)
            {
                if ((float)lista[n] > maxima)
                    maxima = (float)lista[n];
            }

            Console.WriteLine("La calificacion maxima es: {0}", maxima);
        }

        public static void Ejercicio2()
        {
            Hashtable miTabla = new Hashtable();

            string palabra = "";
            string definicion = "";
            int opcion = 0;
            string valor = "";

            do
            {
                Console.Clear();
                Console.WriteLine("1. Agregar palabra");
                Console.WriteLine("2. Buscar palabra");
                Console.WriteLine("3. Sair");
                Console.Write("Opcion: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1)
                {
                    Console.Write("Digite el nombre de la palabra: ");
                    palabra = Console.ReadLine();
                    Console.Write("Digite el Siginificado de la palabra: ");
                    definicion = Console.ReadLine();

                    miTabla.Add(palabra, definicion);
                }

                if (opcion == 2)
                {
                    bool existe = false;
                    Console.Write("Digite el nombre de la palabra que desea buscar: ");
                    palabra = Console.ReadLine();

                    existe = miTabla.Contains(palabra);

                    if (existe == true)
                    {
                        Console.WriteLine("Palabra: {1}\nDefinicion: {0}", (string)miTabla[palabra], palabra);
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("La palabra no existe!");
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadLine();
                    }

                }
            } while (opcion != 3);
        }

        public static void Ejercicio5()
        {
            Hashtable miTabla = new Hashtable();

            string nombre = "";
            string telefono = "";
            int opcion = 0;
            string valor = "";

            do
            {
                Console.Clear();
                Console.WriteLine("1. Agregar Contacto");
                Console.WriteLine("2. Buscar Contacto");
                Console.WriteLine("3. Sair");
                Console.Write("Opcion: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1)
                {
                    Console.Write("Digite el nombre del contacto: ");
                    nombre = Console.ReadLine();
                    Console.Write("Digite el telefono del contacto: ");
                    telefono = Console.ReadLine();

                    miTabla.Add(nombre, telefono);
                }

                if (opcion == 2)
                {
                    bool existe = false;
                    Console.Write("Digite el nombre del contacto que desea buscar: ");
                    nombre = Console.ReadLine();

                    existe = miTabla.Contains(nombre);

                    if (existe == true)
                    {
                        Console.WriteLine("Nombre: {1}\nTelefono: {0}", (string)miTabla[nombre], nombre);
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("El contacto no existe!");
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadLine();
                    }

                }
            } while (opcion != 3);
        }
    }
}

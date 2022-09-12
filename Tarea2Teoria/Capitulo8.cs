
namespace Tarea2
{
    public class Capituloc8
    {
       public static void Ejercicio3()
        {
            DateTime fechayHora = DateTime.Now;
            String formato = String.Format("La Fecha es: {0:hh:mm:ss tt yyyy/dd/MMMM}",fechayHora);
            Console.WriteLine(formato);
        }

        public static void Ejercicio5()
        {
            String cadena1 = "";
            String cadena2 = "";
            int comparacion = 0;

            Console.Write("Digite la primera cadena: ");
            cadena1 = Console.ReadLine();
            Console.Write("Digite la segunda cadena: ");
            cadena2 = Console.ReadLine();

            comparacion = string.Compare(cadena1, cadena2);

            if (comparacion == 0)
                Console.WriteLine(cadena1 + "\n" + cadena2);
            if(comparacion > 0)
                Console.WriteLine(cadena2 + "\n" + cadena1);
            if (comparacion < 0)
                Console.WriteLine(cadena1 + "\n" + cadena2);
        }
    }
}

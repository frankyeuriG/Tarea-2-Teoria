using System;
using Humanizer;


namespace Tarea2{
    public class Program{
        static void Main(string [] args){
            int option = 0;
            Capituloc6 a = new Capituloc6();
            Capituloc7 b = new Capituloc7();
            Capituloc8 c = new Capituloc8();

            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("1-Ejerciocio(4) capitulo 5:");
            Console.WriteLine("2-Ejercicio(5) Capitulo 5:");
            Console.WriteLine("3-Ejercicio(1) Capitulo 6 :");
            Console.WriteLine("4-Ejercicio(2) Capitulo 6 :");
            Console.WriteLine("5-Ejercicio(3) Capitulo 6 :");
            Console.WriteLine("6-Ejercicio(1) Capitulo 7 :");
            Console.WriteLine("7-Ejercicio(2) Capitulo 7 :");
            Console.WriteLine("8-Ejercicio(5) Capitulo 7 :");
            Console.WriteLine("9-Ejercicio(3) Capitulo 8 :");
            Console.WriteLine("10-Ejercicio(5) Capitulo 8 :");
            option = int.Parse(Console.ReadLine());

           switch(option){
            case 1:
                int n = 5;
                    int resultado = 0;
                    resultado = factorial(n);
               Console.WriteLine("El facorial de n es {0}", resultado);
            break;
            case 2:
                cadena();
            break;
            case 3:
                Capituloc6.Ejercicio1();
            break;
            case 4:
                Capituloc6.Ejercicio2();
            break;
            case 5:
                Capituloc6.Ejercicio3();
            break;
            case 6:
                Capituloc7.Ejercicio1(); 
            break;
            case 7:
                Capituloc7.Ejercicio2(); 
            break;
            case 8:
                Capituloc7.Ejercicio5(); 
            break;
            case 9:
                Capituloc8.Ejercicio3(); 
            break;
            case 10:
                Capituloc8.Ejercicio5(); 
            break;
            default :
                Console.WriteLine("EREOR...");
            break;

           }
           
        }



        static int factorial(int n){
            if(n <= 1){
                return 1;
            }else {
                return n * factorial(n-1);
            } 

        }
         static void cadena(){
            Console.WriteLine("Introduzca número:");
            var input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine(Int32.TryParse(input, out var number)
                    ? $"{number.ToWords()}"
                    : $"No se reconoce el número {input}");
                Console.WriteLine("Introduzca número:");
                input = Console.ReadLine();
            }
     }

 } 

}
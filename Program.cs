using System;
using System.Diagnostics.Tracing;

namespace PrimeraAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DIA DOS SINTAXIS III DECLARACION DE VARIABLES
            //la suma de dos numeros
            int sum1, sum2;
            sum1 = 300;
            sum2 = 4333;
            sum1 = 667;
            int resultado = sum1 + sum2;
            Console.WriteLine(+sum1 + " + " + sum2 + " = " + resultado);
            Console.WriteLine("Me encanta tu culo"); /*esto se imprime en consola*/
            Console.WriteLine(26 % 9);

            //DIA 3. SINTAXIS BASICA IV
            //Utilizando el operador "=" para iniciar varias variables
            int edad1, edad2, edad3;
            edad1 = edad2 = edad3 = 19;

            Console.WriteLine($"Hamel, Luis y Juan tienen {edad1}");

            //Declaracion implicita de variables

            var miNombre = "Hamel el mas psicopata";
            var miEdad = 19;
            var genero = "Masculino";
            miNombre = "Hamel";

            Console.WriteLine($"Mi nombre es {miNombre}, tengo {miEdad} años de edad y soy de genero {genero}.");

            //Conversion explicita

            double peso1 = 115.129;
            int peso2;

            peso2 = (int)peso1;

            Console.WriteLine($"Hamel pesa {peso2} libras");

            //Conversion implicita

            long ahorros = 200000;
            float ahorros2023 = ahorros;

            Console.WriteLine("Tu ahorros en el 2023 fue de " + ahorros2023);


            /* Conversión de texto a número
             * Introducción de datos por consola*/

            //La suma de dos numeros enteros

            Console.WriteLine(); //Linea en blanco
            Console.WriteLine("La suma de dos numeros enteros");
            Console.WriteLine($"Introduce un número:");
            int suma1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduce el segundo numero");
            int suma2 = int.Parse(Console.ReadLine());

            int resultado2 = suma1 + suma2;

            Console.WriteLine(suma1 + " + " + suma2 + " = " + resultado2);

            //La division de dos numeros reales
            Console.WriteLine();
            Console.WriteLine("Division de dos números");
            Console.WriteLine("Ingresa el primer numero");
            double div1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero");
            double div2 = double.Parse(Console.ReadLine());

            double res1 = div1 / div2;

            Console.WriteLine($"El resultado de la division es {res1}");

            //El resto de una division
            Console.WriteLine();
            Console.WriteLine("Resto de una division");
            Console.WriteLine("Ingrese el primer número");
            int rest1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            int rest2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resto de la divison division es {(rest1 % rest2)}");

            //Declaracion de constantes
            Console.WriteLine();
            const String FECHA_N = "22/09/2004";
            Console.WriteLine($"Hamel nació el {FECHA_N}");

            //Pedir al usuario que calcule el radio de un circulo

            Console.WriteLine();

            Console.WriteLine("Ingrese la circunferencia del circulo");
            double cir = double.Parse(Console.ReadLine());

            const double PI = 3.1416;

            double radio = cir / (2 * PI);

            Console.WriteLine("El radio del circulo es " + radio);

            //Metodo Math para elevar un numero
            Console.WriteLine();
            Console.WriteLine("POTENCIA");

            Console.WriteLine("Ingresa la base");
            int nume1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingreasa el exponente");
            int nume2 = int.Parse(Console.ReadLine());

            int resultadoP = (int)Math.Pow(nume1, nume2);
            Console.WriteLine($"Esa potencia es igual a {resultadoP}");

            //El area de un Circulo
            Console.WriteLine("\nCalcular el area de un circulo");
            const double PI_2 = 3.1416;

            Console.WriteLine("Ingrese el radio del circulo");
            double radio_2 = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio_2, 2) * PI_2;

            Console.WriteLine("El area de circulo es: " + area);

        }
    }
}

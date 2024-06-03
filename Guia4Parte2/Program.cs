using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Sumar Numeros 
             * Objetivo: El programa debe permitir al usuario ingresar numeros enteros uno por uno
             * y sumar dichos numeros hasta que el usuario decida detenerse.
            */
            /*
            int valor, suma = 0;
            do
            {
                Console.WriteLine("Ingrese un numero en entero(0 para finalizar)");
                valor = int.Parse(Console.ReadLine());
                suma = suma + valor;
            }
            while (valor != 0);
            Console.WriteLine($"La suma de los valores es: {suma}");
            */
            /*
             * 2. Contar hasta un numero  
             * Objetivo: El programa debe solicitar al usuario un numero limite y luego contar 
             * desde 0 hasta ese numero, mostrando cada numero en la consola.
            */
            /*
            int limite, contador = 0;
            Console.WriteLine("Ingrese un numero limite");
            limite = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while (contador <= limite);
            */
            /*
             * 3.Convertir temperaturas 
             * Objetivo: El programa debe convertir las temperaturas de Celsius a Fahrenheit y permitir
             * al usuario realizar multiples conversiones hasta que decida deternerse.
            */
            /*
            double celsius, fahrenheit;
            int contador = 1;
            char respuesta;
            do
            {
                Console.WriteLine("Ingrese temperatura(-1 para cancelar)");
                celsius = double.Parse(Console.ReadLine());
                fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{fahrenheit}");
            }
            while (celsius != -1);
            */
            /*
             * 4. Contador de vocales 
             * Objetivo: El programa debe contar el numero de vocales en un texto ingresado por el usuario
             * y permitirle repetir el proceso con diferentes textos.
            */
            string cadena;
            Console.WriteLine("Ingrese texto");
            cadena = Console.ReadLine();
            int i = 0, cantVocales = 0;
            do
            {
                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u') 
                {
                    cantVocales++;
                }
                i++;
            }
            while (i < cadena.Length);
            Console.WriteLine($"Cantidad de vocales: {cantVocales}");
            /*
             * 5. Calculadora basica
             * Objetivo: el programa debe realizar operaciones aritmeticas basicas(suma, resta, multiplicacion y division)
             * entre dos numeros ingresados por el usuario y permitirle realizar multiples calculos.
            */
            /*
            do
            {

            }
            while ();
            */
            /*
             * 6. Numero par o impar
             * Objetivo: El programa debe determinar si un numero entero ingresado por el usuario 
             * es par o impar y permitirle verificar multiples numeros.
            */
            /*
             * 7. Validad edad 
             * Objetivo: El programa debe determinar si el usuario es mayor o menor de edad basado 
             * en la edad ingresada y permitirle realizar multiples verificaciones. 
            */
            /*
             * 8. Determinar la longitud de una cadena
             * Objetivo: El programa debe determinar la longitud de un texto ingresado por el usuario
             * y permitirle ingresar multiples textos 
            */
            /*
             * 9. Calcular el area de un circulo
             * Objetivo: El programa debe calcular el area de un circulo basandose en el radio ingresado
             * por el usuario y permitirle realizar multiples calculos. 
            */
            /*
             * 10. Convertir texto a mayusculas 
             * Objetivo: eL programa debe convertir un texto ingresado por el usuario a mayusculas y
             * permitirle conversiones. 
            */
            /*
             * 11. Encontar el mayor de tres numeros 
             * Objetivo: El programa debe determinar el mayor de tres numeros ingresados por el usuario 
             * y permitirle realizar multiples comparaciones.
            */ 
            Console.ReadLine();




            Console.ReadLine();
        }
    }
}

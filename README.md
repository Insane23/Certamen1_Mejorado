# Certamen1_Alfonso_Nunez
using System;

namespace Certamen1_Alfonso_Nunez
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, par=0, impar=0, res = 0, res2 = 0, res3 = 0;
            /*int enero = 1, febrero = 2, marzo = 3, abril = 4, mayo = 5, junio = 6, julio = 7, agosto = 8, septiembre = 10,
                octubre = 10, noviembre = 11, diciembre = 12;*/
            //String[] mes = new string[12];

            try
                {
                Console.WriteLine("Ingrese valor del primer número");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese valor del segundo número");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese valor del tercer número");
                c = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("INGRESE SOLO NUMEROS MENORES A 20");
                    Console.WriteLine("Ingrese nuevamente primer valor");
                    a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nuevamente segundo valor");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nuevamente tercer valor");
                c = int.Parse(Console.ReadLine());
            }
            Console.Clear();


            Console.WriteLine("1º) Sacar Mayor y Menor");
            Console.WriteLine("2°) Diferencia de productos");
            Console.WriteLine("3°) Numeros pares");
            Console.WriteLine("4°) Numeros impares");
            Console.WriteLine("5°) Mostrar mes");
            Console.WriteLine("6°) Mostrar dia de la semana");
            Console.WriteLine("Seleccione una opción: ");

            switch (Console.Read())
            {
                case '1':
                    int mayor = b, menor = b;

                    if (a > mayor)
                    {
                        mayor = a;
                    }
                    if (c > mayor)
                    {
                        mayor = c;
                    }
                    if (a < menor)
                    {
                        menor = a;
                    }
                    if (c < menor)
                    {
                        menor = c;
                    }
                    Console.WriteLine("El numero mayor es: " + mayor);
                    Console.WriteLine("El numero menor es: " + menor);
                    Console.WriteLine("\nPresione una tecla...");
                    break;
                case '2':
                    
                    menor = a;
                    mayor = c;
                    if (menor < mayor)
                    {
                        res = c - a;
                    }
                    if (menor < mayor)
                    {
                        res2 = b - a;
                    }
                    if (menor < mayor)
                    {
                        res3 = c - b;
                    }
                    Console.WriteLine(" A) La diferencia es: " + res);
                    Console.WriteLine(" B) La diferencia es: " + res2);
                    Console.WriteLine(" C) La diferencia es: " + res3);
                    break;
                case '3':
                    for (int i = 1; i <=c; i++)
                    {
                        if (i%2 ==0)
                        {
                            Console.Write("{0}| ", i);
                            par += i;
                        }
                    }
                    break;
                case '4':
                    for (int i = 1; i <= c; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write("{0}| ", i);
                            impar += i;
                        }
                    }
                    break;
                case '5':
                        if (res<=12)
                        {
                        for (int i = 1; i <=res; i++)
                        {
                            Console.WriteLine("mes");
                        }
                        }
                    break;
                case '6':
                    for (int i = 1; i <= c; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write("{0}| ", i);
                            impar += i;
                        }
                    }
                    break;
            }


            Console.ReadKey();
        }
        
    }
    
}

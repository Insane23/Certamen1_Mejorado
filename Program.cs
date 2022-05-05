using System;

namespace Certamen1_Alfonso_Nunez
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = validacion("N1");
            int n2 = validacion("N2");
            int n3 = validacion("N3");

            int C = MenorMayor(n1, n2, n3, false);
            int A = MenorMayor(n1, n2, n3, true);
            int B;

            if (n1 >= A && n1 <= C)
            {
                B = n1;
            }
            else if (n1 >= A && n1<= C)
            {
                B= n1;
            }
            else
            {
                B = n3;
            }

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
                    Console.WriteLine("El número mayor es "+ C);
                    Console.WriteLine("El número menor es "+ A);
                    break;
                case '2':
                    Console.WriteLine("La diferencia entre C y A es " + (C - A));
                    Console.WriteLine("La diferencia entre B y A es " + (B - A));
                    Console.WriteLine("La diferencia entre B y C es " + (B - C));
                    break;
                case '3':
                    pares(A, C);break;
                case '4':
                    impares(C, A);break;
                case '5':
                    meses(C - A);break;
                case '6':
                    dias(B - A); break;
            }

            static void dias(int num)
            {
                switch (num)
                {
                    default: case 1: Console.WriteLine("Lunes "); break;
                    case 2: Console.WriteLine("Martes"); break;
                    case 3: Console.WriteLine("Miércoles"); break;
                    case 4: Console.WriteLine("Jueves"); break;
                    case 5: Console.WriteLine("Viernes"); break;
                    case 6: Console.WriteLine("Sábado"); break;
                    case 7: Console.WriteLine("Domingo"); break;
                }
            }

            static int validacion(String txt)
            {
                int num;
                bool valida = false;
                Console.Clear();
                do
                {
                    Console.WriteLine("INGRESE UN NÚMERO {0}: ", txt);
                    valida = int.TryParse(Console.ReadLine(), out num);

                    if (num < 0)
                    {
                        valida = false;
                        Console.WriteLine("Números mayores a 0");
                    }

                } while (!valida);
                return num;

            }

            static int MenorMayor(int n1, int n2, int n3, bool tipo)
            {
                if (tipo)
                {
                    if (n1 <= n2 && n1 <=n3)
                    {
                        return n1;
                    }
                    else if (n2 <= n1 && n2 >= n3)
                    {
                        return n2;
                    }
                    else
                    {
                        return n3;
                    }
                }
                else
                {
                    if (n1 >= n2 && n1 >= n3)
                    {
                        return n1;
                    }
                    else if (n2 >= n1 && n2>=n3)
                    {
                        return n2;
                    }
                    else
                    {
                        return n3;
                    }
                }
            }

            static void pares (int inicio, int fin)
            {
                int par = 0;
                for (int i = inicio; i <= fin; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("{0}| ", i);
                        par += i;
                    }
                }
            }

            static void impares(int inicio, int fin)
            {
                for (int i = fin; i <= inicio; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write("{0}| ", i);
                    }
                }
            }

            static void meses (int num)
            {
                switch (num)
                {
                    case 1: Console.WriteLine("Enero ");break;
                    case 2: Console.WriteLine("Febrero");break;
                    case 3: Console.WriteLine("Marzo");break;
                    case 4: Console.WriteLine("Abril");break;
                    case 5: Console.WriteLine("Mayo");break;
                    case 6: Console.WriteLine("Junio");break;
                    case 7: Console.WriteLine("Julio");break;
                    case 8: Console.WriteLine("Agosto");break;
                    case 9: Console.WriteLine("Septiembre");break;
                    case 10: Console.WriteLine("Octubre");break;
                    case 11: Console.WriteLine("Noviembre");break;
                    case 12: Console.WriteLine("Diciembre");break;
                    default: break;
                }
            }
            Console.ReadKey();
        }
        
    }
    
}

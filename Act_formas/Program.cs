using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grande = 0;
            string hueco = null;
            uint des = 0;
            Console.WriteLine("Que figura desea hacer? \n 1)Cuadrado \n 2)Triangulo \n 3)Circulo");

            try
            {
                des = (uint)int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Solo escriba numeros");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Solo se permite valores de 1 al 3");
            }


            Console.WriteLine("Ingrese el tamaño de la figura");
            try
            {
                grande = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sobrepaso el tamaño permitido");
            }


            switch (des)
            {
                case 1:
                    Console.WriteLine("Tendra un hueco en medio  (Si o No)");

                    try
                    {
                        hueco = Console.ReadLine();
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Solo escriba Si o No");
                    }
                    int comp = string.Compare(hueco, "si", true);
                    if (comp == 0)
                    {
                        huecoCubo(grande);
                    }
                    else
                    {
                        cubo(grande);
                    }
                    break;

                case 2:
                    triangulo(grande);
                    break;
                case 3:
                    circulo(grande);
                    break;
                default:
                    Console.WriteLine("El valor escrito no es correcto");
                    break;
            }



        }
        public static void cubo(int tam)
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < tam; i++)
            {
                for (int l = 0; l < tam; l++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
            Console.ResetColor();
        }

        public static void huecoCubo(int tam)
        {
            string[,] areglo = new string[tam, tam];

            for (int i = 0; i < tam; i++)
            {
                for (int l = 0; l < tam; l++)
                {
                    areglo[i, l] = " *";
                }
            }

            if (tam % 2 == 0)
            {
                int medio = tam / 2;
                areglo[medio, medio] = "  ";
                areglo[medio - 1, medio - 1] = "  ";
                areglo[medio, medio - 1] = "  ";
                areglo[medio - 1, medio] = "  ";
            }
            else
            {
                int medio = tam / 2;
                areglo[medio, medio] = "  ";
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < tam; i++)
            {
                for (int l = 0; l < tam; l++)
                {
                    Console.Write(areglo[i, l]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
            Console.ResetColor();


        }

        public static void triangulo(int tam)
        {
            int i = 1;
            int spa = tam;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                for (int m = spa; m > 0; m--)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < i; l++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
                i++;
                spa--;

            } while (i < (tam + 1));
            Console.ResetColor();
        }

        public static void circulo(int tam)
        {
            int i = 1;
            int spa = tam;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                for (int m = spa; m > 0; m--)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < i; l++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
                i += 2;
                spa -= 2;

            } while (i < tam);

            i = 1;
            spa = tam;
            do
            {
                for (int m = 0; m < i; m++)
                {
                    Console.Write(" ");
                }
                for (int l = spa; l > 0; l--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
                i += 2;
                spa -= 2;

            } while (spa > 0);
            Console.ResetColor();
        }
    }
}

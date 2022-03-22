using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha = " ";
            while (escolha != "6")
            {
                Console.WriteLine("\nSeja bem-vindo(a) \n\n" +
                   "----------Menu---------- \n\n" +
                   "1. Potencia(x, y) \n" +
                   "2. Função de Cubo \n" +
                   "3. Máximo divisor comum (mdc) \n" +
                   "4. Série de Fibonacci \n" +
                   "5. Converter numero para base binária \n\n" +
                   "Qual opção deseja?");

                escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    MainPotencia();
                }
                else if (escolha == "2")
                {
                    cubo();
                }
                else if (escolha == "3")
                {
                    mdc();
                }
                else if (escolha == "4")
                {
                    fib();
                }
                else if (escolha == "5")
                {
                    bin();
                }
            }
        }

        static int potencia(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            else
            {
                return x * potencia(x, y - 1);
            }
        }

        static void MainPotencia()
        {
            int x;
            int y;

            Console.WriteLine("Digite um número: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            y = Convert.ToInt32(Console.ReadLine());

            potencia(x, y);

            Console.WriteLine("O resultado da potencia de " + x + " elevado a " + y + " é igual a " + potencia(x, y));

        }

        static void mdc()
        {
            Console.WriteLine("Informe o primeiro número para o calculo: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número para o calculo: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O Maximo Divisor Comum de " + x + " e " + y + " é " + MDC(x, y));

        }

        private static int MDC(int x, int y)
        {
            int resto;

            while (y != 0)
            {
                resto = x % y;
                x = y;
                y = resto;
            }

            return x;
        }

        static void cubo()
        {
            Console.WriteLine("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            cubos(n);

        }

        static void cubos(int n)
        {
            if (n >= 1)
            {
                cubos(n - 1);
                Console.WriteLine(n * n * n);
            }

        }
        static void fib()
        {
            Console.WriteLine("Digite um valor maior que zero: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fb(x));


        }

        static int fb(int x)
        {
            if (x == 0 || x == 1)
            {
                return x;
            }

            if (x >= 2)
            {
                return fb(x - 1) + fb(x - 2);
            }
            return 0;
        }

        static void bin()
        {
            Console.WriteLine("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bina(n);
        }
        static void bina(int n)
        {
            if (n / 2 != 0)
            {
                bina(n / 2);
            }

            Console.Write(n % 2);

        }

    }
}



using System;
namespace Programa
{
    class Pascal
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Triangulo de Pascal");
            int primer = 1;
            int segundo = 1;
            int tercero = 0;
            Console.WriteLine(primer);
            while (tercero <= 4)
            {
                if (tercero == 0)
                {
                    Console.WriteLine(primer + "  " + primer);
                }
                if (tercero == 1)
                {
                    segundo += primer;
                    Console.WriteLine(primer + "  " + segundo + "  " + primer);
                }
                if (tercero == 2)
                {
                    segundo += primer;
                    Console.WriteLine(primer + "  " + segundo + "  " + segundo + "  " + primer);
                }
                if (tercero == 3)
                {
                    segundo += primer;

                    Console.WriteLine(primer + "  " + segundo + " " + (tercero + tercero) + " " + segundo + "  " + primer);
                }
                if (tercero == 4)
                {
                    segundo += primer;
                    Console.WriteLine(primer + "  " + segundo + "  " + (segundo + segundo) + (segundo + segundo) + " " + segundo + "  " + primer);
                }


                tercero++;
            }
            Console.ReadKey();


        }
    }
}

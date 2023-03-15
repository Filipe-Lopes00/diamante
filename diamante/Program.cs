using System.Security.Cryptography.X509Certificates;

namespace diamante
{
    internal class Program
    {
        static void Main(string[] args)

        {
           int n;
           

            Console.WriteLine("informe o numero impar: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n % 2 == 0)
            {
              Console.WriteLine("informe o numero impar: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i+=2)               //linha

            {   for (int j = n; j > i; j-=2)                  // i esta aumentando (sempre)

                Console.Write(" ");
                
                for (int j = 0; j <= i; j+=1)  
                                                          // coluna
                    Console.Write("x");
                Console.WriteLine();
            }

            for (int i = n-2; i >= 0; i -=2)

            {
                for (int j = n+2; j > i; j -= 2)

                    Console.Write(" ");

                    for (int j = i; j > 0; j -=1) 

                    Console.Write("x");
                Console.WriteLine();

            }
           



        }
    }
}
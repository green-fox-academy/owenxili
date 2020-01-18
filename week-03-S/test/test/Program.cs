using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello Owen!");

            /*
            int myFirstInteger = 5;

            double rationalNumber = 3.14;

            String thisIsText = "anything you write in it, is the strong?";

            int mySecondInteger = 15;

            int myfirstSum = myFirstInteger + mySecondInteger；

            */

            string hello = "hello";
            string space = " ";
            string world = "world";
            string exclamation = "!";

            string helloworld = hello + space + world + exclamation;

            Console.WriteLine(helloworld);

            int i = 1;
            string sentence = "I won't cheat on the exam!";
            while(i <= 100)
            {
                Console.WriteLine(sentence);
                i++;
            }

            int x = 1;

            while (x < 500)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
                x++;
            }

            Console.WriteLine(2 + 2);
            Console.WriteLine(7 - 2);
            Console.WriteLine(3 * 2);
            Console.WriteLine(5 / 2);
            Console.WriteLine(7 % 2);
            Console.WriteLine(7 / 2.0);

            int j, n;
            Console.Write("\n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }

            int a, b;
            Console.Write("\n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            while (a < b)
            {
                Console.WriteLine(a);
                a++;
                break;
            }
            Console.Write("The second number should be bigger");

            Console.WriteLine("\n");

            int starnumber = Convert.ToInt32(Console.ReadLine());
            int l, k;
            for (l = 0; l < starnumber; l++)
            {
                
                for (k = 0; k <= l; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }

        }
}

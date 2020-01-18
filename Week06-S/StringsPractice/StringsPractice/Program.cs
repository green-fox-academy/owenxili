using System;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = string.Format("{0:N}", 123456789);
            Console.WriteLine(myString);
        }
    }
}

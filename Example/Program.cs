using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Console.WriteLine("Введіть перше число");
            string a2 = Console.ReadLine();
            int a = Convert.ToInt32(a2);

            Console.WriteLine("Введіть друге число");
            string b2 = Console.ReadLine();
            int b = Convert.ToInt32(b2);

            int c = a + b;

            Console.WriteLine(a + " + " + b + " = " + c);

            Console.ReadLine();
        }
    }
}

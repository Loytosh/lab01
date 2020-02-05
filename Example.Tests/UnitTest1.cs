using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
			Console.WriteLine("¬вед≥ть перше число");
            string a2 = Console.ReadLine();
            int a = Convert.ToInt32(a2);

            Console.WriteLine("¬вед≥ть друге число");
            string b2 = Console.ReadLine();
            int b = Convert.ToInt32(b2);

            int c = a + b;

            Console.WriteLine(a + " + " + b + " = " + c);

            Console.ReadLine();
        }
    }
}

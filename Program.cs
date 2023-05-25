//namespace HelloWorld;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");

//    }
//}

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sub(20, 10));
            Console.WriteLine(Mul(10, 20));
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
    }
}




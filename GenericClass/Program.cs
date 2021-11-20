using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1<int> c1 = new Class1<int>();
            bool isC1Eq = c1.ToCheck(1, 2);
            Console.WriteLine("Is object c1 from Class1 equal = " + isC1Eq);

            Class1<string> c2 = new Class1<string>();
            bool isC2Eq = c2.ToCheck("1", "1");
            Console.WriteLine("Is object c2 from Class1 equal = " + isC2Eq);

            Class2<double> c3 = new Class2<double>();
            bool isC3Eq = c3.ToCheck(2.0, 2.0);
            Console.WriteLine("Is object c3 from Class2 equal = " + isC3Eq);

            Class2<string> c4 = new Class2<string>();
            bool isC4Eq = c4.ToCheck("2.0", "2");
            Console.WriteLine("Is object c4 from Class2 equal = " + isC4Eq);
        }
    }
}

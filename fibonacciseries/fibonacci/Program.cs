using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0, second = 1, third = 0,fiboinput=0;
            Console.WriteLine("enter upto which number");
            fiboinput = int.Parse(Console.ReadLine());
            if (fiboinput == 0) 
            for (int fibo=2;fibo<=fiboinput;fibo++)
            {
                third = first + second;
                first = second;
                second = third;
                Console.WriteLine(third);
            }
            Console.ReadLine();
        }
    }
}

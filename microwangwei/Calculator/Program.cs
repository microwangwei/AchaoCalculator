using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input how many question you want:");
            int n = int.Parse(Console.ReadLine());
            string[] s1 = { "+", "-", "*", "/" };
            string[] s2 = { "*", "/" };
            for (int i = 0; i < n;)
            {
                Random B = new Random(Guid.NewGuid().GetHashCode());
                Random A = new Random(Guid.NewGuid().GetHashCode());
                double a = A.Next(0, 100);
                double b = A.Next(0, 100);
                double c = A.Next(0, 100);
                int x = B.Next(0, 2);
                int y = B.Next(0, 4);
                double sum = 0;
                switch (x)
                {
                    case 0:
                        sum = a * b;
                        break;
                    case 1:
                        sum = a / b;
                        break;

                }
                if (sum == (int)sum)
                {
                    switch (y)
                    {
                        case 0:
                            sum = sum + c;
                            break;
                        case 1:
                            sum = sum - c;
                            break;
                        case 2:
                            sum = sum * c;
                            break;
                        case 3:
                            sum = sum / c;
                            break;
                    }

                    if (sum == (int)sum && sum >= 0 && sum <= 10000)
                    {
                        Console.WriteLine(a + s2[x] + b + s1[y] + c + "=" + sum);
                        i++;
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
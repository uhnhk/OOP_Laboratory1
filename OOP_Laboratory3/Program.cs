using System;
using System.IO;

namespace LR_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double X, Y, t;
            int N;

            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToDouble(Console.ReadLine());

            double Z = 0.0;
            int sign;
            int n;
            double even;
            double prev;
            double num;
            double den;

            switch ((int)t)
            {
                case 0: 
                    Z = 0.0;
                    even = 2;
                    prev = 1;
                    sign = 1;
                    n = 1;

                    while (n <= N)
                    {
                        num = Math.Pow(Y, even) * Math.Pow(X, prev);
                        den = even + sign * prev;
                        Z += sign * num / den;

                        prev = even;
                        even += 2;
                        sign = -sign;
                        n++;
                    }
                    break;

                case 1: 
                    Z = 0.0;
                    even = 2;
                    prev = 1;
                    sign = 1;
                    n = 1;

                    if (N > 0)
                    {
                        do
                        {
                            num = Math.Pow(Y, even) * Math.Pow(X, prev);
                            den = even + sign * prev;
                            Z += sign * num / den;

                            prev = even;
                            even += 2;
                            sign = -sign;
                            n++;
                        } while (n <= N);
                    }
                    break;

                case 2: 
                    Z = 0.0;
                    even = 2;
                    prev = 1;
                    sign = 1;

                    for (n = 1; n <= N; n++)
                    {
                        num = Math.Pow(Y, even) * Math.Pow(X, prev);
                        den = even + sign * prev;
                        Z += sign * num / den;

                        prev = even;
                        even += 2;
                        sign = -sign;
                    }
                    break;
            }

            Console.WriteLine("{0:0.000000}", Z);

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
            Console.ReadKey();
        }
    }
}

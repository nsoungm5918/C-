using System.Numerics;
using System;

class Hello
{
    static void Main()
    {
        {
            Console.WriteLine("1차함수:one, 2차함수:two");
            Console.WriteLine("높은 항의 숫자부터 차례대로 적어주세요");
            Console.WriteLine("예): two 3 4 5");
            Console.WriteLine("허수는표현이안됍니다");
            string s = Console.ReadLine();
            string[] v = s.Split(' ');
            string g = (v[0]);
            switch (g)
            {
                case "one":
                    {
                        Console.WriteLine("일차방정식");
                        Console.WriteLine("=====================");
                        float a = int.Parse(v[1]);
                        float b = int.Parse(v[2]);
                        Console.WriteLine(a + "x+" + b + "=" + "0");
                        if (b > 0)
                            Console.WriteLine(a + "x+" + b + "=" + "0");
                        else if (b < 0)
                            Console.WriteLine(a + "x" + b + "=" + "0");
                        Console.WriteLine("x=" + (-1 * (b / a)));
                        break;
                    }
                case "two":
                    {
                        Console.WriteLine("이차방정식");
                        Console.WriteLine("=====================");
                        float a = int.Parse(v[1]);
                        float b = int.Parse(v[2]);
                        float c = int.Parse(v[3]);
                        if (b > 0 || c > 0)
                            Console.WriteLine(a + "x^2+" + b + "x+" + c + "=" + "0");
                        else if (b < 0 || c > 0)
                            Console.WriteLine(a + "x^2" + b + "x+" + c + "=" + "0");
                        else if (b > 0 || c < 0)
                            Console.WriteLine(a + "x^2+" + b + "x" + c + "=" + "0");
                        else if (b < 0 || c < 0)
                            Console.WriteLine(a + "x^2" + b + "x" + c + "=" + "0");
                        double d = b * b - 4.0 * a * c;
                        if (d > 0)
                            Console.WriteLine("x=" + (-b + Math.Sqrt(d)) / (2 * a) + "," + (-b - Math.Sqrt(d)) / (2 * a));
                        else if (d == 0)
                            Console.WriteLine("x=" + (-b / (2 * a)) + " (중근)");
                        else
                            Console.WriteLine("허근");

                        break;
                    }
                
            }
            Console.Read();
        }
    }
}

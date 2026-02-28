using System;

class Program
{
    static void Main(string[] args)
    {
        //ex1
        Console.WriteLine("Exercise 1:");
        Console.Write("Enter first number: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x == y)
        {
            Console.WriteLine("Numbers are equal");
        }
        else
        {
            if (x > y)
            {
                Console.WriteLine("First number is greater than second");
            }
            else
            {
                Console.WriteLine("First number is less than second");
            }
        }

        Console.WriteLine("----------------");


        //ex2
        Console.WriteLine("Exercise 2:");
        Console.Write("Enter number: ");
        double n = Convert.ToDouble(Console.ReadLine());

        if (n > 5 && n < 10)
        {
            Console.WriteLine("The number is greater than 5 and less than 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine("----------------");


        //ex3
        Console.WriteLine("Exercise 3:");
        Console.Write("Enter number: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        if (n2 == 5 || n2 == 10)
        {
            Console.WriteLine("The number is either 5 or 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine("----------------");


        //ex4
        Console.WriteLine("Exercise 4:");
        Console.Write("Deposit: ");
        double dep = Convert.ToDouble(Console.ReadLine());
        double p = 0;

        if (dep < 100)
        {
            p = 0.05;
        }
        else if (dep >= 100 && dep <= 200)
        {
            p = 0.07;
        }
        else
        {
            p = 0.10;
        }

        double total = dep + dep * p;
        Console.WriteLine("Final: " + total);

        Console.WriteLine("----------------");


        //ex5
        Console.WriteLine("Exercise 5:");
        Console.Write("Deposit: ");
        double dep2 = Convert.ToDouble(Console.ReadLine());
        double p2 = 0;

        if (dep2 < 100)
        {
            p2 = 0.05;
        }
        else if (dep2 >= 100 && dep2 <= 200)
        {
            p2 = 0.07;
        }
        else
        {
            p2 = 0.10;
        }

        double total2 = dep2 + dep2 * p2 + 15;
        Console.WriteLine("Final with bonus: " + total2);

        Console.WriteLine("----------------");


        //ex6
        Console.WriteLine("Exercise 6:");
        Console.WriteLine("1.Add 2.Sub 3.Mult");
        int choose = Convert.ToInt32(Console.ReadLine());

        switch (choose)
        {
            case 1:
                Console.WriteLine("Addition");
                break;
            case 2:
                Console.WriteLine("Subtraction");
                break;
            case 3:
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("Undefined");
                break;
        }

        Console.WriteLine("----------------");


        //ex7
        Console.WriteLine("Exercise 7:");
        Console.WriteLine("Choose op: 1 2 3");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        switch (c)
        {
            case 1:
                Console.WriteLine("Ans = " + (a + b));
                break;
            case 2:
                Console.WriteLine("Ans = " + (a - b));
                break;
            case 3:
                Console.WriteLine("Ans = " + (a * b));
                break;
            default:
                Console.WriteLine("No operation");
                break;
        }
    }
}

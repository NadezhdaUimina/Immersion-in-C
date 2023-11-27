using System.ComponentModel.Design;

namespace homework1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
               string[] newArray = new string[args.Length];
               int j = 0;

                if (args[1] == "*")
                {
                    Console.WriteLine($"{args[0]} * {args[2]} = {int.Parse(args[0]) * int.Parse(args[2])}");
                }

                if (args[1] == "/")
                {
                    Console.WriteLine($"{args[0]} / {args[2]} = {int.Parse(args[0]) / int.Parse(args[2])}");
                }

                if (args[1] == "+")
                {
                    Console.WriteLine($"{args[0]} + {args[2]} = {int.Parse(args[0]) + int.Parse(args[2])}");
                }

                if (args[1] == "-")
                {
                    Console.WriteLine($"{args[0]} - {args[2]} = {int.Parse(args[0]) - int.Parse(args[2])}");
                }
         
            }
            else
            {
                Console.WriteLine("Need args");
            }
        }
    }
}
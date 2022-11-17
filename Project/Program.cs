using System;
namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Is A Calculator");
            while (true)
            {
                // Prints Options
                Console.WriteLine("1 = Add\n2 = Sub\n3 = Multiply\n4 = Divide\n5 = Average");
                // Gets Option
                Console.Write("Choose 1/2/3/4/5: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string choice = Console.ReadLine(); // Type: ignore //
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                              // Avg of 1 -5 numbers
                if (choice == "5")
                {
                 
                    Console.Write("Type How Many Numbers for avg(2-5): ");
                    int navg = Convert.ToInt32(Console.ReadLine());
                    // figuring out how many numbers to take avg of
                    if (navg == 2)
                    {
                        Console.Write("Input num1: ");
                        double num1_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num2: ");
                        double num2_ = Convert.ToDouble(Console.ReadLine());
                        double avg = (num1_ + num2_)/2;
                        double avg_ = Math.Round(avg, 3);
                        Console.WriteLine($"The avg of {num1_},{num2_} = {avg_}");
                    }

                    else if (navg == 3)
                    {
                        Console.Write("Input num1: ");
                        double num1_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num2: ");
                        double num2_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num3: ");
                        double num3_ = Convert.ToDouble(Console.ReadLine());
                        double avg = (num1_ + num2_ + num3_)/3;
                        double avg_ = Math.Round(avg, 3);
                        Console.WriteLine($"The avg of {num1_},{num2_},{num3_} = {avg_}");
                    }
                    else if (navg == 4)
                    {
                        Console.Write("Input num1: ");
                        double num1_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num2: ");
                        double num2_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num3: ");
                        double num3_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num4: ");
                        double num4_ = Convert.ToDouble(Console.ReadLine());
                        double avg = (num1_ + num2_ + num3_ + num4_) / 4;
                        double avg_ = Math.Round(avg, 3);
                        Console.WriteLine($"The avg of {num1_},{num2_},{num3_},{num4_} = {avg_}");

                    }
                    else if (navg == 5)
                    {
                        Console.Write("Input num1: ");
                        double num1_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num2: ");
                        double num2_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num3: ");
                        double num3_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num4: ");
                        double num4_ = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input num5: ");
                        double num5_ = Convert.ToDouble(Console.ReadLine());
                        double avg = (num1_ + num2_ + num3_ + num4_ + num5_) / 5;
                        double avg_ = Math.Round(avg, 3);
                        Console.WriteLine($"The avg of {num1_},{num2_},{num3_},{num4_},{num5_} = {avg_}");
                    }
                    // skipping to try again at ln 109
                    goto tryagain;
                } 
                // Input num1/num2
                Console.Write("Input num1: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input num2: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                // if statements to calculate based on option
                if (choice == "1")
                {
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    goto tryagain;
                }
                else if (choice == "2")
                {
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    goto tryagain;
                }
                else if (choice == "3")
                {
                    Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                    goto tryagain;
     
                }

                else if (choice == "4")
                {
                    Console.WriteLine($"{num1} ÷ {num2} = {num1 / num2}");
                    goto tryagain;
                }
                // Do Next Calc
                tryagain:
                    Console.WriteLine("Do You Want To Do Another Calc?");
                    Console.Write("Y/n: ");
                    var op = Console.ReadLine();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    var opt = op.ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    if (opt ==  "y")
                    {
                    
                    }
                    else if (opt == "n")
                    {
                        break;
                    }
                    else 
                    {
                    Console.WriteLine("Not Option Try Againt");
                    goto tryagain;
                    };
            }
        }
    }
}

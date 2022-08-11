using System;

namespace ObjectOrientedProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
             "Enter 4 for Account Management\n");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 4:
                    AccountManagement.DriverMethod();
                    break;

                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }

        }
    }
}

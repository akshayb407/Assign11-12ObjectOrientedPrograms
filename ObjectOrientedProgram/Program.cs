using System;

namespace ObjectOrientedProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for AddressBook\n" +
               "Enter 2 for InventoryManagement\n" +
               "Enter 3 For Stock Management\n"
               );
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 3:
                    StocksManagement.DriverMethod();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;

            }

        }
    }
}

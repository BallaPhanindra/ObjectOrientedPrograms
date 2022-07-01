    using System;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

namespace ObjectOrientedPrograms
{ 
    public class Program
    {

        public static void Main(string[] args)
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

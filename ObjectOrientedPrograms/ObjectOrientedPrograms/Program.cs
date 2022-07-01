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
            Console.WriteLine("Enter 0 for InventoryManagement\n");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0:
                    AccountManagement.DriverMethod();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}
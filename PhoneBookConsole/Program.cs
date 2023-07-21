using CsvHelper;
using CsvHelper.Configuration;
using PhoneBookConsole;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PhoneBookConsole
{
    public class Program
    {
        static void Main()
        {
            //CSV file configuration
            string directoryPath = @"E:\";
            string fileName = "data.csv";
            string filePath = Path.Combine(directoryPath, fileName);

            //IOC Container
            var contactSertvice = new IocContainer().GetContactService();
            contactSertvice.Write(filePath);

            //Press any key to exit
            Console.ReadKey();
        }
    }

}

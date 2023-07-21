using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsole
{
    public class ContactServiceOutputCsv : IContactService
    {

        public List<Contact> contacts = new List<Contact>();

        public void AddContact()
        {
            Console.Write("full name : ");
            String name = Console.ReadLine();

            Console.Write("phone number: ");
            String phoneNumber = Console.ReadLine();


            Contact contact = new Contact(name, phoneNumber);

            contacts.Add(contact);

        }

        public void Write(string filePath)
        {

            try
            {
                while (true)
                {
                    if (!File.Exists(filePath))
                    {
                        using (File.Create(filePath)) { }
                    }
                    else

                        AddContact();

                    var configContacts = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = false
                    };

                    using (StreamWriter streamWriter = new StreamWriter(filePath, true))
                    using (CsvWriter csvWriter = new CsvWriter(streamWriter, configContacts))
                    {
                        csvWriter.WriteRecords(contacts);
                    }

                    Console.WriteLine($"Data of this user written to CSV format successfully ");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}

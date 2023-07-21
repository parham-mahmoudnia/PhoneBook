using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsole
{
    public class ContactServiceOutputXps : IContactService
    {
        public void Write(string filePath)
        {
            Console.WriteLine($"Data of this user written to XPS format successfully ");
        }
    }
}

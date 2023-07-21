using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneBookConsole
{
    public class Contact
    {
        //Regex for accepting name max 200 characters
        string NamePattern = @"^[a-zA-Z''-'\s]{1,200}$";
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value, NamePattern))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("You entered wrong name");
                }
            }
        }

        //Regex for accepting only persian phone number
        //[EXP:09121234567]
        string PhonePattern = @"(0|\+98)?([ ]|-|[()]){0,2}9[1|2|3|4]([ ]|-|[()]){0,2}(?:[0-9]([ ]|-|[()]){0,2}){8}";
        private string phone;

        public string Phone
        {
            get { return phone; }
            set
            {
                if (Regex.IsMatch(value, PhonePattern))
                {
                    phone = value;
                }
                else
                {
                    throw new Exception("You entered wrong phone");
                }
            }
        }

        public Contact(string name, string phone)
        {
            Phone = phone;  
            Name = name;    
                
        }

    }
}

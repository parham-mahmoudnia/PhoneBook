using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsole
{
    public class IocContainer
    {
        public IContactService GetContactService()
        {
            //You can choose between (ContactServiceOutputCsv) or (ContactServiceOutputXps) / csv or xps ?
            //It can handle with ninject in Program.cs 

            return new ContactServiceOutputCsv();
        }
    }
}

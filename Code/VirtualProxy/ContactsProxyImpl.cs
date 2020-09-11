using System;
using System.Collections.Generic;

namespace VirtualProxy
{
    public class ContactsProxyImpl: IContacts
    {
        private IContacts _contacts;
        
        public IList<Employee> Employees()
        {
            PrepareContactsObject();

            Console.WriteLine("Fetching list of employees...");

            return _contacts.Employees();
        }

        public override string ToString()
        {
            PrepareContactsObject();

            return _contacts.ToString();
        }

        private void PrepareContactsObject()
        {
            if (_contacts == null)
            {
                Console.WriteLine("Creating contact list...");
                _contacts = new ContactsImpl();
            }
        }
    }
}
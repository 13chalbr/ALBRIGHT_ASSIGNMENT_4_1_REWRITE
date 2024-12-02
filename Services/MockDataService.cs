using ALBRIGHT_ASSIGNMENT_4_1_REWRITE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_4_1_REWRITE.Services
{
    public class MockDataService : IContactDataService
    {
        private IEnumerable<Contact> _contacts;

        public MockDataService() 
        {
            _contacts = new List<Contact>()
            {
                new Contact
                {
                    Name = "John Doe",
                    PhoneNumbers = new string []
                    {
                        "555-111-1111",
                        "555-222-2222"
                    },
                    Emails = new string []
                    {
                        "JohnDoe@personal.com",
                        "JohnDoe@business.com"
                    },
                    Locations = new string []
                    {
                        "111 Fake Street",
                        "222 Fake Ave."
                    }
                },
                new Contact
                {
                    Name = "Jane Doe",
                    PhoneNumbers = new string []
                    {
                        "555-333-3333",
                        "555-444-4444"
                    },
                    Emails = new string []
                    {
                        "JaneDoe@personal.com",
                        "JaneDoe@business.com"
                    },
                    Locations = new string []
                    {
                        "111 Fake Street",
                        "333 Fake Ave."
                    }
                },
            };
        }
        public IEnumerable<Contact> GetContacts()
        {
            return _contacts;
        }

        public void Save(IEnumerable<Contact> contacts)
        {
            _contacts = contacts;
        }
    }
}

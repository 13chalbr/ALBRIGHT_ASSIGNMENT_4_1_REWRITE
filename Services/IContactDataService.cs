using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALBRIGHT_ASSIGNMENT_4_1_REWRITE.Models;

namespace ALBRIGHT_ASSIGNMENT_4_1_REWRITE.Services
{
    public interface IContactDataService
    {
        IEnumerable<Contact> GetContacts();
        void Save(IEnumerable<Contact> contacts);
    }
}

using DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext
{
    class AddressBookContext : DbContext
    {
        public AddressBookContext() : base("AddressBook")
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}

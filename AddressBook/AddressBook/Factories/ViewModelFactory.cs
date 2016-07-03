using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AddressBook.Models;
using DataContext.Entities;

namespace AddressBook.Factories
{
    public class ViewModelFactory
    {
        public ContactsViewModel Create(Contact contact)
        {
            if(contact != null)
            {
                return new ContactsViewModel()
                {
                    Id= contact.Id,
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    NickName = contact.NickName,
                    PhoneNumber = contact.PhoneNumber,
                    EmailAddress = contact.EmailAddress
                };
            }
            else
            {
                return null;
            }
        }
    }
}
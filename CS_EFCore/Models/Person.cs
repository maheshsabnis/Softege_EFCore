using System;
using System.Collections.Generic;
using System.Text;

namespace CS_EFCore.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string  PersonName { get; set; }
        private string Email;

        public void SetEmail(string email)
        {
            Email = email;
        }

        public string GetEmail()
        {
            return Email;
        }

        private string Contact;

        public void SetContact(string contact)
        {
            Contact = contact;
        }

        public string GetContact()
        {
            return Contact;
        }
    }
}

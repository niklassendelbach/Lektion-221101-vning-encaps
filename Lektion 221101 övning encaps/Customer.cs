using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion_221101_övning_encaps
{
    class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;

        public int Id 
        { 
            get
            {
                return id;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Värdet får inte vara mindre än 0");
                }
                else
                {
                    id = value;
                }
            }
        }
        public string FirstName 
        { 
            get
            {
                return firstName;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("First name can't be empty");
                }
                else if (value == null)
                {
                    FirstName = "No first name";
                }
                else
                {
                    firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Last name can't be empty");
                }
                else if (value == null)
                {
                    LastName = "No last name";
                }
                else
                {
                    lastName = value;
                }
            }
        }
        public string Email 
        { 
            get
            {
                return email;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Email can't be empty");
                }
                else if (value == null)
                {
                    Email = "Mail is empty";
                }
                else
                {
                    email = value;
                }
            }
        }
        public void printInfo()
        {
            Console.WriteLine($"ID = {id} \nFirst name = {firstName} \nLast name = {lastName} \nEmail = {email}");
        }
    }
}

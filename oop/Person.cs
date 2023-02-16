using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;
        private string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
              
        }

        public Person(string firstName, string lastName) //konstruktor
        {
            Console.WriteLine("Constructor 1");
            FirstName= firstName;
            LastName= lastName;

        }
        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName,lastName) //konstruktor
        {
            Console.WriteLine("Constructor 2");
            SetDateOfBirth(dateOfBirth);  //wywołanie date of birth z metody SetDateOfBirth
        }
        public void SetDateOfBirth(DateTime date)
        {
            if(date>DateTime.Now) 
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            {
                dateOfBirth = date;
            }
        }

        
        public DateTime GetDateOfBirth() => dateOfBirth;

        public DateTime GetDateOfBirth2()
        {
            return dateOfBirth;
        }


        public void SayHi()
        { 
            Console.WriteLine($"Hi im {FirstName} {LastName} {GetDateOfBirth()}");
        }
    }
}

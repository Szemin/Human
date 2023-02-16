using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

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
            Console.WriteLine($"Hi im {FirstName}, {LastName}, {GetDateOfBirth()}");
        }
    }
}

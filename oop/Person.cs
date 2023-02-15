﻿using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}

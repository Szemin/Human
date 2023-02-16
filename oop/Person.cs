using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Person
    {
        public string FirstName;
        public string LastName;

        //private DateTime dateOfBirth;
        private string contactNumber;

        //public string ContactNumber { get; set; }
        //ta właściwość pozwala na uproszczony zapis tego poniżej ponieważ jedyne przypadki
        // dla których można to wykorzystać to te które nie zawierają dodatkowej logigi i są tylko do uzyskiwania/pobierania wartości
        //        - specjalne metody zwane akcesorami get set


        public DateTime DateOfBirth
        {
            get; set;
        }







        public string ContactNumber                 // w tym przypadku można stosować logikę np sprawdzającą czy numer ma 9 cyfr
        {
            get { return contactNumber; }      // get zwraca wartość z pola number
            set                                  // akcesor set przypisuje wartość do pola specjalnym słowem kluczowym "value"
            {
                if (value.Length > 9)
                {
                    Console.WriteLine("invalid number");
                }
                else
                {
                    contactNumber = value;
                    Console.WriteLine("correct number");
                }
            }     
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
                DateOfBirth = date;
            }
        }

        
        public DateTime GetDateOfBirth() => DateOfBirth;     //jawne wywołanie

        public DateTime GetDateOfBirth2()
        {
            return DateOfBirth;
        }


        public void SayHi()
        { 
            Console.WriteLine($"Hi im {FirstName} {LastName} {GetDateOfBirth()}");
        }
    }
}

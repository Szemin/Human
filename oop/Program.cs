﻿using oop;

class Program
{
    static void Main()
    {
        Person oliwier = new Person("Oliwier", "Giroud");

        //oliwier.FirstName = "Oliwier";
        //oliwier.LastName = "Giroud";
        oliwier.SetDateOfBirth(new DateTime(2002,4,4));
        //Console.WriteLine($"{oliwier.FirstName} {oliwier.LastName} {oliwier.GetDateOfBirth()}"); wywołanie bez metody SayHi

        oliwier.SayHi();  //wywołanie powitania z imieniem nazwiskiem i datą urodzenia bez wypisywania tego w głównej metodzie
    }
}
using System;
using System.Collections.Generic;
using OCPLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>()
            {
                new PersonModel() {FirstName = "Bernie", LastName = "NeJame"},
                new PersonModel() {FirstName = "Natalie", LastName = "NeJame"},
                new PersonModel() {FirstName = "Seth", LastName = "NeJame"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }
            
            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress }");
            }

            Console.ReadLine();
        }
    }
}
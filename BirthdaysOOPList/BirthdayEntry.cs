using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdaysOOPList
{
    class BirthdayEntry
    {
        public string firstName;
        public string lastName;
        public string telephone;
        public DateTime dateOfBirth;

        public BirthdayEntry()
        {
            // put some sample values for the user to see, e.g.
            // firstName = "NoName"... dateOfBirth = "1900/01/01"

            this.firstName = "NoName";
            this.lastName = "NoName";
            this.telephone = "0000000000";
            this.dateOfBirth = DateTime.Parse("1900/01/01");
        }

        // overloaded constructor
        public BirthdayEntry(string firstName, string lastName, string telephone, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.telephone = telephone;
            this.dateOfBirth = dateOfBirth;
        }
        public void PrintBirthdayEntry()
        {
            Console.WriteLine($"{this.firstName}, {this.lastName}, {this.telephone}, {this.dateOfBirth.ToString()}");
        }

        public override string ToString()
        {
            return ($"{firstName} - {lastName} - {telephone} - {dateOfBirth}");
        }
    }
}

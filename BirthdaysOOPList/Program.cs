using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdaysOOPList
{
    class Program
    {
        static void Main(string[] args)
        {

            BirthdayList birthdayList = new BirthdayList(); // initializing list class

            //making a couple BirthdayEntry objects
            BirthdayEntry e1 = new BirthdayEntry(); // default values
            BirthdayEntry e2 = new BirthdayEntry("George","Mammos","34324324",Convert.ToDateTime("01/01/0001"));

            birthdayList.AddEntry(e1);
            birthdayList.AddEntry(e2);

            birthdayList.AddEntry("John", "Doe", "3432432432", Convert.ToDateTime("01/01/2000")); // add a 3rd entry without making a BirthdayEntry object beforehand

            birthdayList.PrintAll();

            birthdayList.RemoveEntry(3); //Should give out of index error message because we only have 0,1,2 atm ( i assume user knows we have zero index bounds in this scenario...)

            birthdayList.RemoveEntry(1); // Remove george

            birthdayList.PrintAll();


        }
    }
}

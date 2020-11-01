using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdaysOOPList
{
    class BirthdayList
    {
        public List<BirthdayEntry> bList = new List<BirthdayEntry>();


        // Constructors
        public BirthdayList() // empty constuctor and the one i will maily use
        {
            
        }
        public BirthdayList(BirthdayEntry initialEntry) // constructor pou douleuei me to prwto entry (pio polu gia dokimi to eftiaxa...)
        {
            bList.Add(initialEntry);            
        }

        // Methods to add new entries

        // Add a newEntry that is already a BirthdayEntry object
        public void AddEntry(BirthdayEntry newEntry)
        {
            bList.Add(newEntry);
        } 

        // Add a newEntry from string/datetime inputs 
        public void AddEntry (string firstName, string lastName, string telephone, DateTime dateOfBirth) 
        {
            BirthdayEntry newEntry = new BirthdayEntry(firstName, lastName, telephone, dateOfBirth);
            bList.Add(newEntry);
        } 


        // Methods to remove entries

        // Remove an entry at list index i 
        public void RemoveEntry (int i) 
        {
            if (i >= bList.Count)
            {
                Console.WriteLine("Index out of list bounds - unable to execute");
            }
            else
            {
                bList.RemoveAt(i);
                Console.WriteLine($"Entry at index {i} successfully removed");
            }

        }

        public void PrintAll()
        {
            Console.WriteLine("\n\n");
            for (int i = 0; i < bList.Count; i++)
            {
                bList[i].PrintBirthdayEntry();
            }
        }

    }
}

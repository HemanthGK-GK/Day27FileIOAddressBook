using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UC1AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\91807\Desktop\Batch67\UC1AddressBook\Read.txt";
            List<string> lines = new List<string>();
            List<string> output= new List<string>();
            List<Person> people = new List<Person>();

            lines = File.ReadAllLines(path).ToList();
            foreach(string line in lines)
            {
                string[] data = line.Split(',');
                Person obj = new Person(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
                people.Add(obj);
            }
            
            foreach(Person p in people)
            {
                Console.WriteLine(p);
                output.Add(p.ToString());
            }

            string newPath = @"C:\Users\91807\Desktop\Batch67\UC1AddressBook\Write.txt";
            File.WriteAllLines(newPath, output);
        }
       
    }
}

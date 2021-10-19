using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace UC2AddressBook
{
   public class Details
    {
        List<Person> people = new List<Person>();
        List<string> output = new List<string>();
        public void AddInfo()
        {
            string newPath = @"C:\Users\91807\Desktop\Batch67\Write.txt";
            
            Person obj = new Person();
            Console.Write("Enter First Name: ");
            obj.Fname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            obj.Lname = Console.ReadLine();

            Console.Write("Enter the Address: ");
            obj.Address = Console.ReadLine();

            Console.Write("Enter City name: ");
            obj.City = Console.ReadLine();

            Console.Write("Enter State name: ");
            obj.State = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            obj.Zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            obj.Phnum = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            obj.Email = Console.ReadLine();

            people.Add(obj);
            foreach (Person p in people)
            {
                Console.WriteLine(p);
                output.Add(p.ToString());
            }
            File.WriteAllLines(newPath, output);
        }
    }
       
}

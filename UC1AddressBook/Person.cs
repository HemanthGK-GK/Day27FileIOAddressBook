using System;
using System.Collections.Generic;
using System.Text;

namespace UC1AddressBook
{
    public class Person
    {
        public Person(string fname, string lname, string address, string city, string zipcode, string state, string phnum, string email)
        {
            Fname = fname;
            Lname = lname;
            Address = address;
            City = city;
            Zipcode = zipcode;
            State = state;
            Phnum = phnum;
            Email = email;
        }

       

        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }
        public string Phnum { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "Fname : " + Fname + " LastName :" + Lname + "Address : " + Address + "City : " + City + "Zipcode : " + Zipcode + "State : " + State + "Phone Num :" + Phnum + "Email : " + Email;
        }


    }
}

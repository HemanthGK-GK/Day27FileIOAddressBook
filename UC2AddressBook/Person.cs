using System;
using System.Collections.Generic;
using System.Text;

namespace UC2AddressBook
{
    public class Person
    {
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
            return "\nFname : " + Fname + "\nLastName :" + Lname + "\nAddress : " + Address + "\nCity : " + City + "\nZipcode : " + Zipcode + "\nState : " + State + "\nPhone Num :" + Phnum + "\nEmail : " + Email;
        }


    }
}

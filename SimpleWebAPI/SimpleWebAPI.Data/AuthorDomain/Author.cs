using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebAPI.Data.AuthorDomain
{
    public class Author
    {
        public Author()
        {
        }

        public Author(string firstname, string lastname, DateTime dateOfBirth, Gender gender)
        {
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public Gender Gender { get; private set; }

        public string GetFullname()
        {
            return Firstname + " " + Lastname;
        }
    }
}

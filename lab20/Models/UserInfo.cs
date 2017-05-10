using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab20.Models
{
    public class UserInfo
    {
        private string FirstName;
        private string LastName;
        private string Email;
        private string Password;


        public string UserFirstName
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public string UserLastName
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }



        public string UserEmail
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }


        }

        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Password = "";

        }

        public UserInfo(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }
}
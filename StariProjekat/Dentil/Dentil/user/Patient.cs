﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.user
{
    public class Patient
    {
        public const string regexEmail = "^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,3})+$";
        public const string regexPhone = "^\\+[0-9]+|[0-9]+$";
        public const string regexCity = "[a-zA-Z ]{2,}$";
        string id;
        string name;
        string surname;
        string email;
        string phone;
        string city;
        string street;
        int streetNum;
        string gender;

        public Patient(List<string> arr)
        {
            this.id = arr[0];
            this.name = arr[1];
            this.surname = arr[2];
            this.email = arr[3];
            this.phone = arr[4];
            this.city = arr[5];
            this.street = arr[6];
            this.streetNum = Int32.Parse(arr[7]);
            this.gender = "1".Equals(arr[8]) ? "Female" : "Male";
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public int StreetNum
        {
            get { return streetNum; }
            set { streetNum = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
            return $"{name}, {surname}";
        }
    }
}

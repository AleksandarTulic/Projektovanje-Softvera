using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.user
{
    public class User
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
        string userName;
        string bank;
        string numAccount;

        public User(string id, string name, string surname, string email, string phone, string city, string street, int streetNum, string gender, string userName, string bank, string numAccount)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.phone = phone;
            this.city = city;
            this.street = street;
            this.streetNum = streetNum;
            this.gender = gender;
            this.userName = userName;
            this.bank = bank;
            this.numAccount = numAccount;
        }

        public User(List <string> arr)
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
            this.userName = arr[9];
            this.bank = arr[10];
            this.numAccount = arr[11];
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

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Bank
        {
            get { return bank; }
            set { bank = value; }
        }

        public string NumAccount
        {
            get { return numAccount; }
            set { numAccount = value; }
        }

        public override string ToString()
        {
            return $"{name}, {surname}";
        }
    }
}

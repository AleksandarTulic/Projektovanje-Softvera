using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.elements
{
    public enum TypeELement
    {
        service,
        item
    }

    public class Elements
    {
        int id;
        string name;
        string description;
        string path;
        double cost;
        TypeELement type;
        
        public Elements(List<string> arr)
        {
            try
            {
                id = Convert.ToInt32(arr[0]);
                name = arr[1];
                cost = Convert.ToDouble(arr[2]);
                description = "null".Equals(arr[3]) ? "" : arr[3];
                path = arr[4];
                type = "service".Equals(arr[5].ToString()) ? TypeELement.service : TypeELement.item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public TypeELement Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public override string ToString()
        {
            return $"{Program.lang.translate("ID", Program.defaultLang, Program.lang.CurrLang)} = {id}, {Program.lang.translate("Name", Program.defaultLang, Program.lang.CurrLang)} = {name}, " +
                $"{Program.lang.translate("Cost", Program.defaultLang, Program.lang.CurrLang)} = {cost}, " +
                $"{Program.lang.translate("Type", Program.defaultLang, Program.lang.CurrLang)} = {type}";
        }
    }
}

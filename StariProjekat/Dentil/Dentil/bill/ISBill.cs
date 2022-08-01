using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.bill
{
    public enum ItemService
    {
        item,
        service
    }

    //item service bill
    public class ISBill
    {
        int id;
        string name;
        double cost;
        string desc;
        string path;
        ItemService type;

        public ISBill(List<string> arr)
        {
            try
            {
                id = int.Parse(arr[0]);
                name = arr[1];
                cost = double.Parse(arr[2]);
                desc = arr[3];
                path = arr[4];
                type = "item".Equals(arr[5]) ? ItemService.item : ItemService.service;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nDescription: " + ex.Message);
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

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public ItemService Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return $"{Program.lang.translate("Name", Program.defaultLang, Program.lang.CurrLang)}: {name}, " +
                $"{Program.lang.translate("Cost", Program.defaultLang, Program.lang.CurrLang)}: {cost}";
        }
    }
}

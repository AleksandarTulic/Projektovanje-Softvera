using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.problem
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Problem
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        int teeth;
        string filePath;
        string desc;
        string name;

        public Problem(int teeth, List<string> arr)
        {
            try
            {
                this.teeth = teeth;
                filePath = arr[2];
                desc = arr[1];
                name = arr[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public int Teeth
        {
            get { return teeth; }
            set { teeth = value; }
        }

        public string Description
        {
            get { return desc; }
            set { desc = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Problem))
                return false;

            Problem pr = (Problem)obj;
            return pr.Name == this.Name;
        }
    }
}

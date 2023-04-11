using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluee
{
    public class Employee
    {
        private List<String> Badges = new List<String>();
        public Employee() { }
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public int Tokens { get; set; } = 0;

        public string Description()
        {
            return " EMPLOYEE NAME: " + this.Name + " NUMBER OF POINTS: " + this.Tokens ;
        }
        public void BadgesPrint()
        {
            foreach (var b in Badges)
            {
                Console.Write(b+", ");
            }
        }
        public void AddInList(string text)
        {
            this.Badges.Add(text);
        }
        
    }
}

using bluee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace blueM
{
    public class EmployeeMgr:MrgAbstract
    {
        //initialize the employees list
        public void InitEmployee()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Employee.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/employee/Employee");
            foreach (XmlNode nod in lista_noduri)
            {
                string name = nod["Name"].InnerText;
                employees.Add(new Employee(name));
            }
        }
    }
}

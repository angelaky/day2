using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentFactory studentsfactory = new StudentFactory();
            Students student = studentsfactory.Create("anna");
            Students student1 = studentsfactory.Create("gogo");

            //Students student = new Students("gogo");

            XmlDocument studentsXML = new XmlDocument();
            XmlNode rootNode = studentsXML.CreateElement("students");
            studentsXML.AppendChild(rootNode);

            XmlNode userNode = studentsXML.CreateElement("student");
            XmlAttribute attribute = studentsXML.CreateAttribute("id");
            attribute.Value = student.ID.ToString();
            userNode.Attributes.Append(attribute);
            userNode.InnerText = student.Name;
            rootNode.AppendChild(userNode);

            userNode = studentsXML.CreateElement("student");
            attribute = studentsXML.CreateAttribute("id");
            attribute.Value = student1.ID.ToString();
            userNode.Attributes.Append(attribute);
            userNode.InnerText = student1.Name;
            rootNode.AppendChild(userNode);

            studentsXML.Save("../../test-doc.xml");




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Root xmlsystem = new XmlDocument("XML_system");

            XmlDocument document = new XmlDocument("Book");
            XmlElement title = new XmlElement("C#_4.0");
            XmlElement author = new XmlElement("Rihter");
            XmlElement year = new XmlElement("2014");
            XmlElement price = new XmlElement("100");

            document.Add(title);
            document.Add(author);
            document.Add(year);
            document.Add(price);

            XmlDocument document2 = new XmlDocument("Book");
            XmlElement title2 = new XmlElement("C++");
            XmlElement author2 = new XmlElement("Shild");
            XmlElement year2 = new XmlElement("2016");
            XmlElement price2 = new XmlElement("160");

            document2.Add(title2);
            document2.Add(author2);
            document2.Add(year2);
            document2.Add(price2);

            xmlsystem.Add(document);
            xmlsystem.Add(document2);
            xmlsystem.Print();

            Console.ReadKey();
        }
    }
}

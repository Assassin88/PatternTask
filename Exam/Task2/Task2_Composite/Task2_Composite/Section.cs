using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Composite
{
    internal class Section : IPage, IElement<Page>
    {
        private readonly IList<Page> _listPage = new List<Page>();
        public string Description { get; set; }
        public string Title { get; set; }

        internal IList<Page> ListPage => _listPage;

        public Section(string title, string description)
        {
            Title = title;
            Description = description;
        }

        /// <summary>
        /// Add item to the collection
        /// </summary>
        /// <param name="item"></param>
        public void AddElement(Page item)
        {
            ListPage.Add(item);
        }

        /// <summary>
        /// Remove item to the collection
        /// </summary>
        /// <param name="item"></param>
        public void RemoveElement(Page item)
        {
            ListPage.Remove(item);
        }

        /// <summary>
        /// Show the structure of a page
        /// </summary>
        public void ShowPage()
        {
            Console.WriteLine("\n<!DOCTYPE html>\n" +
                "<html>\n" +
                "<head>\n" +
                "\t<title> {0} </title >\n" +
                "\t<meta charset = utf-8 />\n" +
                "</head>\n" +
                "<body>\n" + 
                "\t<p>\n\t     {1}\n\t</p>\n" +
                "</body>\n</html\n{2}\n", Title, Description, new String('-',35));
        }

    }
}

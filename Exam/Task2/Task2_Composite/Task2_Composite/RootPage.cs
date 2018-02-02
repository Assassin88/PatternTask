using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Composite
{
    internal class RootPage : IElement<Section>
    {
        private readonly IList<Section> _listSection = new List<Section>();

        internal IList<Section> ListSection => _listSection;

        /// <summary>
        /// Add item to the collection
        /// </summary>
        /// <param name="item"></param>
        public void AddElement(Section item)
        {
            ListSection.Add(item);
        }

        /// <summary>
        /// Remove item to the collection
        /// </summary>
        /// <param name="item"></param>
        public void RemoveElement(Section item)
        {
            ListSection.Remove(item);
        }

        /// <summary>
        /// Show the structure of a tree
        /// </summary>
        public void Scan()
        {
            foreach (var section in ListSection)
            {
                foreach (var page in section.ListPage)
                {
                    page.ShowPage();
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void ChangeDelegate(string input);

    public class ListTracker
    {
        public event ChangeDelegate OnChange;

        public ListTracker()
        {
            this.List = new List<int>();
        }

        public List<int> List { get; set; }
            
        public void Add(int element)
        {
            this.List.Add(element);
            this.OnChange();
        }
    }
}

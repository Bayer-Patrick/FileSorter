using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateiSortierer.Strategy
{
    class SortManager
    {
        private static SortManager instance = null;

        public ISort SortMethode { get; set; } = new SortDate();

        /**private ISort sortMethod = new SortDate();
        public ISort SortMethod
        {
            get { return sortMethod; }
            set { sortMethod = value; }
        }**/

        private SortManager() { }

        public static SortManager GetInstance()
        {
            if (instance == null)
                instance = new SortManager();
            return instance;
        }

        public void Sort(string source, string target)
        {
            SortMethode.Execute(source, target);
        }


    }
}

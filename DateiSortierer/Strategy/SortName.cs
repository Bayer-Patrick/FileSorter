using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateiSortierer.Strategy
{
    class SortName : ISort
    {
        public void Execute(string source, string target)
        {
            Console.WriteLine("SortName");
        }
    }
}

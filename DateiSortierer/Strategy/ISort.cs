using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateiSortierer.Strategy
{
    interface ISort
    {
        void Execute(string source, string target);
    }
}

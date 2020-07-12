using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateiSortierer.Strategy
{
    class SortDate : ISort
    {
        public void Execute(string source, string target)
        {
            Console.WriteLine("SortDate");

            string[] files = Directory.GetFiles(source);

            foreach (string s in files)
            {
                string creationTime = Convert.ToString(File.GetCreationTime(s)).Replace(':','-');
                int start = s.LastIndexOf('.');
                int lengthOfFileType = s.Length - start;
                string fileType = s.Substring(start, lengthOfFileType);

                StringBuilder sb = new StringBuilder();
                sb.Append(target);
                sb.Append(@"\");
                sb.Append(creationTime);
                sb.Append(fileType);

                string finishPath = sb.ToString();

                if (!File.Exists(finishPath))
                {
                    File.Copy(s, finishPath);
                }
                else
                {
                    int count = 1;
                    while (true)
                    {
                        StringBuilder sb2 = new StringBuilder();
                        sb2.Append(target);
                        sb2.Append(@"\");
                        sb2.Append(creationTime);
                        sb2.Append("(");
                        sb2.Append(count);
                        sb2.Append(")");
                        sb2.Append(fileType);

                        string fullFinishPath = sb2.ToString();

                        if (!File.Exists(fullFinishPath))
                        {
                            File.Copy(s, fullFinishPath);
                            break;
                        }
                        count++;
                    }
                }
            }
        }
    }
}

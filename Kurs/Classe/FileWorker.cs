using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Kurs.Classe
{
    public class FileWorker
    {
        public List<string> ReadBD(string path)
        {
            List<string> bdArray = new List<string>();

            string rowData1 = File.ReadAllText(path, Encoding.UTF8).Trim();

            if (rowData1 != "")
            {
                string[] rowData2 = rowData1.Trim().Split('\n');
                foreach (string item in rowData2)
                {
                    bdArray.Add(item);
                }
            }

            return bdArray;
        }

        public void SaveBD(string path)
        {
            File.WriteAllText(path, String.Join("\n", Vars.bdArray));
        }


    }
}

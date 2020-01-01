using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Classe;

namespace Kurs.Classe
{
    class Reader
    {
        public static List<Sportsmen> Read(string path)
        {
            List<Sportsmen> list = new List<Sportsmen>();
            string[] lines = File.ReadAllLines(path + ".txt", Encoding.GetEncoding("windows-1251"));

            foreach (string line in lines)
            {
                Sportsmen process = new Sportsmen();
                string[] pol = line.Split(' ');

                process.Country = pol[0];
                process.FirstName = pol[1];
                process.LastName = pol[2];
                process.Age = int.Parse(pol[4]);
                process.KindSport = pol[3];

                list.Add(process);
            }

            return list;
        }
    }
}

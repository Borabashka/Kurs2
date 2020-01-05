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
    class DataBase
    {
        public static string Return(string path)    //вывод бд + //вывод базы данных
        {//
            string list = "Страна-участница  Фамилия_и_имя_участника Возраст  Вид_спорта" + "\n";
            List<string> lines = new List<string>();
            List<Sportsmen> process = Reader.Read(path);
            

            foreach (Sportsmen pr in process)
            {
               
                lines.Add("\r\n" + pr.Country + " " + pr.FirstName + " " + pr.LastName + " " + pr.KindSport + " " + pr.Age );
            }
            list += string.Join("", lines);
            return list;
        }
        public static void CrDB(string path, bool par)
        {
            if (par == true)
            {
                if (File.Exists(path + ".txt") == false) { File.Create(path + ".txt").Close(); } //создание удаление базы данных +
            }
            else
            {
                if (File.Exists(path + ".txt") == true) { File.Delete(path + ".txt"); }
            }
        }
        public static void New(Sportsmen process, string path) // добавляет новый элемент  класса 
        {
            File.AppendAllText(path + ".txt", process.Country + " " + process.FirstName + " " + process.LastName + " " + process.KindSport + " " + process.Age  + "\n", Encoding.GetEncoding("windows-1251")); //добавление процесса в бд +
        }
    }
}

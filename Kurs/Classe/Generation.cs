using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs.Classe
{
    class Generation
    {
        public static Sportsmen Gen(Sportsmen process, string Country, string FirstName, string LastName, string KindSport, string Age)
        {
            process.Country = Country;
            process.FirstName = FirstName;
            process.LastName = LastName;
            process.KindSport = KindSport;
            process.Age = int.Parse(Age);
            return process;
        }
        public static Sportsmen randGen(Sportsmen process)
        {
            string[] massCountry = { "Германия", "Франция", "Италия", "Россия", "Япония", "Швеция", "Норвегия" };
            Random rand = new Random();

            string[] massFirstName = { "Александр", "Владимир", "Игорь", "Владислав", "Пётр", "Сергей", "Андрей" };
            Random rand2 = new Random();

            string[] massLastName = { "Иванов", "Смирнов", "Кузнецов", "Васильев", "Соколов", "Волков", "Алексеев" };
            Random rand3 = new Random();

            string[] massKindSport = { "Биатлон", "Бобслей"};
            Random rand4 = new Random();

            Random x = new Random();
            int n = x.Next(25, 50);

            process.Country = massCountry[rand.Next(0, 6)];
            process.FirstName = massFirstName[rand2.Next(0, 6)];
            process.LastName = massLastName[rand3.Next(0, 6)];
            process.KindSport = massKindSport[rand4.Next(0, 1)];
            process.Age = n;
          
            return process;
        }
    }
}

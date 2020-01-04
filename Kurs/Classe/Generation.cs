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
        public static Sportsmen Gen(Sportsmen sportsmen, string Country, string FirstName, string LastName, string KindSport, string Age)
        {
            sportsmen.Country = Country;
            sportsmen.FirstName = FirstName;
            sportsmen.LastName = LastName;
            sportsmen.KindSport = KindSport;
            sportsmen.Age = int.Parse(Age);
            return sportsmen;
        }
        public static Sportsmen randGen(Sportsmen sportsmen)
        {
            Random rand = new Random();

            string[] massCountry = { "Германия", "Франция", "Италия", "Россия", "Япония", "Швеция", "Норвегия" };
            string[] massFirstName = { "Александр", "Владимир", "Игорь", "Владислав", "Пётр", "Сергей", "Андрей" };
            string[] massLastName = { "Иванов", "Смирнов", "Кузнецов", "Васильев", "Соколов", "Волков", "Алексеев" };
            string[] massKindSport = { "Биатлон", "Бобслей", "Лыжи"};

            int n = rand.Next(25, 51);


            sportsmen.Country = massCountry[rand.Next(0, massCountry.Length)];
            sportsmen.FirstName = massFirstName[rand.Next(0, massFirstName.Length)];
            sportsmen.LastName = massLastName[rand.Next(0, massLastName.Length)];
            sportsmen.KindSport = massKindSport[rand.Next(0, massKindSport.Length)];
            sportsmen.Age = n;
          
            return sportsmen;
        }
    }
}

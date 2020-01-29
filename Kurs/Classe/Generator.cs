using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs.Classe
{
    class Generator
    {
        #region InfoBase

        string[] countryArray = { "Japan", "Germany", "Russian", "French", "Gr. Britain", "USA", "Canada" };

        string[] JapanNameArray = { "Ai", "Aiko", "Akako", "Akane", "Akemi", "Aki", "Chika", "Chikako ", "Cho ", "Dai ", "Hoshi ", "Akeno ", "Akiyama ", "Fudo ", "Naruto ", "Sasuke ", "Botan ", "Daiki ", "Haru ", "Jiro ", "Kanaye ", "Kano ", "Kazuo ", "Rafu ", "Nikk" };
        string[] JapanSurnameArray = { "Sato", "Sudjuki", "Ito", "Yamat", "Kato", "Sasaki", "Uchiha", "Uzumaki", "Yamaguti", "Hayasi", "Abe", "Goto", "Ocade", "Ono", "Takano", "Seke", "Homma" };

        string[] GermanyNameArray = { "Adolf", "Ben", "Paul", "Jonas", "Elias", "Leon", "Finn", "Fynn", "Noah", "Luis", "Luke", "Felix", "Luca", "Maximilian", "Henry", "Max", "Oskar", "Emil", "Liam", "Jacob", "Moritz", "Anton", "Mia", "Emma", "Sofia", "Lina", "Mila", "Amelie", "Lilly" };
        string[] GermanySurnameArray = { "Miller", "Scholz", "Tailor", "Weaver", "Baker", "Koch", "Bauer", "Richter", "Klein", "Wolf", "Schwarz", "Lange", "Werner", "Krause", "Maier", "Jung", "Hneitler", "Friedrich", "Frank", "Roth", "Beck", "Lorenz", "Franke" };

        string[] RussianNameArray = { "Alexander", "Alexey", "Anton", "Andrei", "Artur", "Bogdan", "Boris", "Valeriy", "Vitaliy", "Gleb", "Grigoriy", "Denis", "Zahar", "Ivan", "Ignat", "Igor", "Kirill", "Oksana", "Lara", "Olesya", "Yuliya" };
        string[] RussianSurnameArray = { "Smirnov", "Popov", "Kuznecov", "Sobolev", "Maslov", "Moiseev", "Shukin", "Sidorov", "Egorov", "Savin", "Guseev", "Titon", "Shilov", "Mishin", "Phokin", "Nosov" };

        string[] FrenchNameArray = { "Arno", "Jean", "Michel", "Alain", "Patrick", "Nicolas", "Christian", "Daniel", "Pierre", "Aim", "Bles", "Gustav", "Camill", "Rafael", "Natali", "Lulu", "Lor", "Clar", "Adel", "Anet", "Agata" };
        string[] FrenchSurnameArray = { "Azule", "Arno", "Arkur", "Arias", "Buzho", "Bosh", "Benua", "Zharr", "Dumash", "Labule", "Ledu", "Mereli", "Peti", "Reber" };

        string[] EnNameArray = { "Amelia", "Olivia", "Oliver", "Jack", "Harry", "Jacob", "Charlie", "Thomas", "Oscar", "William", "James", "George", "Alfie", "Leo", "Henry", "Max", "Jake", "Lola", "Holly", "Lilly", "Rosie" };
        string[] EnSurnameArray = { "Abramson", "Adderiy", "Howard", "Holiday", "Jeff", "Jenkin", "Batton", "Alsopp", "Andrews", "Arnold", "Kelly", "Page", "Day", "Derrick", "Ralphs", "Ryder", "Young", "Haig" };

        string[] CanadaNameArray = { "Carter", "Daniel", "Felix", "Gabriel", "Jacob", "Antoine", "Alexis", "Liam", "Mason", "Noah", "Olivier", "Owen", "Lucas", "Tyler", "William", "Hailey", "Jessica", "Lea" };
        string[] CanadaSurnameArray = { "Abramson", "Adderiy", "Howard", "Holiday", "Jeff", "Jenkin", "Batton", "Alsopp", "Andrews", "Arnold", "Kelly", "Page", "Day", "Derrick", "Ralphs", "Ryder", "Young", "Haig" };

        string[] Sport = { "Biathlon", "Bobsleigh", "Curling", "Snowboard", "Ski race", "Skiing", };
        #endregion


        public List<string> RandomGenElement()
        {
            // 0-Country 1-Name 2-Surname 3-Age 4-Sport 5-Gold 6-Silver 7-Bronze
            List<string> newElement = new List<string>();
            newElement.Add("");
            newElement.Add("");
            newElement.Add("");
            newElement.Add("");
            newElement.Add("");
            newElement.Add("");
            newElement.Add("");
            newElement.Add("");

            Random random = new Random();

            newElement[0] = countryArray[random.Next(0, countryArray.Length)];
            switch (newElement[0])
            {
                case "Japan":
                    newElement[1] = JapanNameArray[random.Next(0, JapanNameArray.Length)];
                    newElement[2] = JapanSurnameArray[random.Next(0, JapanSurnameArray.Length)];
                    break;
                case "Germany":
                    newElement[1] = GermanyNameArray[random.Next(0, GermanyNameArray.Length)];
                    newElement[2] = GermanySurnameArray[random.Next(0, GermanySurnameArray.Length)];
                    break;
                case "Russian":
                    newElement[1] = RussianNameArray[random.Next(0, RussianNameArray.Length)];
                    newElement[2] = RussianSurnameArray[random.Next(0, RussianSurnameArray.Length)];
                    break;
                case "French":
                    newElement[1] = FrenchNameArray[random.Next(0, FrenchNameArray.Length)];
                    newElement[2] = FrenchSurnameArray[random.Next(0, FrenchSurnameArray.Length)];
                    break;
                case "Gr. Britain":
                    newElement[1] = EnNameArray[random.Next(0, EnNameArray.Length)];
                    newElement[2] = EnSurnameArray[random.Next(0, EnSurnameArray.Length)];
                    break;
                case "USA":
                    newElement[1] = EnNameArray[random.Next(0, EnNameArray.Length)];
                    newElement[2] = EnSurnameArray[random.Next(0, EnSurnameArray.Length)];
                    break;
                case "Canada":
                    newElement[1] = CanadaNameArray[random.Next(0, CanadaNameArray.Length)];
                    newElement[2] = CanadaSurnameArray[random.Next(0, CanadaSurnameArray.Length)];
                    break;
            }

            newElement[3] = random.Next(25, 51).ToString();
            newElement[4] = Sport[random.Next(0, Sport.Length)];
            newElement[5] = random.Next(0, 8).ToString();
            newElement[6] = random.Next(0, 14).ToString();
            newElement[7] = random.Next(0, 21).ToString();

            return newElement;
        }
    }
}

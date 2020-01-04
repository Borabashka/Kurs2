using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Properties;

namespace Kurs.Classe
{
    public class UICreator
    {

        public Panel General(string rowData)
        {
            string[] Data = rowData.Split(' ');
            string country = Data[0];
            string name = Data[1];
            string surname = Data[2];
            string age = Data[3];
            string sport = Data[4];
            string gold = Data[5];
            string silver = Data[6];
            string bronze = Data[7];


            // главная панель
            Panel MainPanel = new Panel();
            MainPanel.Width = 280;
            MainPanel.Height = 82;
            MainPanel.BackColor = Color.RoyalBlue;
            MainPanel.BringToFront();

            // страна
            Label countrylab = new Label();
            countrylab.Text = country;
            countrylab.Width = 130;
            countrylab.ForeColor = Color.White;
            countrylab.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            countrylab.Location = new Point(1, 1);

            // фамилия + имя + возраст
            Label namelab = new Label();
            namelab.Text = surname + " " + name;
            namelab.Width = 130;
            namelab.ForeColor = Color.White;
            namelab.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            namelab.Location = new Point(1, 20);

            // возраст
            Label agelab = new Label();
            agelab.Text = "Возраст " + age;
            agelab.Width = 130;
            agelab.ForeColor = Color.White;
            agelab.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            agelab.Location = new Point(1, 39);

            // возраст
            Label sportlab = new Label();
            sportlab.Text = sport;
            sportlab.Width = 130;
            sportlab.ForeColor = Color.White;
            sportlab.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            sportlab.Location = new Point(1, 58);

            // золото
            PictureBox goldimage = new PictureBox();
            goldimage.Size = new Size(30, 30);
            goldimage.Image = Resources.gold;
            goldimage.SizeMode = PictureBoxSizeMode.Zoom;
            goldimage.Location = new Point(140, 5);

            Label goldlab = new Label();
            goldlab.Text = gold;
            goldlab.TextAlign = ContentAlignment.MiddleCenter;
            goldlab.Width = 30;
            goldlab.Height = 15;
            goldlab.ForeColor = Color.White;
            goldlab.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            goldlab.Location = new Point(140, 40);


            // серебро
            PictureBox silverimage = new PictureBox();
            silverimage.Size = new Size(30, 30);
            silverimage.Image = Resources.silver;
            silverimage.SizeMode = PictureBoxSizeMode.Zoom;
            silverimage.Location = new Point(180, 5);

            Label silverlab = new Label();
            silverlab.Text = silver;
            silverlab.TextAlign = ContentAlignment.MiddleCenter;
            silverlab.Width = 30;
            silverlab.Height = 15;
            silverlab.ForeColor = Color.White;
            silverlab.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            silverlab.Location = new Point(180, 40);


            // бронза
            PictureBox bronzeimage = new PictureBox();
            bronzeimage.Size = new Size(30, 30);
            bronzeimage.Image = Resources.bronze;
            bronzeimage.SizeMode = PictureBoxSizeMode.Zoom;
            bronzeimage.Location = new Point(220, 5);

            Label bronzelab = new Label();
            bronzelab.Text = bronze;
            bronzelab.TextAlign = ContentAlignment.MiddleCenter;
            bronzelab.Width = 30;
            bronzelab.Height = 15;
            bronzelab.ForeColor = Color.White;
            bronzelab.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            bronzelab.Location = new Point(220, 40);

            // кнопка выбора
            PictureBox edit = new PictureBox();
            edit.Size = new Size(30, 30);
            edit.Image = Resources.right_arrow;
            edit.SizeMode = PictureBoxSizeMode.Zoom;
            edit.Location = new Point(140, 5);

            edit.MouseEnter += new EventHandler(Edit_MouseEnter);




            // функции кнопок
            void Edit_MouseEnter(object sender, EventArgs e)
            {

            }



            MainPanel.Controls.Add(countrylab);
            MainPanel.Controls.Add(namelab);
            MainPanel.Controls.Add(agelab);
            MainPanel.Controls.Add(sportlab);

            MainPanel.Controls.Add(goldimage);
            MainPanel.Controls.Add(silverimage);
            MainPanel.Controls.Add(bronzeimage);

            MainPanel.Controls.Add(goldlab);
            MainPanel.Controls.Add(silverlab);
            MainPanel.Controls.Add(bronzelab);

                                                         
            return MainPanel;
        }

        private string Join()
        {
            throw new NotImplementedException();
        }
    }
}

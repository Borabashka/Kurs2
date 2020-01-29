using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Classe;

namespace Kurs
{
    public partial class Tab1 : UserControl
    {
        public Tab1()
        {
            InitializeComponent();
            InitializeImages();
        }

        void InitializeImages()
        {
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);

        }
        public void SelectElement()
        {
            string[] selectedInfo = Vars.bdArray[Vars.CurrentNumber].Split('_');

            Country.Text = selectedInfo[0];
            NameText.Text = selectedInfo[1];
            Surname.Text = selectedInfo[2];
            Age.Text = selectedInfo[3];
            Sport.Text = selectedInfo[4];

            Gold.Text = selectedInfo[5];
            Silver.Text = selectedInfo[6];
            Bronze.Text = selectedInfo[7];


        }

        private void RandomBut_Click(object sender, EventArgs e)
        {
            Generator generator = new Generator();

            List<string> Data = generator.RandomGenElement();

            Country.Text = Data[0];
            NameText.Text = Data[1];
            Surname.Text = Data[2];
            Age.Text = Data[3];
            Sport.Text = Data[4];

            Gold.Text = Data[5];
            Silver.Text = Data[6];
            Bronze.Text = Data[7];

        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            SaveBut.Enabled = false;

            string[] infoList = { Country.Text, NameText.Text, Surname.Text, Age.Text, Sport.Text, Gold.Text, Silver.Text, Bronze.Text };
            Vars.bdArray[Vars.CurrentNumber] = String.Join("_", infoList);
        }

        private void NewBut_Click(object sender, EventArgs e)
        {
            NewBut.Enabled = false;

            string[] infoList = { Country.Text, NameText.Text, Surname.Text, Age.Text, Sport.Text, Gold.Text, Silver.Text, Bronze.Text };
            Vars.bdArray.Add(String.Join("_", infoList));
        }

        private void DelBut_Click(object sender, EventArgs e)
        {
            DelBut.Enabled = false;

            Vars.bdArray.Remove(Vars.bdArray[Vars.CurrentNumber]);
        }





        string oldData = "pass";
        private void SelectCheck_Tick(object sender, EventArgs e)
        {
            if (!(Vars.bdArray[Vars.CurrentNumber] == oldData))
            {
                oldData = Vars.bdArray[Vars.CurrentNumber];
                SelectElement();
            }
        }
    }
}

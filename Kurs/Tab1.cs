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

        private void RandomBut_Click(object sender, EventArgs e)
        {
            Generator generator = new Generator();

            List<string> Data = generator.RandomGenElement();

            Country.Text = Data[0];
            NameText.Text =    Data[1];
            Surname.Text = Data[2];
            Age.Text =     Data[3];
            Sport.Text =   Data[4];

            Gold.Text =    Data[5];
            Silver.Text =  Data[6];
            Bronze.Text =  Data[7];

        }
    }
}

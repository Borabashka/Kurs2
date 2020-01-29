using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Classe;

namespace Kurs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, 0, 0, 0);
        }

        // switch form buttons
        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr2 = new Form3();
            fr2.Show();
        }
        private void Last_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 kb1 = new Form1();
            kb1.Show();
        }
       

        // bd actions buttons
        private void Random_Click(object sender, EventArgs e)
        {
            Sportsmen process = new Sportsmen();
            //DataBase.New(Classe.Generator(process), NameDatabase.Text);
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            Sportsmen process = new Sportsmen();
            if (Country.Text != "" && FirstName.Text != "" && LastName.Text != "" && KindSport.Text != "" && Age.Text != "")
            {
                //DataBase.New(Classe.Generator.Gen(process, Country.Text, FirstName.Text, LastName.Text, KindSport.Text, Age.Text), NameDatabase.Text);
                Country.Clear();
                FirstName.Clear();
                LastName.Clear();
                KindSport.Clear();
                Age.Clear();
               
                
            }
        }
    }
}

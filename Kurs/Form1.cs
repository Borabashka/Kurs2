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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameDatabase_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(125,0,0,0);

        }

        private void DeleteDatabase_Click(object sender, EventArgs e)
        {
            if (File.Exists(NameDatabase.Text + ".txt") == true)
            {
                DataBase.CrDB(NameDatabase.Text, false);
                NameDatabase.Clear();
            }
        }

        private void CreateDatabase_Click(object sender, EventArgs e)
        {
            if (File.Exists(NameDatabase.Text + ".txt") == false)
            {
                DataBase.CrDB(NameDatabase.Text, true);
                NameDatabase.Clear();
            }
        }
    }
}

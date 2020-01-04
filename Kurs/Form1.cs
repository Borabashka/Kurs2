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
            InitializeControls();
        }

        BDList bdlist = new BDList();
        public void InitializeControls()
        {
            panel1.BackColor = Color.FromArgb(125, 0, 0, 0);

            // настройка второй формы
            bdlist.Location = new Point(0, 0);
            bdlist.Visible = false;
            this.Controls.Add(bdlist);
            bdlist.BringToFront();
        }


        private void Next_Click(object sender, EventArgs e)
        {
            bdlist.Visible = true;
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

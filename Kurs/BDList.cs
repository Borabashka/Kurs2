using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Classe;

namespace Kurs
{//
    public partial class BDList : UserControl
    {
        FileWorker fileWorker = new FileWorker();
        UICreator ui = new UICreator();

        public BDList()
        {
            InitializeComponent();
            InitializeTabControl();

            BackBut.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        public void UpdateBD(object sender, EventArgs e)
        {
            string path = NameDataBase.Text + ".txt";

            // записываем новую бд
            fileWorker.SaveBD(path);

            (sender as Button).Enabled = true;
            NameDatabase_TextChanged(null, null);
        }

        



        public void DeleteList()
        {
            ElementsPanel.Width = 286;
            ElementsPanel.Visible = false;

            foreach (Panel item in ElementsPanel.Controls.OfType<Panel>())
            {
                ElementsPanel.Controls.Remove(item);
                Application.DoEvents();
            }

            if ((ElementsPanel.Controls.OfType<Panel>()).Count<Panel>() > 0)
            {
                DeleteList();
            }
        }

        public void CreatePanel_General()
        {
            DeleteList();

            foreach (string item in Vars.bdArray)
            {
                ElementsPanel.Controls.Add(ui.GeneralDataList(item));
                Application.DoEvents();
            }

            if (Vars.bdArray.Count > 4) ElementsPanel.Width += 20;

            ElementsPanel.Visible = true;

            // Обнуление перемнных
            tab1.SelectCheck.Enabled = true;
            ui.number = 0;
            ui.first = true;
        }

        private void NameDatabase_TextChanged(object sender, EventArgs e)
        {
            BdInfo.Visible = false;
            DeleteList();

            if (File.Exists(NameDataBase.Text + ".txt"))
            {
                tab1.NewBut.Enabled = true;

                Vars.bdArray = fileWorker.ReadBD(NameDataBase.Text + ".txt");

                if (Vars.bdArray.Count == 0)
                {
                    BdInfo.Text = "Выбранная база данных пуста";
                    BdInfo.Visible = true;
                    ElementsPanel.Visible = false;

                    tab1.SelectCheck.Enabled = false;
                    tab1.DelBut.Enabled = false;
                    tab1.SaveBut.Enabled = false;
                }
                else
                {
                    // TODO Create panels + unblock tabcontrol
                    CreatePanel_General();

                    tab1.DelBut.Enabled = true;
                    tab1.SaveBut.Enabled = true;
                }
            }
            else
            {
                BdInfo.Text = "Такой базы данных не существует";
                BdInfo.Visible = true;

                tab1.NewBut.Enabled = false;
                ElementsPanel.Visible = false;

                tab1.SelectCheck.Enabled = false;
                tab1.DelBut.Enabled = false;
                tab1.SaveBut.Enabled = false;
            }
        }

        #region TabControl
        //CustomTabControl
        Tab1 tab1 = new Tab1();
        Tab2 tab2 = new Tab2();
        Tab3 tab3 = new Tab3();

        Button CurrentTabSender;



        void InitializeTabControl()
        {
            Transform(TabBut1);

            tab1.Location = new Point(324, 69);
            tab1.BackColor = Color.FromArgb(125, 0, 0, 0);

            tab1.SaveBut.Click += new EventHandler(UpdateBD);
            tab1.NewBut.Click += new EventHandler(UpdateBD);
            tab1.DelBut.Click += new EventHandler(UpdateBD);


            tab2.Location = new Point(324, 69);
            tab2.BackColor = Color.FromArgb(125, 0, 0, 0);
            tab2.Visible = false;

            tab3.Location = new Point(324, 69);
            tab3.BackColor = Color.FromArgb(125, 0, 0, 0);
            tab3.Visible = false;

            Controls.Add(tab1);
            Controls.Add(tab2);
            Controls.Add(tab3);
        }

        // help functions
        void DisableAll()
        {
            // reset color
            (CurrentTabSender as Button).BackColor = Color.FromArgb(255, 201, 201, 201);

            // reset transform
            CurrentTabSender.Location = new Point(CurrentTabSender.Location.X + 2, CurrentTabSender.Location.Y + 2);
            CurrentTabSender.Size = new Size(60, 30);
            Application.DoEvents();

            //reset tab panel
            tab1.Visible = false;
            tab2.Visible = false;
            tab3.Visible = false;
        }
        private void Transform(object sender)
        {
            CurrentTabSender = (sender as Button);
            CurrentTabSender.BackColor = Color.FromArgb(255, 123, 165, 240);
            CurrentTabSender.BringToFront();
            CurrentTabSender.Size = new Size(64, 32);

            CurrentTabSender.Location = new Point(CurrentTabSender.Location.X - 2, CurrentTabSender.Location.Y - 2);
            Application.DoEvents();
        }

        // buttons click
        private void TabBut1_Click(object sender, EventArgs e)
        {
            DisableAll();
            tab1.Visible = true;

            Transform(sender);
        }
        private void TabBut2_Click(object sender, EventArgs e)
        {
            DisableAll();
            tab2.Visible = true;

            Transform(sender);
        }
        private void TabBut3_Click(object sender, EventArgs e)
        {
            DisableAll();
            tab3.Visible = true;

            Transform(sender);
        }
        #endregion

        #region Back Button
        private void BackBut_Click(object sender, EventArgs e)
        {
            Visible = false;
            NameDataBase.Text = "";
        }
        private void BackBut_Enter(object sender, EventArgs e)
        {
            BackBut.Image = Properties.Resources.Back_Active;
        }
        private void BackBut_Leave(object sender, EventArgs e)
        {
            BackBut.Image = Properties.Resources.Back_Default;
        }
        #endregion
    }
}

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
{
    public partial class BDList : UserControl
    {
        FileWorker fileWorker = new FileWorker();
        UICreator uICreator = new UICreator();

        List<string> bdArray = new List<string>(); // построчный массив базы данных


        public BDList()
        {
            InitializeComponent();
        }

        public void DeleteList()
        {
            foreach (Panel item in ElementsPanel.Controls.OfType<Panel>())
            {
                ElementsPanel.Controls.Remove(item);
            }

            if ((ElementsPanel.Controls.OfType<Panel>()).Count<Panel>() > 0)
            {
                DeleteList();
            }

        }

        public void CreatePanel_General()
        {
            DeleteList();

            foreach (string item in bdArray)
            {
                ElementsPanel.Controls.Add(uICreator.General(item));
            }
        }

        private void NameDatabase_TextChanged(object sender, EventArgs e)
        {
            BdInfo.Visible = false;
            DeleteList();

            if (File.Exists(NameDataBase.Text + ".txt"))
            {
                bdArray = fileWorker.ReadBD(NameDataBase.Text + ".txt");

                if (bdArray.Count <= 1)
                {
                    BdInfo.Text = "Выбранная база данных пуста";
                    BdInfo.Visible = true;
                }
                else
                {
                    // TODO Create panels + unblock tabcontrol
                    CreatePanel_General();
                }
            }
            else
            {
                BdInfo.Text = "Такой базы данных не существует";
                BdInfo.Visible = true;
            }
        }
    }
}

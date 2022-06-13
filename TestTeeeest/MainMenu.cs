using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTeeeest
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Program.Control.MainMenu = this;
            UpdateDiseasesList();
        }

        public void UpdateDiseasesList()         //Вывод считанных болезней из базы в поле(ListBox), где их может выбрать пользователь
        {
            List<Disease> list = Program.Control.Diseases;
            foreach (Disease dis in list)
                listBox_diseases.Items.Add(dis.Name_);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)        //Переход к меню профиля
        {
            if (Program.Control.ProfileMenu == null)
                Program.Control.ProfileMenu = new Profile_Menu();
            this.Hide();
            Program.Control.ProfileMenu.Show();
        }


        private void button7_Click(object sender, EventArgs e)   //Переход к меню поиска
        {
            Hide();
            if (Program.Control.Search != null)
                Program.Control.Search.Show();
            else
            {
                SearchMenu s = new SearchMenu();
                s.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e) //При закрытии формы, закрывается приложение
        {
            Application.Exit();
        }

       

        private void button_diseases_Click(object sender, EventArgs e)          //Кнопка,производящая вывод выбранной болезни
        {
            if (listBox_diseases.SelectedItem == null)
                MessageBox.Show("Не выбрана болезнь из списка");
            else
            {
                if (Program.Control.DiseaseInfo == null)
                    Program.Control.DiseaseInfo = new DiseaseFlexible(listBox_diseases.SelectedItem);
                    Program.Control.DiseaseInfo.Show();
                    Program.Control.DiseaseInfo = null;
            }
        }
    }
}


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

namespace TestTeeeest
{
    public partial class SearchMenu : Form
    {
        public SearchMenu()
        {
            InitializeComponent();
            Program.Control.Search = this;       //Хранение одной и той же ссылки на поиск
        }

        private void button1_Click(object sender, EventArgs e)  //Переход в главное меню
        {
            {
                Hide();
                Program.Control.MainMenu.Show();
            }
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)        //Кнопка, по которой проверяется, на какие симптомы поставлены галочки
        {                                                             //Соответствующий симптом ищется в полях класса
            List<Disease> list = Program.Control.Diseases;
            foreach (Disease dis in list)
                foreach (string s in checkedListBox1.CheckedItems)
                    if (dis.Sympthoms_.Contains(s) == true)
                    {
                        MessageBox.Show("Симптому «" + s + "» соответствует болезнь " + dis.Name_);
                    }
            if (checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ни один из симптомов не выбран для поиска");
            }
            
         
        }

        private void SearchMenu_FormClosing(object sender, FormClosingEventArgs e) //При закрытии формы, закрывается приложение
        {
            Application.Exit();
        }
    }
}

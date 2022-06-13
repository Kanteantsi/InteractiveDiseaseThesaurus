using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TestTeeeest
{
    public partial class DiseaseFlexible : Form
    {
        public DiseaseFlexible(object name)
        {
            InitializeComponent();
            Disease dis = Program.Control.Diseases.Find(x => x.Name_ == name.ToString());   
            button1.Text = name.ToString();            //Вывод информации, в соответствии с тем, какая болезнь выбрана
            ShowInfo(dis);
        }

        public void ShowInfo(Disease dis)      //Заполнение данных, соответствующих болезни, в отведённые поля
        {
            StringBuilder symp = new StringBuilder();
            StringBuilder med = new StringBuilder();
            StringBuilder heal = new StringBuilder();
            foreach (string s in dis.Sympthoms_)
                symp.Append(s + "\n");
            richtb_symp.Text = symp.ToString();
            foreach (string s in dis.Cure_)
                heal.Append(s + "\n");
            richtb_heal.Text = heal.ToString();
            foreach (string s in dis.Medicine_)
                med.Append(s + "\n");
            richtb_med.Text = med.ToString();
        }
        private void button2_Click(object sender, EventArgs e) //Переход к главному меню
        {
            Program.Control.MainMenu.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

    
    }
}

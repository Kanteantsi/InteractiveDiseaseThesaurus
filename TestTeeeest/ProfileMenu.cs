using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TestTeeeest.MainMenu;
using static TestTeeeest.Program;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TestTeeeest
{
    public partial class Profile_Menu : Form
    {
        public Profile_Menu()
        {
            InitializeComponent();
            Program.Control.ProfileMenu = this;                           //Данные полей профиля передаются соответствующим полям класса
            if (Program.Control != null)
            {
                if (Program.Control.Profile.Gender)
                    comboBox1.Text = "Мужской";
                else
                    comboBox1.Text = "Женский";
                textBox5.Text = Program.Control.Profile.Blood_Sugar.ToString();
                textBox6.Text = Program.Control.Profile.Temperature.ToString();
                textBox9.Text = Program.Control.Profile.LastName;
                textBox8.Text = Program.Control.Profile.FirstName;
                textBox3.Text = Program.Control.Profile.Blood_Pressure.ToString();
                textBox4.Text = Program.Control.Profile.Pulse.ToString();
                textBox2.Text = Program.Control.Profile.Weight.ToString();
                textBox1.Text = Program.Control.Profile.Height.ToString();
                textBox10.Text = Program.Control.Profile.MidName;
                textBox7.Text = Program.Control.Profile.Age.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)            //Переход в главное меню
        {
            if (Program.Control.MainMenu == null)
                Program.Control.MainMenu = new MainMenu();
            this.Hide();
            Program.Control.MainMenu.Show();
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Program.Control.Profile.Gender = true;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                Program.Control.Profile.Gender = false;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        double result;
        double result2;

        private void button2_Click(object sender, EventArgs e)  //Считывание данных, ввёденных в поля, проверка на соотвествие требованиям
        {
            int x;
            
            if (!Regex.Match(textBox9.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                MessageBox.Show("Поле «Фамилия» не может содержать ничего, кроме букв русского или латинского алфавита");
            }

            else
            {
                Program.Control.Profile.LastName = textBox9.Text;
            }

            if (!Regex.Match(textBox8.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                MessageBox.Show("Поле «Имя» не может содержать ничего, кроме букв русского или латинского алфавита");
            }

            else
            {
                Program.Control.Profile.FirstName = textBox8.Text;
            }


            if (!Regex.Match(textBox10.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                MessageBox.Show("Поле «Отчество» не может содержать ничего, кроме букв русского или латинского алфавита");
            }
            else
            {
                Program.Control.Profile.MidName = textBox10.Text;
            }

            if (Int32.TryParse(textBox1.Text, out x) == false)
            {
                MessageBox.Show("Поле «Рост» не может содержать буквы");
                return;
            }
            
            else if (int.Parse(textBox1.Text) > 290)
            {
                MessageBox.Show("Введённый рост выше допустимого"); 
            }
            else if (int.Parse(textBox1.Text) < 45)
            {
                MessageBox.Show("Введённый рост ниже допустимого");
            }
            else

            {
                Program.Control.Profile.Weight = int.Parse(textBox2.Text);
            }
            if (Int32.TryParse(textBox2.Text, out x) == false)
            {
                MessageBox.Show("Поле «Вес» не может содержать буквы");
                return;
            }

            else if (int.Parse(textBox2.Text) > 750)
            {
                MessageBox.Show("Введённый вес выше допустимого");
            }
             
          
            else if (int.Parse(textBox2.Text) < 2)
            {
                MessageBox.Show("Введённый вес ниже допустимого"); 
            }
            
            else if ((int.Parse(textBox2.Text) > 2)&& (int.Parse(textBox2.Text) < 750))
            {
                double Body_Mass_index;
                double Body_Mass_index_1;
                double Body_Mass_index_2;
                Body_Mass_index_1 = int.Parse(textBox2.Text);
                Body_Mass_index_2 = ((int.Parse(textBox1.Text) * 0.01) * (int.Parse(textBox1.Text) *0.01));
                Body_Mass_index = Body_Mass_index_1 / Body_Mass_index_2;

                if (Body_Mass_index < 18.5)
                    MessageBox.Show("Введённый вес ниже нормального");
                if ((Body_Mass_index >= 18.5) && (Body_Mass_index < 25))
                    MessageBox.Show("Введённый вес нормальный");
                if ((Body_Mass_index >= 25) && (Body_Mass_index < 30))
                    MessageBox.Show("Введённый вес избыточный");
                if ((Body_Mass_index >= 30) && (Body_Mass_index < 35))
                    MessageBox.Show("Внимание, у вас ожирение I степени");
                if ((Body_Mass_index >= 35) && (Body_Mass_index < 40))
                    MessageBox.Show("Внимание, у вас ожирение II степени");
                if ((Body_Mass_index >= 40))
                    MessageBox.Show("Внимание, у вас ожирение III степени");
               

            }

            else
            {
                Program.Control.Profile.Blood_Pressure = int.Parse(textBox2.Text);
            }

            if (Int32.TryParse(textBox3.Text, out x) == false)
            {
                MessageBox.Show("Поле «Артериальное давление» не может содержать буквы"); 
                return;
            }
            else if ((int.Parse(textBox3.Text) > 200)&& (int.Parse(textBox3.Text) <= 240))
            {
                MessageBox.Show("Критический показатель артериального давления, возможен риск гипертонического криза"); 
            }
            else if ((int.Parse(textBox3.Text) < 60)&&(int.Parse(textBox3.Text) >= 30))
            {
                MessageBox.Show("Критический показатель артериального давления, возможен риск инфаркта"); 
            }
            else if ((int.Parse(textBox3.Text) < 30)||(int.Parse(textBox3.Text) > 240))
               
            {
                MessageBox.Show("Артериальное давление введено неверно"); 
            }
            else
            {
                Program.Control.Profile.Pulse = int.Parse(textBox3.Text);
            }
            if (Int32.TryParse(textBox4.Text,out x) == false)
            {
                MessageBox.Show("Поле «Пульс» не может содержать буквы ");
            }
            else if ((int.Parse(textBox4.Text) < 40)&& (int.Parse(textBox4.Text) > 25))
            {
                MessageBox.Show("Критический показатель пульса, возможна брадикардия"); 
            }
            else if ((int.Parse(textBox4.Text) > 80)&&(int.Parse(textBox4.Text) <= 200))
            {
                MessageBox.Show("Критический показатель пульса, если не было физических нагрузок, возможна тахикардия"); 
            }
            else if ((int.Parse(textBox4.Text) <= 25)|| (int.Parse(textBox4.Text) > 200))
            {
                MessageBox.Show("Пульс введён неверно"); 
            }
            else
            {
                Program.Control.Profile.Pulse = int.Parse(textBox4.Text);
            }
            //Считывание переменной так, чтобы было возможно проверять её по требованиям)

            if (!double.TryParse(textBox6.Text, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out result2) &&
                   //Then try in US english
                   !double.TryParse(textBox6.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result2) &&
                   //Then in neutral language
                   !double.TryParse(textBox6.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out result2))
            {
                result2 = 0.00;
            }
            Program.Control.Profile.Temperature = result2;
            if (Regex.Match(textBox6.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                MessageBox.Show("Поле «Температура» не может содержать буквы");
                return;
            }
            else if (((result2) >= 38.0)&&(((result2)<= 40.0)))
            {
                MessageBox.Show("Повышена температура, рекомендуется постельный режим и теплое питьё");
               
            }
            else if ((((result2) > 40.0)&&((result2) <= 43.0)))
            {
                MessageBox.Show("Повышена температура, рекомендуется приём жаропонижающих"); 
            }
            else if (((result2) <= 35.0)&&((result2) >= 27.0))
            {
                MessageBox.Show("Температура понижена, риск переохлаждения"); 
            }
            else if (((result2) < 27.0)||((result2) > 43.0))
            {
                MessageBox.Show("Температура введена неверно"); 
            }
            else
            {
                Program.Control.Profile.Temperature = result2;
            }
            if (Int32.TryParse(textBox7.Text, out x) == false)
            {
                MessageBox.Show("Поле «Возраст» не может содержать буквы");
                return;
            }
            else if ((int.Parse(textBox7.Text) <= 0)|| (int.Parse(textBox7.Text) > 190))
            {
                MessageBox.Show("Возраст введён неверно"); 
            }
            else
            {
                Program.Control.Profile.Age = int.Parse(textBox7.Text);
            }
            //Считывание переменной так, чтобы было возможно проверять её по требованиям)

            if (!double.TryParse(textBox5.Text, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                    //Then try in US english
                    !double.TryParse(textBox5.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                    //Then in neutral language
                    !double.TryParse(textBox5.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                result = 0.00;
            }
                Program.Control.Profile.Blood_Sugar = result;
            if (Regex.Match(textBox5.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                MessageBox.Show("Поле «Сахар в крови» не может содержать буквы");
            }
                if ((result < 3.30)&&(result > 0))
            {
                MessageBox.Show("Внимание, у вас пониженный сахар в крови, это может привести к риску инсульта или комы");
            }
             else if ((result >= 6.70)&&(result < 33.00))
            {
                MessageBox.Show("Внимание, у вас повышенный сахар в крови, высокий риск гипергликемической комы");
            }
            else if ((result >= 33.00)&& (result < 55.00))
            {
                MessageBox.Show("Внимание, у вас повышенный сахар в крови, срочно обратитесь в неотложную помощь");
            }
            else if ((result >= 55.00)|| (result <= 0))
            {
                MessageBox.Show("Количество сахара в крови введено неверно");
            }

        }

        private void Profile_Menu_FormClosing(object sender, FormClosingEventArgs e) //При закрытии формы, закрывается приложение
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

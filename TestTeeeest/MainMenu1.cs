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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 SARS = new Form5();
            SARS.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 Flu = new Form3();
            Flu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Profile_Menu profile = new Profile_Menu();
            profile.ShowDialog();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 search = new Form4();
            search.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 Insomnia = new Form6();
            Insomnia.ShowDialog();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            DiseaseFlexible DiseaseTest = new DiseaseFlexible();
            DiseaseTest.ShowDialog();
        }
    }
}


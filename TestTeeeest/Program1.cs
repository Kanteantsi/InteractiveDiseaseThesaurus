using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTeeeest
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
            FileReading();
            List<Disease> DiseaseList = new List<Disease>();

        }

        public class Profile
        {

            public String Middle_Name_ { get; set; } = " ";
            public String First_Name_ { get; set; } = " ";
            public String Last_Name_ { get; set; } = "  ";
            public int Age_ { get; set; } = 0;
            public bool Gender_ { get; set; } = false;
            public int Height_ { get; set; } = 0;
            public int Weight_ { get; set; } = 0;
            public int Blood_Pressure_ { get; set; } = 0;
            public int Pulse_ { get; set; } = 0;
            public double Blood_Sugar_ { get; set; } = 0.0;
            public double Temperature_ { get; set; } = 0.0;

            //public update_DATA(Profile)
            //{

            //}
            internal static void EventHandler(string text) => throw new NotImplementedException();

            internal class MyEvent
            {
                private object func;

                public MyEvent(object func)
                {
                    this.func = func;
                }

                public MyEvent(Action<string> func)
                {
                    this.func = func;
                }
            }

        }

        static void FileReading()
        {
            List<Disease> list = new List<Disease>();
            using (StreamReader f = new StreamReader("База знаний" + ".txt"))
            {
                Disease iter = new Disease();
                while (!f.EndOfStream)
                {
                    string s = f.ReadLine();
                    if (s == "Наименование:")
                    {
                        Disease dis = new Disease();
                        dis.Name_ = f.ReadLine();
                        list.Add(dis);
                        iter = dis;
                        continue;
                    }
                    if (s == "Симптомы:")
                    {
                        StringBuilder symp = new StringBuilder();
                        symp.Append(f.ReadLine());
                        while (symp.ToString() != " ")
                        {
                            iter.Sympthoms_.Add(symp.ToString());
                            symp.Clear();
                            symp.Append(f.ReadLine());
                        }
                    }
                    if (s == "Лечение:")
                    {
                        StringBuilder heal = new StringBuilder();
                        heal.Append(f.ReadLine());
                        while (heal.ToString() != " ")
                        {
                            iter.Cure_.Add(heal.ToString());
                            heal.Clear();
                            heal.Append(f.ReadLine());
                        }
                    }
                    if (s == "Лекарства:")
                    {
                        StringBuilder med = new StringBuilder();
                        med.Append(f.ReadLine());
                        while (med.ToString() != " ")
                        {
                            iter.Medicine_.Add(med.ToString());
                            med.Clear();
                            med.Append(f.ReadLine());
                        }
                    }
                }
            }
            Console.ReadKey();
        }

    }

    public class Disease
    {

        public String Name_ { get; set; }
        public List<string> Sympthoms_ { get; set; }

        public List<string> Cure_ { get; set; }

        public List<string> Medicine_ { get; set; }

        public Disease()
        {
            this.Name_ = "";
            this.Sympthoms_ = new List<string>();
            this.Cure_ = new List<string>();
            this.Medicine_ = new List<string>();
        }
    }

}
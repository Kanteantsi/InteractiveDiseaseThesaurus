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
        

        //private static Controller control2;
        private static Controller control;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<Disease> DisList = FileReading();
            //List<String> UniqueSympthoms = UniqueSympthomsReading();
            //UniqueSympthomsReading();
            //List<Disease> ReadFile = UniqueSympthomsReading();

            //control2 = new Controller(ReadFile, new Profile());
            
            control = new Controller(DisList, new Profile());
            control.MainMenu = new MainMenu();
            Application.Run(control.MainMenu);
        }
        public static Controller Control
        {
            get => control;
            set => control = value;
        }

        static List<Disease> FileReading()   //Чтение файла с базой данных, с автоматической инициализацией и заполнением полей объектов класса
        {
            List<Disease> list = new List<Disease>();
            using (StreamReader f = new StreamReader("База знаний" + ".txt"))
            {
                StringBuilder str = new StringBuilder();
                Disease iter = new Disease();
                while (!f.EndOfStream)
                {
                    str.Clear();
                    str.Append(f.ReadLine());
                    while(str.Length > 1 && str[str.Length-1]==' ')
                    {
                        str.Length--;
                    }
                    string s = str.ToString();
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
            return list;
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
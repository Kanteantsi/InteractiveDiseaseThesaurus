using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTeeeest
{
    public class Profile
    {

        private String Middle_Name_;
        private String First_Name_;
        private String Last_Name_;
        private int Age_;
        private bool Gender_;
        private int Height_;
        private int Weight_;
        private int Blood_Pressure_;
        private int Pulse_;
        private double Blood_Sugar_;
        private double Temperature_;

        public string MidName
        {
            get => Middle_Name_;
            set => Middle_Name_ = value;
        }
        public string FirstName
        {
            get => First_Name_;
            set => First_Name_ = value;
        }
        public string LastName
        {
            get => Last_Name_;
            set => Last_Name_ = value;
        }
        public int Age
        {
            get => Age_;
            set => Age_ = value;
        }
        public bool Gender
        {
            get => Gender_;
            set => Gender_ = value;
        }
        public int Height
        {
            get => Height_;
            set => Height_ = value;
        }
        public int Weight
        {
            get => Weight_;
            set => Weight_ = value;
        }
        public int Blood_Pressure
        {
            get => Blood_Pressure_;
            set => Blood_Pressure_ = value;
        }
        public int Pulse
        {
            get => Pulse_;
            set => Pulse_ = value;
        }
        public double Blood_Sugar
        {
            get => Blood_Sugar_;
            set => Blood_Sugar_ = value;
        }
        public double Temperature
        {
            get => Temperature_;
            set => Temperature_ = value;
        }
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
}

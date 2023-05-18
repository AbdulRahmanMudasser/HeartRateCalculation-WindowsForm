using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heart_Rate_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        class HeartRate
        {
            private string firstName;
            private string secondName;
            private int birthYear;
            private int currentYear;

            public HeartRate(string firstName, string secondName, int birthYear)
            {
                FirstName = firstName;
                SecondName = secondName;
                BirthYear = birthYear;
                CurrentYear = DateTime.Now.Year;
            }

            public string FirstName { get => firstName; set => firstName = value; }
            public string SecondName { get => secondName; set => secondName = value; }
            public int BirthYear { get => birthYear; set => birthYear = value; }
            public int CurrentYear { get => currentYear; set => currentYear = value; }

            public int PersonAge => Convert.ToInt32(currentYear - BirthYear);

            public int MaxHeartRate => 220 - PersonAge;

            public int MinTargetRate => Convert.ToInt32(MaxHeartRate * 0.5);

            public int MaxTargerRate => Convert.ToInt32(MaxHeartRate + 0.85);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string secondName = secondNameTextBox.Text;
            int birthYear = Convert.ToInt32(birthYearTextBox.Text);
            string result = "";

            HeartRate heartRate = new HeartRate(firstName, secondName, birthYear);

            result += "Name:  " + heartRate.FirstName + " " + heartRate.SecondName;
            result += "\n";
            result += "Age:  " + heartRate.PersonAge;
            result += "\n";
            result += "Maximum Heart Rate:  " + heartRate.MaxHeartRate;
            result += "\n";
            result += "Target Heart Rate:  " + (heartRate.MaxHeartRate - heartRate.MinTargetRate);

            MessageBox.Show(result);
        }
    }
}

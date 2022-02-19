using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
namespace Lab1BoldeskulSofiaCalendar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DatePick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Zodiac.Text = "Your zodiac: " + WestZodiac(DatePick.SelectedDate.Value);
            ChinaZodiac.Text = "Your chinese zodiac: " + ChineseZodiac(DatePick.SelectedDate.Value);
            PersonWords.Text = "" + BirthDay(DatePick.SelectedDate.Value);
            PersonAge.Text = "Your age:" + AgeNow(DatePick.SelectedDate.Value);
            if (DatePick.SelectedDate.Value > DateTime.Today)
            {
                MessageBox.Show("Wait... you have not born yet!");
            }

            int nYear = DateTime.Today.Year;
            int y = DatePick.SelectedDate.Value.Year;
            int finalYear = nYear - y; // years now without month
            if (finalYear == 135)
            {
                if (DateTime.Today.Month >= DatePick.SelectedDate.Value.Month)
                {
                    if (DateTime.Today.Day > DatePick.SelectedDate.Value.Day) {

                        MessageBox.Show("Wait... you are to old!");
                    }
                }

            }
            if (finalYear > 135)
            {
                MessageBox.Show("Wait... you are to old!");
            }

        }
            public int AgeNow(DateTime StartDate)
        {
            int nowYear = DateTime.Today.Year;
           
            int year = DatePick.SelectedDate.Value.Year;
            int age = nowYear - year; // years now without month
            if (DateTime.Today.Month == DatePick.SelectedDate.Value.Month)
            {
                if (DateTime.Today.Day < DatePick.SelectedDate.Value.Day)
                {
                    return age - 1;
                }
                else
                {
                    return age;
                }
            }
            if (DateTime.Today.Month < DatePick.SelectedDate.Value.Month)
            {
                return age - 1; 
            }
           
            else
            {
                return age;
            }
        }
        public string BirthDay(DateTime StartDate)
        {
            if (DateTime.Today.Day == DatePick.SelectedDate.Value.Day && DateTime.Today.Month == DatePick.SelectedDate.Value.Month )
            {
                return "Happy Birthday! You are wonderful! ";
            }
            else
            {
                return "Nice to see you here!";
            }
        }
        public string ChineseZodiac(DateTime StartDate)
        {
            int year = StartDate.Year;
            int yearChina = (year - 4) % 12;
            if (yearChina == 0)
            {
                return "Rat";
            }
            if (yearChina == 1)
            {
                return "Ox";
            }
            if (yearChina == 2)
            {
                return "Tiger";
            }
            if (yearChina == 3)
            {
                return "Rabbit";
            }
            if (yearChina == 4)
            {
                return "Dragon";
            }
            if (yearChina == 5)
            {
                return "Snake";
            }
            if (yearChina == 6)
            {
                return "Horse";
            }
            if (yearChina == 7)
            {
                return "Goat";
            }
            if (yearChina == 8)
            {
                return "Monkey";
            }
            if (yearChina == 9)
            {
                return "Rooster";
            }
            if (yearChina == 10)
            {
                return "Dog";
            }
            if (yearChina == 11)
            {
                return "Pig";
            }
            else
            {
                return "No";
            }
        }
        public string WestZodiac(DateTime StartDate)
        {
           
            int day = StartDate.Day;
            int month = StartDate.Month;
            int zodiac = 100 * month + day;
            if (zodiac >= 121 && zodiac <= 219)
            {
                return "Aquarius";
            }
            if (zodiac >= 220 && zodiac <= 320)
            {
                return "Pisces";
            }
            if (zodiac >= 321 && zodiac <= 420)
            {
                return "Aries ";
            }
            if (zodiac >= 421 && zodiac <= 521)
            {
                return "Taurus ";
            }
            if (zodiac >= 522 && zodiac <= 621)
            {
                return "Gemini";
            }
            if (zodiac >= 621 && zodiac <= 722)
            {
                return "Cancer";
            }
            if (zodiac >= 723 && zodiac <= 823)
            {
               return "Leo";
            }
            if (zodiac >= 824 && zodiac <= 923)
            {
                return "Virgo";
            }
            if (zodiac >= 924 && zodiac <= 1023)
            {
                return "Libra";
            }
            if (zodiac >= 1024 && zodiac <= 1122)
            {
                return "Scorpio";
            }
            if (zodiac >= 1123 && zodiac <= 1221)
            {
                return "Sagittarius";
            }
            else
            {
                return "Capricorn";
            }
        }
        }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Time
    {
        public int day { get; set; }
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        public Time()
        {
            this.day = 0;
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
        }
        public Time(int second)
        {
            const int SecondsInMinute = 60;
            const int SecondsInHour = 60 * 60;
            const int SecondsInDay = 24 * 60 * 60;

            this.second = second % SecondsInMinute;
            this.minute = (second / SecondsInMinute) % 60;
            this.hour = (second / SecondsInHour) % 24;
            this.day = second / SecondsInDay;
        }
        public Time(int minute, int second)
        {
            const int SecondsInMinute = 60;
            const int SecondsInHour = 60 * 60;
            const int SecondsInDay = 24 * 60 * 60;

            second = second + minute * SecondsInMinute;

            this.second = second % SecondsInMinute;
            this.minute = (second / SecondsInMinute) % 60;
            this.hour = (second / SecondsInHour) % 24;
            this.day = second / SecondsInDay;
        }
        public Time(int hour, int minute, int second)
        {
            const int SecondsInMinute = 60;
            const int SecondsInHour = 60 * 60;
            const int SecondsInDay = 24 * 60 * 60;

            second = second + minute * SecondsInMinute + hour * SecondsInHour;

            this.second = second % SecondsInMinute;
            this.minute = (second / SecondsInMinute) % 60;
            this.hour = (second / SecondsInHour) % 24;
            this.day = second / SecondsInDay;
        }
        public Time(int day, int hour, int minute, int second)
        {
            const int SecondsInMinute = 60;
            const int SecondsInHour = 60 * 60;
            const int SecondsInDay = 24 * 60 * 60;

            second = second + minute * SecondsInMinute + hour * SecondsInHour + day * SecondsInDay;

            this.second = second % SecondsInMinute;
            this.minute = (second / SecondsInMinute) % 60;
            this.hour = (second / SecondsInHour) % 24;
            this.day = second / SecondsInDay;
        }
        public int GetFullSecond()  // Возвращает полное коллисчество секунд
        {
            return second + 60 * GetFullMinute();
        }
        public int GetFullMinute()
        {
            return minute + 60 * GetFullHour();
        }
        public int GetFullHour()
        {
            return hour + 24 * GetFullDay();
        }
        public int GetFullDay()
        {
            return day;
        }
        public string SecondToString()  // Переводит секунды в специальный формат SS
        {
            string result = "";
            if (second > 9)
            {
                result = $"{second}";
            }
            else
            {
                result = $"0{second}";
            }
            return result;
        }
        public string MinuteToString()  // Переводит минуты в специальный формат MM
        {
            string result = "";
            if (minute > 9)
            {
                result = $"{minute}";
            }
            else
            {
                result = $"0{minute}";
            }
            return result;
        }
        public string HourToString()  // Переводит часы в специальный формат HH
        {
            string result = "";
            if (hour > 9)
            {
                result = $"{hour}";
            }
            else
            {
                result = $"0{hour}";
            }
            return result;
        }
        public string DayToString()  // Переводит дни в специальный формат: D
        {
            string result = $"{day}";
            return result;
        }
        public override string ToString() // Возвращает промежуток времени в формате Dd HH:MM:SS
        {
            return $"{DayToString()}d {HourToString()}:{MinuteToString()}:{SecondToString()}";
        }
        public static Time operator +(Time a, Time b)
        {
            int sum_sec = a.GetFullSecond() + b.GetFullSecond();
           
            Time c = new Time(sum_sec);
            return c;
        }
        public static Time operator -(Time a, Time b)
        {
            int sum_sec = a.GetFullSecond() - b.GetFullSecond();
            Time c = new Time(sum_sec);
            return c;
        }
        public static Time operator *(Time a, int b)
        {
            int sum_sec = a.GetFullSecond() * b;
            Time c = new Time(sum_sec);
            return c;
        }
    }
}

using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Months months = new Months();
            int NumberofMay = months["May"];
            string secondMonth = months[2];
            Console.WriteLine(NumberofMay + "  " + secondMonth);
        }
    }
    public class Months
    {
        private string[] months = new string[]
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "Augost",
            "September",
            "October",
            "November",
            "December"
        };
        public int this[string key]
        {
            get { return GetIndex(key); }
        }
        public string this[int i]
        {
            get { return months[i - 1]; }
        }


        private int GetIndex(string month)
        {
            int defaultmonth = 0;
            for (int i = 0; i < months.Length; i++)
            {
                if (months[i] == month)
                {
                    defaultmonth = i + 1;
                }
            }
            return defaultmonth;
        }
    }
}

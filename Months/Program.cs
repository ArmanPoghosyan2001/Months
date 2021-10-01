using System;
using System.Collections;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Months months = new Months();
            foreach (var item in months)
            {
                Console.WriteLine($"{item}  ");
            }
        }
    }
    public class Months : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            return new MonthEnumerator(months, months.Length);
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
    public class MonthEnumerator : IEnumerator
    {
        int _size;
        int _count;
        string[] _source;
        public MonthEnumerator(string[] source, int size)
        {
            _source = source;
            _size = size;
        }
        public object Current => _source[_count++];

        public bool MoveNext()
        {
            return _count < _size;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

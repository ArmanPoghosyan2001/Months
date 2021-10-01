using System;
using System.Collections;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Months months = new Months();
            foreach (string month in months)
            {
                Console.Write($"{month}, ");
            }
            Console.WriteLine("\n---------------------------------------");

            MicStudents students = new MicStudents();
            foreach (string student in students)
            {
                Console.Write($"{student}, ");
            }
            Console.WriteLine("\n---------------------------------------");

            Lessons lessons = new Lessons();
            foreach (string lesson in lessons)
            {
                Console.Write($"{lesson}, ");
            }
            Console.WriteLine("\n\n\n");

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

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(months);
        }

        private int GetIndex(string month)
        {
            int index = 0;
            for (int i = 0; i < months.Length; i++)
            {
                if (months[i] == month)
                {
                    index = i + 1;
                }
            }
            return index;
        }
    }
    public class MicStudents
    {
        private string[] students = new string[]
        {
            "Ara",
            "Aram",
            "Arman",
            "Gayane",
            "Tatev",
            "Lilit",
            "Mariam",
            "Vahe",
            "Davit",
            "Matevos",
        };
        public int this[string key]
        {
            get { return GetIndex(key); }
        }
        public string this[int i]
        {
            get { return students[i - 1]; }
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(students);
        }

        private int GetIndex(string student)
        {
            int index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == student)
                {
                    index = i + 1;
                }
            }
            return index;
        }
    }
    public class Lessons
    {
        private string[] lessons = new string[]
       {
            "Class",
            "Incapsulation",
            "Inheritance",
            "Polymorphism",
            "Abstact Class",
            "Interface",
            "Collections",
            "IEnumerable",
            "ref and out",
            "const and readonly",
       };
        public int this[string key]
        {
            get { return GetIndex(key); }
        }
        public string this[int i]
        {
            get { return lessons[i - 1]; }
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(lessons);
        }

        private int GetIndex(string lesson)
        {
            int index = 0;
            for (int i = 0; i < lessons.Length; i++)
            {
                if (lessons[i] == lesson)
                {
                    index = i + 1;
                }
            }
            return index;
        }
    }
    public class Enumerator : IEnumerator
    {
        int _count;
        string[] _source;
        public Enumerator(string[] source)
        {
            _source = source;
        }
        public object Current => _source[_count++];

        public bool MoveNext()
        {
            return _count < _source.Length;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

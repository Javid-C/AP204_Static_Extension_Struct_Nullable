using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Static_Extensions_Nullable_Enum
{
    class Student
    {
        public int Id;
        public string Name;
        public string Surname;
        public static int count = 0;
        
        public Student(string name, string surname)
        {
            Console.WriteLine("Normal constructor");
            count++;
            Id = count;
            Name = name;
            Surname = surname;
        }


        static Student()
        {
            Console.WriteLine("Static called");
            count = 100;
        }

        public string getName()
        {
            return Name;
        }


        public int GetCount()
        {
            return count;
        }

        public static void StaticGetCount()
        {
            Console.WriteLine($"{count}");
        }
    }
}

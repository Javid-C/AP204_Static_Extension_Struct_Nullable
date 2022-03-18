using AP204_Static_Extensions_Nullable_Enum.Extensions;
using System;

namespace AP204_Static_Extensions_Nullable_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Static
            //Console.WriteLine(Student.count) ;
            //Student student = new Student("Bahadur", "Umarov");
            ////Console.WriteLine(Student.count);
            //Student student1 = new Student("Bahadur", "Umarov");
            ////Console.WriteLine(Student.count);
            //Student student2 = new Student("Bahadur", "Umarov");
            //Student student3 = new Student("Bahadur", "Umarov");
            //Console.WriteLine(Student.count);
            //Student.StaticGetCount();

            //Student student2 = new Student("Bahadur","Qumarov");
            //Student student3 = new Student("Bahadur","Umarov");

            //Console.WriteLine(student.Id);



            //Console.WriteLine("Student's id: " + student.Id);
            #endregion

            #region Extensions
            //string name = "Fatima";

            //Console.WriteLine(name.Contains("a"));

            //int number = 20;

            //Console.WriteLine(number.Add(30));


            //string name = "tural hemidzade";

            //Console.WriteLine(name.Add("Hemidzade"));

            //Console.WriteLine(name.isCapitalized());

            //Console.WriteLine(name.customContains("al hem"));
            #endregion


            #region Struct
            //MyStruct myStruct = new MyStruct();
            ////myStruct.X = 5;
            ////myStruct.Y = 15;

            //Console.WriteLine(myStruct.X);
            #endregion


            //int num = null;

            //string name = "";

            //bool result = null;

            //int? num = null;

            //num = 5;

            //Console.WriteLine(num == null);

            //bool? result = null;

            //Console.WriteLine(result == null);

            //if()
            //{
            //    Console.WriteLine("Null deyer menimsedilib");
            //}
            //else
            //{
            //    Console.WriteLine(name);
            //}
            
            string word = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("Null");
            }
            else
            {
                Console.WriteLine(word) ;
            }


            //string sentence = "Bu bir custom contains methodudur";


        }
    }
}

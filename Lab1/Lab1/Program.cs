using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student : IComparable<Student>
    {
        /*The Student class should have only one instance variable name of type string.
         * Every Student object should have unique name. */

        public string Name { get; set; }

        public Student(string Name)
        {
            Name = name;
        }
        public int CompareTo(Student other)
        {
            return Name.CompareTo(other.Name);
        }

        public static int Search<T>(string element , T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element.CompareTo(Convert.ToString(array[i])) > 0)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            Console.WriteLine(-1);
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Select: \n 1 - Integer array \n 2 - Names for the Student object array");
            string selection = Console.ReadLine();
            if (selection.Equals("1"))
            {
                Console.WriteLine("Type an integer: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type an integer: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type an integer: ");
                int number3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type an integer: ");
                int number4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type an integer: ");
                int number5 = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[5] { number1, number2, number3, number4, number5 };
                Console.WriteLine("Array created! ");
                Console.WriteLine(array);

                Console.WriteLine("Search for an integer: ");
                string search = Console.ReadLine();
                Search<int>(search, array);
            }

            else if (selection.Equals("2"))
            {
                Console.WriteLine("Type a student name: ");
                string name1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Type a student name: ");
                string name2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Type a student name: ");
                string name3 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Type a student name: ");
                string name4 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Type a student name: ");
                string name5 = Convert.ToString(Console.ReadLine());
            }

        }       
    }
}

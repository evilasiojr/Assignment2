using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creating_Objects.Math;

namespace Creating_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(5, 2);
            System.Console.WriteLine(result);
            
        }
    }
}

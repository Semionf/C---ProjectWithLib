using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumber;
namespace ProjectWithLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 numbers = new Class1();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers.randomNum() + numbers.awesomeSentence());
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    public class Class1
    {
        public Random rnd = new Random(DateTime.Now.Millisecond);
        public int randomNum()
        {
            int randomNum = rnd.Next();
            return randomNum;
        }

        public string awesomeSentence()
        {
            return "C# is the best";
        }
    }
}

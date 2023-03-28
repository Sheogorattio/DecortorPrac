using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecortorPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            MainCharacter obj = new HumanWarriorDecor(human).hero;
            Console.WriteLine(obj.Name);
            Console.ReadKey();
        }
    }
}

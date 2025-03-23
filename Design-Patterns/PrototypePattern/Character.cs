using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.PrototypePattern
{
    public class Character : ICloneable<Character>
    {

        public string Name { get; set; }
        public int Level { get; set; }
        public int Power { get; set; }

        public Character(string name, int level, int power)
        {
            Name = name;
            Level = level;
            Power = power;
        }

        public Character Clone()
        {
           return new Character(Name, Level, Power);
        }

        public void Display()
        {
            Console.WriteLine($"Character: {Name}, Level: {Level}, Power: {Power}");
        }
    }
}

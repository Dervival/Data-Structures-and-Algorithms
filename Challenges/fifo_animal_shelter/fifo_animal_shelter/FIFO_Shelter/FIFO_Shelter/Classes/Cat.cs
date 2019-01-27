using System;
using System.Collections.Generic;
using System.Text;

namespace FIFO_Shelter.Classes
{
    public class Cat : Animal
    {
        public override string Type { get; set; }
        public override string Name { get; set; }

        public Cat(string name)
        {
            Type = "Cat";
            Name = name;
        }
    }
}

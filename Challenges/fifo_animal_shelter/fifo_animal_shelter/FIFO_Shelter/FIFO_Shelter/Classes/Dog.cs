using System;
using System.Collections.Generic;
using System.Text;

namespace FIFO_Shelter.Classes
{
    class Dog : Animal
    {
        public override string Type { get; set; }
        public override string Name { get; set; }

        public Dog(string name)
        {
            Type = "Dog";
            Name = name;
        }
    }
}

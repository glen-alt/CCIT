using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S01_OOPIntro_Win
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public string Speak()
        {
            return $"The {Species} named {Name} says hello!";
        }
    }
}

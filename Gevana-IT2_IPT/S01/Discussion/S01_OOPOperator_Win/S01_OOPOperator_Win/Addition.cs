using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S01_OOPOperator_Win
{
    public class Addition
    {
        public int addends1 { get; set; }
        public int addends2 { get; set; }

        public int Sum { get; set; }

        public string Add()
        {
            Sum = addends1 + addends2;
            return $"{Sum}";
        }
    }
}

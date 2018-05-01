using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Program
    {
        public class Nuum
        {
            public int [] Num { get; set; }
        }

        public class Result
        {
           

            public List<Nuum> LisNum { get; set; }

            public Nuum this[int Index]
            {
                set => LisNum[Index] = value;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

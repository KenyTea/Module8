using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    /*
      1.	Создать индексатор для одномерного массива который при установке значения будет
      возводить в квадрат передаваемое значение переменной и устанавливать его для указанного индекса.
      При получении элемента массива по индексу будет возвращаться его текущее значение.
      */
    class Program
    {
        public class Nuum
        {
            public Random rand = new Random();
            public int[] Num { get; set; }

            public Nuum()
            {
                Num = new int[rand.Next(0, 10)];
            }

            public int this[int index]
            {
                get
                {
                    return Num[index];
                }

                set
                {
                    Num[index] = value * value;
                }
            }
        }

        static void Main(string[] args)
        {
            Nuum num = new Nuum();
            num[0] = 22;
            Console.WriteLine(num[0]);
        }
    }
}

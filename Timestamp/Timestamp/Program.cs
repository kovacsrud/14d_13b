using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timestamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeStampConvert ts = new TimeStampConvert();

            //Console.WriteLine(ts.Convert(1578305471));

            Console.WriteLine(TimeStampConvert.Convert(1578305471));

            

            Console.ReadKey();
        }
    }
}

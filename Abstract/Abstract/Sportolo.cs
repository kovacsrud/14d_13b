using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Sportolo : Ember
    {
        public String Sportag { get; set; }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik.");
        }

        public override void Fut()
        {
            Console.WriteLine("A sportoló gyorsan fut");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló sok vizet iszik");
        }
    }
}

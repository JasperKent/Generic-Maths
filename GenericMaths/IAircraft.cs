using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaths
{
    internal interface IAircraft
    {
        double Speed { get; }
        static abstract double MaxSpeed { get; }
    }

    class Concorde : IAircraft
    {
        public static double MaxSpeed => 605;

        public double Speed { get; set; }
    }

    class Boeing747 : IAircraft
    {
        public static double MaxSpeed => 274;
        public double Speed { get; set; }
    }
}

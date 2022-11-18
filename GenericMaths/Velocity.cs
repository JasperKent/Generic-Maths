using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaths
{
    internal record struct Velocity (double X, double Y, double Z)
        : IAdditionOperators<Velocity, Velocity, Velocity>
    {
        public static Velocity operator+ (Velocity l, Velocity r) 
        { 
            return new Velocity(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }
    }
}

using GenericMaths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

//var intList = new List<int> { 1, 2, 3, 4, 5 };
var complexList = new List<Complex> { new Complex(1, 1), new Complex(2, 2) };

Console.WriteLine(complexList.Sum());

//var c = new Concorde { Speed= 200 };
//var b = new Boeing747 { Speed= 200 };

//Report(c);
//Report(b);

//void Report<T> (T aircraft) where T : IAircraft
//{
//    Console.WriteLine($"Speed = {aircraft.Speed} ({aircraft.Speed * 100/T.MaxSpeed})%");
//}

var v1 = new Velocity(1,2,3);
var v2 = new Velocity(4,5,6);
var v3 = new Velocity(7,8,9);

var velList = new List<Velocity> { v1, v2, v3 };

Console.WriteLine(velList.Sum());

//Console.WriteLine(v1 + v2);
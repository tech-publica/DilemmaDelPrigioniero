using DilemmaDelPrigioniero.Competition;
using System;

namespace DilemmaDelPrigioniero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var t = new Tournament();
            t.Giostra();
            t.Sort();
            t.ShowResults();
        }
    }
}

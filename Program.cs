using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    public class Program
    {
        static void Main(string[] args)
        {
         
            Point p1 = new Point(3, 4);
            Point p2 = new Point(p1);
            Point p3 = new Point(); // This should print an error message
            Console.WriteLine($"Number of points created: {Point.GetNumPoints()}");
            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p2: {p2}");
            Console.WriteLine($"p3: {p3}");
        
            Console.WriteLine($"p2 is equal to p3: {p2.IsEqual(p3)}");
            Console.WriteLine($"p1 is equal to p2: {p1.IsEqual(p2)}");
        }
    }
}

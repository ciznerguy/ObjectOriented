using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    public class Point
    {
        private int x;
        private int y;
        private static int numPoints;
        private const int MaxDistanceOrigin = 10;


        public double DistanceFromOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }

        /*פעולה בונה.
         * יוצרת נקודה חדשה,
         * כל עוד מרחקה מהראשית
        אינו גדול מהמרחק המקסימלי,
        אחרת מודפסת שגיאה
         */

        public Point(int x, int y)
        {
            Console.WriteLine("main");
            if (this.DistanceFromOrigin() <= MaxDistanceOrigin)
            {
                this.x = x;
                this.y = y;
                numPoints++;
            }
            else
            {
                Console.WriteLine("Error: Point is too far from the origin.");
            }
        }
        /*
         * הוסיפו את הפעולה הבונה הבאה
         * כך שתשרשר את הפעולה הבונה הקיימת:
         */


        public Point() : this(0, 0)
        {
            Console.WriteLine("empty");
        }

        /*
         * הוסיפו את 
         * הפעולה הבונה הבאה כך שתשרשר את 
         * הפעולה הבונה הראשונה שכתבתם:

פעולה בונה מעתיקה
            */
        public Point(Point other) : this(other.x, other.y)
        {
            Console.WriteLine("copy");
        }


        public static int GetNumPoints()
        {
            return numPoints;
        }
        public bool IsEqual(Point other)
        {
            return this.AreValuesEqaul(other.x, other.y);
        }
        public bool AreValuesEqaul(int x, int y)
        {
            return this.x == x && this.y == y;
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}

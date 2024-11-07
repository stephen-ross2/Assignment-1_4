using System.ComponentModel.Design;

namespace Assignment_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4.5, 6.3);
            Point p2 = new Point(5.2, 7.8);

            if (p1.x == p2.x)

            {
                Console.WriteLine("P2 and P1 are on the same axis");
            }

            else if (p1.x < p2.x)

            {
                Console.WriteLine("P2 is to the right of P1");
            }
            else if ( p1.x > p2.x)
                    { 
                    Console.WriteLine("P2 is to the left of P1");
                }
            }
            
        }
        //Assignment 1_4
        //Create a class.

        public class Point
        {
            public Point(double xCoord, double yCoord)

            {
                x = xCoord;
                y = yCoord;
            }

            public Point()
            {
                x = 0;
                y = 0;
            }

            public double x;
            public double y;



        }
    }
}


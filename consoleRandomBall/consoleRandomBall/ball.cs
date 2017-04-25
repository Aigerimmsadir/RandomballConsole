using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace consoleRandomBall
{
    class ball
    {

        public Point location;
        public List<Point> neighbours = new List<Point>();
        public ball()
        {
            location = new Point(new Random().Next() % 30, new Random().Next() % 20);
 
        }

        public void Randomlocation()
        {
            if (location.x  >= 1 && location.y >= 1 ) {
                neighbours.Add(new Point(location.x + 1, location.y));
                neighbours.Add(new Point(location.x - 1, location.y));
                neighbours.Add(new Point(location.x, location.y + 1));
                neighbours.Add(new Point(location.x, location.y - 1));
                neighbours.Add(new Point(location.x + 1, location.y - 1));
                neighbours.Add(new Point(location.x + 1, location.y - 1));
                neighbours.Add(new Point(location.x + 1, location.y + 1));
                neighbours.Add(new Point(location.x - 1, location.y - 1));

            }
            else location = new Point(new Random().Next() % 30, new Random().Next() % 20);
        }

        public void Move()
        {
            while (true)
            {
                Console.Clear();
                location = neighbours[new Random().Next(0, 7)];
                Console.SetCursorPosition(location.x, location.y);
                Console.Write('*');
                Thread.Sleep(new Random().Next(0,1000));
                neighbours.Clear();
                Randomlocation();
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
    }
}

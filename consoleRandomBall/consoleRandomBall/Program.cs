using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleRandomBall
{
    class Program
    {
        static void Main(string[] args)
        {
            ball b= new ball();
            b.Randomlocation();
            b.Move();
          
        }
    }
}

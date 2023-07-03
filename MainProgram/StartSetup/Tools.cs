using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class Tools
    {
        public void DisplayText(string print)
        {
            if (print == "wait")
            {
                System.Threading.Thread.Sleep(500);
            }
            else
            {
                for (int i = 0; i < print.Length; i++)
                {
                    Console.Write(print[i]);
                    System.Threading.Thread.Sleep(10);
                }
            }
        }
    }
}

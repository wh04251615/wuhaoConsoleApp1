using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            while (true)
            {
                calculation w1 = new calculation();
                Console.WriteLine("Please enter the year:");
                w1.input();
                if (w1.isLP())
                {
                    w1.IST();
                }
                else
                {
                    w1.ISF();
                }
            }
        }
    }
    class calculation
    {
        int year;
        public void input()
        {
            year = Convert.ToInt32(Console.ReadLine());
        } 
        public bool isLP()
        {
            if ((0 == year % 4 && 0 != year % 100) || (0 == year % 400))
            {
                return true; 
            }
            else
            {
                return false;
            }
        } 
        public void IST()
        {
            Console.WriteLine("{0} is a Leap .\n", year);
        } 
        public void ISF()
        {
            Console.WriteLine("{0} is not a Leap.\n", year);
        } 
    }
}





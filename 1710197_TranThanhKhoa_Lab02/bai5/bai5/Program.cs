using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class Time
    {
        private int Hour;
        private int Minute;
        private int Second;
        public void Display()
        {
            Console.WriteLine("{0}:{1}:{2}",Hour,Minute,Second);
        }
        public void GetTime(out int h, out int m, out int s)
        {
            h = Hour;
            m = Minute;
            s = Second;
        }
        public Time(System.DateTime dt)
        {
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Time t = new Time(currentTime);
            t.Display();
            /* int theHour = 0;
             int theMinute = 0;
             int theSecond = 0;*/
            int theHour;
            int theMinute;
            int theSecond;
            t.GetTime(out theHour, out theMinute, out theSecond);
            Console.WriteLine("Current time: {0}:{1}:{2}",theHour,theMinute,theSecond);
            Console.ReadLine();
        }
        // Sử dụng out tiện lợi hơn vì nó cho phép sử dụng tham chiếu mà không cần phải khởi gán các giá trị.
    }
}

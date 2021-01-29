using System;

namespace MyDates
{
    public class MyDate
    {
        private  DateTime _dt;
        public MyDate(DateTime dt )
        {
            _dt = dt;
        }
        public MyDate()
        {
            _dt = DateTime.MaxValue;
        }
        public int Year() { return _dt.Year; }

    }
}
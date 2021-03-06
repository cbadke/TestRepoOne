using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class CalendarViewModel
    {
        public CalendarViewModel(int month, int year)
        {
            Month = month;
            Year = year;
            DaysInMonth = new List<int>();

            Events = new List<CalendarEventViewModel>();
        }

        public int Month { get; set; }
        public int Year { get; set; }
        public List<int> DaysInMonth { get; set; }
        public List<CalendarEventViewModel> Events { get; set; }

        public string MonthName
        {
            get
            {
                switch(Month)
                {
                      
                    case 1: 
                        return "January";
                    case 2:
                        return "February";
                    case 3:
                        return "March";
                    case 4:
                        return "April";
                    case 5:
                        return "May";
                    case 6:
                        return "June";
                    case 7:
                        return "July";
                    case 8:
                        return "August";
                    case 9:
                        return "September";
                    case 10:
                        return "October";
                    case 11:
                        return "November";
                    case 12:
                        return "December";
                    default: 
                        return "";
                }
            }
        }
    }
}

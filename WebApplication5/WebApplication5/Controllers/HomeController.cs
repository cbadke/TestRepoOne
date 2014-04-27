using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;


namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Film()
        {
            ViewBag.Title = "Current Movie";
            return View();
        }
        public ActionResult WebForm1()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult Calendar()
        {
            ViewBag.Title = "Calendar";

            var model = new CalendarViewModel(DateTime.Today.Month, DateTime.Today.Year);

            GenerateCalendar(model);
            model.Events = GetEventList();
            return View(model);
        }

        private static List<CalendarEventViewModel> GetEventList()
        {
            var films = new List<CalendarEventViewModel>();
            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "The Killing Fields",
                    Link = "http://www.imdb.com/title/tt0087553/",
                },

                When = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 24, 12, 0, 0),
            });

            films.Add(new CalendarEventViewModel()
            {
                Film = new FilmViewModel
                {
                    Title = "The Great Gatsby",
                    Link = "http://www.imdb.com/title/tt1343092/",

                },
                When = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 26, 12, 0, 0),
            });
            return films;
        }
        
        private void GenerateCalendar(CalendarViewModel viewModel)
        {
            var curdate = 1;
            var daysinmonth = DateTime.DaysInMonth(viewModel.Year, viewModel.Month);
            var monthday1 = (int)(new DateTime(viewModel.Year, viewModel.Month, 1)).DayOfWeek;
            for (var week = 0; curdate <= daysinmonth; week++)
            {
                for (var day = 0; day < 7; day++)
                {
                    if (week == 0 && day < monthday1)
                    {
                        viewModel.DaysInMonth.Add(0);
                    }
                    else if (curdate > daysinmonth)
                    {
                        viewModel.DaysInMonth.Add(0);
                    }
                    else
                    {
                        viewModel.DaysInMonth.Add(curdate);
                        curdate++;
                    }
                }
            }
        }

        public ActionResult Test1()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}
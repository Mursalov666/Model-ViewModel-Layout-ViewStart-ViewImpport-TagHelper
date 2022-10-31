using Microsoft.AspNetCore.Mvc;
using P228.Models;
using P228.ViewModels;
using P228.ViewModels.Home;
using System.Collections.Generic;

namespace P228.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Mark> _marks;
        public HomeController()
        {
            _marks = new List<Mark>
            {
                new Mark{
                    Id = 1,
                    Name = "BMW" ,
                    Count = 500,
                    Cars = new List<Car>
                    {
                        new Car
                        {
                            Model = "3-series",
                            Engine = "2.0L",
                            Year = 2018,
                            Mileage = "15000km"
                        },

                        new Car
                        {
                            Model = "5-series",
                            Engine = "4.4L",
                            Year = 2020,
                            Mileage = "500km"
                        },

                        new Car
                        {
                            Model = "7-series",
                            Engine = "4.4L",
                            Year = 1999,
                            Mileage = "180000km"
                        }
                    }
                },
                new Mark{
                    Id = 2,
                    Name = "Mercedes" ,
                    Count = 450,
                     Cars = new List<Car>
                    {
                        new Car
                        {
                            Model = "C-Class",
                            Engine = "6.3L",
                            Year = 2008,
                            Mileage = "89000km"
                        },

                        new Car
                        {
                            Model = "G-Class",
                            Engine = "4.0L",
                            Year = 2018,
                            Mileage = "46000km"
                        },

                        new Car
                        {
                            Model = "S-Class",
                            Engine = "4.7L",
                            Year = 2014,
                            Mileage = "54000km"
                        }
                    }
                },
                new Mark{
                    Id = 3,
                    Name = "Audi",
                    Count = 350,
                    Cars = new List<Car>
                    {
                        new Car
                        {
                            Model = "A8",
                            Engine = "4.0L",
                            Year = 2022,
                            Mileage = "0km"
                        },

                        new Car
                        {
                            Model = "Q8",
                            Engine = "3.0L",
                            Year = 2018,
                            Mileage = "61000km"
                        },

                        new Car
                        {
                            Model = "RS7",
                            Engine = "4.0L",
                            Year = 2014,
                            Mileage = "71000km"
                        }
                    }
                }
            };
        }

        public IActionResult Index()
        {
            Car car = new Car
            {
                Mileage = "12000km",
                Engine = "4L",
                Year = 2022,
                Model = "M5"
            };

            HomeVM homeVM = new HomeVM
            {
                Car = car,
                Marks = _marks
            };

            return View(homeVM);
        }

        public IActionResult Detail(int? id)
        {
            Mark mark = _marks.Find(m => m.Id == id);

            return View(mark);
        }
    }
}

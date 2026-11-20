using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Graphproject.Controllers
{
    public class GraphController : Controller
    {
        // GET: Graph
        public FileResult Index()
        {
            string[] _xAxis = { "Reliance Industries", "TCS", "SBI", "Infosys", "Titan Company", "HDFC Bank"};
            string[] _yAxis = { "1,375.60", "2,342.70", "2,156", "1,091.90", "4,700", "821.80" };
            var fileBytes = new Chart(width: 600, height: 350)
                 .AddSeries(
                    //chartType: "Column",
                    //chartType: "pie",
                    //chartType: "bar",
                    //chartType: "Doughnut",
                    chartType: "line",
                    xValue: _xAxis,
                    yValues: _yAxis)
                .GetBytes();

            return File(fileBytes, "image/jpeg");
        }
    }
    }

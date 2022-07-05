using FoodShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public String UserReviewAnalysisML()
        {
            //Load sample data
            var sampleData = new MLModel.ModelInput()
            {
                Review = @"Used This Mama Earth Newly Launched Onion Oil twice, and i must say im already impressed by the results !It prevents hair loss, helps control premature greying, dryness, dandruff, scalp eruptions and many other hair problems after its regular use !To avoid dry and frizzy hair, make sure that you use this oil to your hairs twice a week.Oiling provides your scalp with essential nutrients, and also strengthens the hair roots. Mamaearth onion oil works best for your hair during all the seasons.",
            };

            //Load model and predict output
            var result = MLModel.Predict(sampleData).PredictedLabel;
            String review;
            if(result.Equals(4) || result.Equals(5))
            {
                review = "Good Review";

            }
            else if(result.Equals(3))
            {
                review = "Moderate Review";
            }

            else
            {
                review = "Bad Review";
            }

            return review;

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

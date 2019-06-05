using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ExchangeRates.Controllers
{
    public class HomeController : Controller
    {
        private static string API_KEY = "c679f16a-597e-45ee-837d-95296ecb1358";

        static string makeAPICall()
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "5000";
            queryString["convert"] = "USD";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            return client.DownloadString(URL.ToString());

        }
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var stringData = makeAPICall();
                var jsonData = JsonConvert.DeserializeObject<Models.RootObject>(stringData);
                return View(jsonData);
            }
            else
            {
                return Redirect("~/Account/Login");
            }
        }
    }
}
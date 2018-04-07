using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice_1.Models;

namespace Practice_1.Controllers
{
    public class CoinController : Controller
    {
        // GET: Coin
        public ActionResult Index()
        {
            Coin coin = new Coin()
            {
                Id = 1001,
                Symbol = "BTC",
                Name = "Bitcoin",
                Price = 100,
                Change = 2,
                PChange = 2,
                MarketCap = 111111,
                Volume = 2222222,
                Volume24H = 333333,
                TotalVolume24H = 444444,
                CirculatingSupply = 555555
            };
            return View(coin);
        }
    }
}
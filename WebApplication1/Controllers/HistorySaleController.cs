using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/HistorySale")]
    [ApiController]
    public class HistorySaleController : Controller
    {
        ApplicationContext db;
        public HistorySaleController(ApplicationContext context)
        {
            db = context;
            db.HistorySales.Add(new HistorySale { DateSale = Convert.ToDateTime("2020-01-12"), Sale = 10, Price = 11M });
            db.SaveChanges();
            if (!db.HistorySales.Any())
            {

            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GetAmount(db.HistorySales));
        }

        private IEnumerable<Sales> GetSales(DbSet<HistorySale> historySales)
        {
            List<Sales> sales = new List<Sales>();
            foreach (HistorySale historySale in historySales)
            {
                sales.Add(new Sales(historySale.Sale, historySale.DateSale));
            }
            return sales;
        }

        private IEnumerable<AmountDollars> GetAmount(DbSet<HistorySale> historySales)
        {
            List<AmountDollars> amountDollars = new List<AmountDollars>();
            foreach (HistorySale historySale in historySales)
            {
                amountDollars.Add(new AmountDollars(historySale.AmountDollars, historySale.DateSale));
            }
            return amountDollars;
        }
    }
}

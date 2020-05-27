using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AmountDollars
    {
        public AmountDollars(decimal v, DateTime dateTime)
        {
            this.AmountDollar = v;
            this.DayTime = dateTime;
        }

        //private DbSet<HistorySale> historySales;

        public DateTime DayTime { get; set;  }
        public decimal AmountDollar { get; set; }
    }
}

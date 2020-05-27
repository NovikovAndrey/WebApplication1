using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Sales
    {

        public Sales(int sale, DateTime dateSale)
        {
            Sale = sale;
            this.DayTime = dateSale;
        }

        public DateTime DayTime { get; set; }
        public int Sale { get; set; }
    }
}

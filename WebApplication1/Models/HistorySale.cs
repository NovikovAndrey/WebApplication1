using System;

namespace WebApplication1.Models
{
    public class HistorySale
    {

        //public HistorySale(DateTime p1, int p2, decimal p3)
        //{
        //    this.DateSale = p1;
        //    this.Sale = p2;
        //    this.Price = p3;
        //}

        public int Id { get; set; }
        public DateTime DateSale { get; set; }
        public int Sale { get; set; }
        public decimal Price { get; set; }
        public decimal AmountDollars { get; set; }
    }
}
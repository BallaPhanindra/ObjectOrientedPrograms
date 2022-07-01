﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class Stock
    {
        public String name { get; set; }
        public int NumberOfShares { get; set; }
        public int SharePrice { get; set; }
        public int StockPrice { get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}\nPrice: {1}\nNumber of Shares: {2}",
                name, SharePrice, NumberOfShares);
        }
    }

    public class StockPortfolio
    {
        public int grandTotal { get; set; }
        public List<Stock> StockList;
    }
}
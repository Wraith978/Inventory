using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public abstract class Item
    {
        protected int quantity;
        protected bool stockArrived;
        protected DateTime estimatedArrival;
        protected int jobNumber;

        public int Quantity { get { return quantity; } set { quantity = value; } }
        public bool StockArrived { get { return stockArrived; } set { stockArrived = value; } }
        public DateTime EstimatedArrival { get { return estimatedArrival; } set { estimatedArrival = value; } }
        public int JobNumber { get { return jobNumber; } set{ jobNumber=value; } }
    }
}

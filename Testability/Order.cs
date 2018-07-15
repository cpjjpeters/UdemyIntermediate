using System;

namespace Testability
{
    public class Order
    {
        public int Id { get; set; }
        
        public float TotalPrice;

        public Shipment Shipment { get; set; }
        public DateTime DatePlaced { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}
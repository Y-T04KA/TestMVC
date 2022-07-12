using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public string SenderCity { get; set; }
        public string SenderAdress { get; set; }
        public string DestCity { get; set; }
        public string DestAdress { get; set; }
        public double Weight { get; set; }
        public DateTime cargoDate { get; set; }
    }
}

using System;

namespace NourishNaviGit.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        // Other order-specific fields
        public User User { get; set; }
    }
}
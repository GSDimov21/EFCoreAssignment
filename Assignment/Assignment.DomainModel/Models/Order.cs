﻿namespace Assignment.DomainModel.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }
    }
}

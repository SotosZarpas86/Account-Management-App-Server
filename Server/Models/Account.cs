using System;

namespace Api.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
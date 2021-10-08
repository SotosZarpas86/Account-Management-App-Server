using System;

namespace Api.Models.Resources
{
    public class GetAccountModel
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
    }
}

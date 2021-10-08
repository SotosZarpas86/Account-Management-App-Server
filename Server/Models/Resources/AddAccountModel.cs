using System;

namespace Api.Models.Resources
{
    public class AddAccountModel
    {
        public string AccountNo { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Amount { get; set; }
    }
}

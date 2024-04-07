using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_N01600569
{
    public class Account
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public string AccountType { get; set; }
        public double CurrentBalance { get; set; }
        public DateTime DateCreated { get; set; }

    }
}

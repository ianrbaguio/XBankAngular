using System;
using System.Collections.Generic;

#nullable disable

namespace XBankAngular.DAO.Models
{
    public partial class Accounttype
    {
        public Accounttype()
        {
            Accounts = new HashSet<Account>();
            Transactions = new HashSet<Transaction>();
        }

        public int Accounttypeid { get; set; }
        public string Accounttype1 { get; set; }
        public string Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? Enddate { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

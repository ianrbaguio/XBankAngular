using System;
using System.Collections.Generic;

#nullable disable

namespace XBankAngular.DAO.Models
{
    public partial class Account
    {
        public Account()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Accountid { get; set; }
        public int Accounttypeid { get; set; }
        public int Clientid { get; set; }
        public int Pin { get; set; }
        public decimal? Balance { get; set; }
        public DateTime Lasttransaction { get; set; }
        public DateTime Datecreated { get; set; }

        public virtual Accounttype Accounttype { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

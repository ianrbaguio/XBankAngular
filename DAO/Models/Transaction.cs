using System;
using System.Collections.Generic;

#nullable disable

namespace XBankAngular.DAO.Models
{
    public partial class Transaction
    {
        public int Transactionid { get; set; }
        public int Accountid { get; set; }
        public int Accounttypeid { get; set; }
        public string Transactiontype { get; set; }
        public decimal Balance { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public virtual Account Account { get; set; }
        public virtual Accounttype Accounttype { get; set; }
    }
}

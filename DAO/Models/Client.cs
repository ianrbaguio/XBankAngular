using System;
using System.Collections.Generic;

#nullable disable

namespace XBankAngular.DAO.Models
{
    public partial class Client
    {
        public Client()
        {
            Accounts = new HashSet<Account>();
        }

        public int Clientid { get; set; }
        public string Clienttypeid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? Enddate { get; set; }

        public virtual Clienttype Clienttype { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}

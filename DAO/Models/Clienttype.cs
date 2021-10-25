using System;
using System.Collections.Generic;

#nullable disable

namespace XBankAngular.DAO.Models
{
    public partial class Clienttype
    {
        public Clienttype()
        {
            Clients = new HashSet<Client>();
        }

        public string Clienttypeid { get; set; }
        public string Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? Enddate { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}

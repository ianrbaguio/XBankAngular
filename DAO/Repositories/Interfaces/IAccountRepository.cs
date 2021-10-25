using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XBankAngular.DAO.Models;

namespace XBankAngular.DAO.Repositories.Interfaces
{
    public interface IAccountRepository: IDisposable
    {
        List<Account> GetAccounts();

        Account GetAccount(int accountID);

        void Add(Account account);

        void Update(Account account);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XBankAngular.DAO.Repositories.Interfaces;
using XBankAngular.DAO.Models;

namespace XBankAngular.DAO.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly XBankContext context;

        public AccountRepository(XBankContext context)
        {
            this.context = context;
        }

        public List<Account> GetAccounts()
        {
            return context.Accounts.ToList();
        }

        public Account GetAccount(int accountID)
        {
            var account = context.Accounts.Select(a => a.Accountid == accountID);

            return (Account)account;
        }

        public void  Add(Account account)
        {
            context.Accounts.Add(account);
            context.SaveChanges();
        }

        public void Update (Account account)
        {
            context.Accounts.Update(account);
            context.SaveChanges();
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

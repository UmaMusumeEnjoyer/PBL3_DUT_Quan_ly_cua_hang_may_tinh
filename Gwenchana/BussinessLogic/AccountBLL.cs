using Gwenchana.DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gwenchana.DataAccess.DTO;

namespace Gwenchana.BussinessLogic
{
    public class AccountBLL
    {
        public bool Login(string username, string password)
        {
            AccountDAL accountDAL = new AccountDAL();
            List<Account> accounts = accountDAL.GetAllAccounts();
            foreach (Account account in accounts) 
            {
                if (account.Username == username && account.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Register(string username, string password, string role)
        {
            AccountDAL accountDAL = new AccountDAL();
            List<Account> accounts = accountDAL.GetAllAccounts();
            foreach (Account account in accounts)
            {
                if (account.Username == username)
                {
                    return false; // Username already exists
                }
            }
            Account newAccount = new Account
            {
                Username = username,
                Password = password,
                Role = "Employee" // Default role
            };
            return accountDAL.AddAccount(newAccount);
        }


        public string GetRole(string username)
        {
            AccountDAL accountDAL = new AccountDAL();
            List<Account> accounts = accountDAL.GetAllAccounts();
            foreach (Account account in accounts)
            {
                if (account.Username == username)
                {
                    return account.Role;
                }
            }
            return null;
        }


    }
}

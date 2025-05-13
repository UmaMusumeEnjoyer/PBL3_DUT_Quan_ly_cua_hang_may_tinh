using Gwenchana.DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gwenchana.DataAccess.DTO;
using System.Data;

namespace Gwenchana.BussinessLogic
{
    public class AccountBLL
    {
        private readonly AccountDAL _accountDAL = new AccountDAL();
        public bool Login(string username, string password)
        {
            
            List<Account> accounts = _accountDAL.GetAllAccounts();
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
           
            List<Account> accounts = _accountDAL.GetAllAccounts();
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
            return _accountDAL.AddAccount(newAccount);
        }

        public string GetRole(string username)
        {
            
            List<Account> accounts = _accountDAL.GetAllAccounts();
            foreach (Account account in accounts)
            {
                if (account.Username == username)
                {
                    return account.Role;
                }
            }
            return null;
        }

        public bool ChangePassword(string username, string newPassword)
        {
            
            List<Account> accounts = _accountDAL.GetAllAccounts();
            foreach (Account account in accounts)
            {
                if (account.Username == username)
                {
                    account.Password = newPassword;
                    return _accountDAL.UpdateAccount(account);
                }
            }
            return false;
        }
        public bool ChangeUsername(string oldUsername, string newUsername)
        {
            
            List<Account> accounts = _accountDAL.GetAllAccounts();
            foreach (Account account in accounts)
            {
                if (account.Username == oldUsername)
                {
                    account.Username = newUsername;
                    return _accountDAL.UpdateAccount(account);
                }
            }
            return false;
        }

        public DataTable GetAllAccountsDataTable()
        {
           
            return _accountDAL.GetAllAccountDataTable();
        }

        public bool DeleteAccount(int id)
        {
            return _accountDAL.DeleteAccount(id);
        }

        public bool UpdateAccount(Account account)
        {
            return _accountDAL.UpdateAccount(account);
        }

        public bool AssignEmployee(int id)
        {

            return _accountDAL.AssignEmployee(id);
        }

        public int GetId(string username)
        {
            List<Account> accounts = _accountDAL.GetAllAccounts();
            foreach (Account account in accounts)
            {
                if (account.Username == username)
                {
                    return account.Id;
                }
            }
            return 0;
        }

    }
}

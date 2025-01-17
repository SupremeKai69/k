﻿
namespace OpenBets.Shared.DataAccess;

public interface IAccountData
{
   Task CreateAccount(Account account);
   Task<Account> GetAccount(string id);
   Task<Account> GetAccountFromAutentication(string objectId);
   Task<List<Account>> GetAccountsAsync();
   Task UpdateAccount(Account account);
}
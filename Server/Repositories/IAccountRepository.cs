using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public interface IAccountRepository
    {
        Task<List<Account>> GetAllAccountsAsync(int userId);
        Task<Account> GetAccountByIdAsync(int id, int userId);
        Task<Account> AddAccountAsync(Account account, int userId);
        Task<bool> UpdateAccountAsync(Account account, int userId);
        Task<bool> DeleteAccountAsync(int id, int userId);
    }
}
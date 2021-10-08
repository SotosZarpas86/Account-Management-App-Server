using Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;

        public AccountRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Account>> GetAllAccountsAsync(int userId)
        {
            return await _context.Accounts.Where(a => a.UserId == userId).ToListAsync();
        }

        public async Task<Account> GetAccountByIdAsync(int id, int userId)
        {
            return await _context.Accounts.FirstOrDefaultAsync(c => c.Id == id && c.User.Id == userId);
        }

        public async Task<Account> AddAccountAsync(Account account, int userId)
        {
            account.User = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
            return account;
        }

        public async Task<bool> UpdateAccountAsync(Account account, int userId)
        {
            var accountToUpdate = await _context.Accounts.Include(c => c.User).FirstOrDefaultAsync(c => c.Id == account.Id);
            if (accountToUpdate.User.Id == userId)
            {
                accountToUpdate.AccountNo = account.AccountNo;
                accountToUpdate.Amount = account.Amount;
                accountToUpdate.UserId = account.UserId;

                _context.Accounts.Update(accountToUpdate);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteAccountAsync(int id, int userId)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync(c => c.Id == id && c.User.Id == userId);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

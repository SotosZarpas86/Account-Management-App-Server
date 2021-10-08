using Api.Models;
using Api.Models.Resources;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface IAccountService
    {
        Task<ServiceResponse<GetAccountModel>> AddAccount(AddAccountModel account);
        Task<ServiceResponse<int>> DeleteAccount(int id);
        Task<ServiceResponse<GetAccountModel>> GetAccountById(int id);
        Task<ServiceResponse<List<GetAccountModel>>> GetAllAccounts();
        Task<ServiceResponse<List<GetAccountModel>>> GetAllAccounts(int pageNumber, int pageSize);
        Task<ServiceResponse<GetAccountModel>> UpdateAccount(UpdateAccountModel account);
    }
}
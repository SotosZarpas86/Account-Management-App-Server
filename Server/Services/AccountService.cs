using Api.Models;
using Api.Models.Resources;
using Api.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Api.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public AccountService(IAccountRepository accountRepository,
                              IHttpContextAccessor httpContextAccessor,
                              IMapper mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        public async Task<ServiceResponse<List<GetAccountModel>>> GetAllAccounts()
        {
            var serviceResponse = new ServiceResponse<List<GetAccountModel>>();

            var dbAccounts = await _accountRepository.GetAllAccountsAsync(GetUserId());
            var accounts = _mapper.Map<List<GetAccountModel>>(dbAccounts);

            serviceResponse.Data = accounts;
            serviceResponse.SumOfRecords = dbAccounts.Count;

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetAccountModel>>> GetAllAccounts(int pageNumber, int pageSize)
        {
            var serviceResponse = new ServiceResponse<List<GetAccountModel>>();

            var skip = (pageNumber - 1) * pageSize;
            var dbAccounts = await _accountRepository.GetAllAccountsAsync(GetUserId());
            var result = dbAccounts.Skip(skip).Take(pageSize).ToList();

            var accounts = _mapper.Map<List<GetAccountModel>>(result);

            serviceResponse.Data = accounts;
            serviceResponse.SumOfRecords = dbAccounts.Count;

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetAccountModel>> GetAccountById(int id)
        {
            var serviceResponse = new ServiceResponse<GetAccountModel>();

            var dbAccount = await _accountRepository.GetAccountByIdAsync(id, GetUserId());

            var account = _mapper.Map<GetAccountModel>(dbAccount);

            serviceResponse.Data = account;

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetAccountModel>> AddAccount(AddAccountModel account)
        {
            var serviceResponse = new ServiceResponse<GetAccountModel>();

            var accountdb = _mapper.Map<Account>(account);

            accountdb = await _accountRepository.AddAccountAsync(accountdb, GetUserId());

            var mappedAccount = _mapper.Map<GetAccountModel>(accountdb);

            serviceResponse.Data = mappedAccount;
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetAccountModel>> UpdateAccount(UpdateAccountModel account)
        {
            var serviceResponse = new ServiceResponse<GetAccountModel>();
            try
            {
                var accountToUpdate = _mapper.Map<Account>(account);
                var result = await _accountRepository.UpdateAccountAsync(accountToUpdate, GetUserId());
                if (result)
                {
                    var mappedAccount = _mapper.Map<GetAccountModel>(accountToUpdate);
                    serviceResponse.Data = mappedAccount;
                }
                else
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Account not found.";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<int>> DeleteAccount(int id)
        {
            var serviceResponse = new ServiceResponse<int>();
            try
            {
                var result = await _accountRepository.DeleteAccountAsync(id, GetUserId());
                if (result)
                {
                    serviceResponse.Data = id;
                }
                else
                {
                    serviceResponse.Data = 0;
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Account not found.";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Data = 0;
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
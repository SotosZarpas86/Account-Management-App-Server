using Api.Controllers;
using Api.Models;
using Api.Models.Resources;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Api.Tests
{
    public class AccountControllerTests
    {
        private readonly Mock<IAccountService> _accountService;

        public AccountControllerTests()
        {
            _accountService = new Mock<IAccountService>();
        }

        [Fact]
        public async Task Account_GetListOfAccounts_ReturnsValidAccountData()
        {           
            _accountService.Setup(s => s.GetAllAccounts(1, 3)).ReturnsAsync(GetAccounts());
            var controller = new AccountController(_accountService.Object);

            var actionResult = await controller.GetWithPaging(1, 3) as OkObjectResult;
            var actual = actionResult.Value as ServiceResponse<List<GetAccountModel>>;

            Assert.Equal(GetAccounts().Data.Count, actual.Data.Count);
        }

        [Fact]
        public async Task Account_GetAccount_With_ValidId()
        {
            _accountService.Setup(s => s.GetAccountById(1)).ReturnsAsync(GetAccount());
            var controller = new AccountController(_accountService.Object);

            var actionResult = await controller.GetSingle(1) as OkObjectResult;
            var actual = actionResult.Value as ServiceResponse<GetAccountModel>;

            Assert.Equal(GetAccount().Data.Id, actual.Data.Id);
            Assert.Equal(GetAccount().Data.AccountNo, actual.Data.AccountNo);
            Assert.Equal(GetAccount().Data.Amount, actual.Data.Amount);
        }

        [Fact]
        public void Account_AddAccount_ReturnsSuccessfulResponse()
        {
            var controller = new AccountController(_accountService.Object);
            var actionResult = controller.AddAccount(GetAccountToCreate());
            var result = actionResult.Result;
            Assert.IsType<OkObjectResult>(result);
        }

        #region Test Data

        private static ServiceResponse<List<GetAccountModel>> GetAccounts()
        {
            var serviceResponse = new ServiceResponse<List<GetAccountModel>>();

            var accountsList = new List<GetAccountModel>
            {
                new GetAccountModel { Id = 1, AccountNo = "GR32882957347263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new GetAccountModel { Id = 2, AccountNo = "GR00324783252634532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new GetAccountModel { Id = 3, AccountNo = "GR12309848325265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now }
            };

            serviceResponse.Data = accountsList;
            return serviceResponse;
        }

        private static ServiceResponse<GetAccountModel> GetAccount()
        {
            var serviceResponse = new ServiceResponse<GetAccountModel>();
            serviceResponse.Data = new GetAccountModel { Id = 1, AccountNo = "GR32882957347263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now };
            return serviceResponse;
        }

        private static AddAccountModel GetAccountToCreate()
        {
            return new AddAccountModel { AccountNo = "12345", Amount = 10000, CreatedAt = DateTime.Now };
        }

        #endregion
    }
}

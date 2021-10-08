using Api.Models.Resources;
using Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin, Customer")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _accountService.GetAllAccounts());
        }

        [HttpGet("GetAllWithPaging")]
        public async Task<IActionResult> GetWithPaging(int pageNumber, int pageSize)
        {
            return Ok(await _accountService.GetAllAccounts(pageNumber, pageSize));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _accountService.GetAccountById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddAccount(AddAccountModel account)
        {
            return Ok(await _accountService.AddAccount(account));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAccount(UpdateAccountModel account)
        {
            var response = await _accountService.UpdateAccount(account);

            if (!response.Success)
                return NotFound(response);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            var response = await _accountService.DeleteAccount(id);

            if (response.Data == 0)
                return NotFound(response);

            return Ok(response);
        }
    }
}
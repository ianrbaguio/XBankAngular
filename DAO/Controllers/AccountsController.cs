using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XBankAngular.DAO.Models;
using XBankAngular.DAO.Repositories;
using XBankAngular.DAO.Repositories.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace XBankAngular.DAO.Controllers
{
    [Route("api/user")]
    [AllowAnonymous]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository repository;

        public AccountsController(IAccountRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/<AccountsController>
        [HttpGet]
        public ActionResult<List<Account>> GetAccounts()
        {
            return repository.GetAccounts();
        }

        // GET api/<AccountsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccountsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AccountsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test1.Infrastructure.EF.Repositories;
using test1.Models.Customers;

namespace test1.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ValuesController : ControllerBase 
    {
        private IRepositoryCustomer repositoryCustomer { get; }


        public ValuesController(IRepositoryCustomer repositoryCustomer)
        {
            this.repositoryCustomer = repositoryCustomer;
        }

        [HttpGet("GetByCustomerId/{customerId}")]
        public async Task<ActionResult<Customer>> GetByCustomerId(int customerId)
        {
            var customer = await repositoryCustomer.GetById(customerId);
            //var dto = customer.CustomerToDTO();

            if (customer != null)
            {
                return customer;
            }

            return NotFound();
        }

        [HttpGet("GetByEmail")]
        public async Task<ActionResult<Customer>> GetByEmail(string email)
        {
            var customer = await repositoryCustomer.GetByEmail(email);
            if (customer != null)
            {
                return customer;
            }
            return NotFound();
        }

        [HttpGet("GetByEmailAndCustomerId")]
        public async Task<ActionResult<Customer>> GetByEmailAndCustomerId(string email, int id)
        {
            var customer = await repositoryCustomer.GetByEmailAndId(email, id);
            if (customer != null)
            {
                return customer;
            }
            return NotFound();
        }

        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

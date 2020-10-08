using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RameshWorkBook.DAL.DBContext;
using RameshWorkBook.DAL.Entity;
using RameshWorkBook.Delegate;

namespace RameshWorkBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly WorkBookDBContext _WorkBookDbContext;        
        public CustomerController(WorkBookDBContext workBookDbContext)
        {
            this._WorkBookDbContext = workBookDbContext;
            
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await _WorkBookDbContext.Customers.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<Customer> Get(int Id)
        {
            return await _WorkBookDbContext.Customers.FirstOrDefaultAsync(cust => cust.Id == Id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer customer)
        {
            if (customer == null) return null;
            await _WorkBookDbContext.AddAsync(customer);
            await _WorkBookDbContext.SaveChangesAsync();
            return CreatedAtAction("Get", customer.Id, customer);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Customer customer)
        {
            if (customer == null) return null;
            _WorkBookDbContext.Update(customer);
            await _WorkBookDbContext.SaveChangesAsync();
            return CreatedAtAction("Get", customer.Id, customer);
        }

        [HttpPatch("{Id}")]
        public async Task<IActionResult> Patch(int Id, [FromBody] JsonPatchDocument<Customer> patchDoc)
        {
            if (patchDoc == null) return null;
            Customer customer = await _WorkBookDbContext.Customers.FirstOrDefaultAsync(cust => cust.Id == Id);

            patchDoc.ApplyTo(customer, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _WorkBookDbContext.SaveChangesAsync();
            return new ObjectResult(customer);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            Customer customer = await _WorkBookDbContext.Customers.FirstOrDefaultAsync(cust => cust.Id == Id);
            if (customer == null)
                return Ok("Customer does not exist");
            else
            {                
                _WorkBookDbContext.Customers.Remove(customer);
                await _WorkBookDbContext.SaveChangesAsync();
                var data = new ConsumeDeleteCustomerEvent();
                data.Consume();
                new DeleteCustomerEventManager().HandleDeleteCustomer(customer.Id, customer.Name);
                return Ok("Item Removed");
            }
        }
       
    }
}
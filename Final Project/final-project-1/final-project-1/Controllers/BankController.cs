using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_project_1.Data;
using final_project_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace final_project_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController: ControllerBase
    {
        private readonly AppDbContext _context;

        public BankController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItem()
        {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new { data.paymentDetailId }, data);
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemData item)
        {
            if (id != item.paymentDetailId)
            {
                return BadRequest();
            }
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if (existItem == null)
            {
                return NotFound();
            }

            existItem.paymentDetailId = item.paymentDetailId;
            existItem.cardOwnerName = item.cardOwnerName;
            existItem.cardNumber = item.cardNumber;
            existItem.expirationDate = item.expirationDate;
            existItem.securityCode = item.securityCode;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if (existItem == null)
            {
                return NotFound();
            }

            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}

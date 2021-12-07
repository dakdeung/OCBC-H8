using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using JwtApp.Models;
using JwtApp.Data;

namespace JwtApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class JwtController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public JwtController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItem()
        {
            var items = await _context.items.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data)
        {
            if(ModelState.IsValid)
            {
                await _context.items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.id}, data);
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.items.FirstOrDefaultAsync(x => x.id == id);

            if(item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemData item)
        {
            if(id != item.id){
                return BadRequest();
            }
            var existItem = await _context.items.FirstOrDefaultAsync(x => x.id == id);

            if(existItem == null){
                return NotFound();
            }

            existItem.Title = item.Title;
            existItem.Description = item.Description;
            existItem.Done = item.Done;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.items.FirstOrDefaultAsync(x => x.id == id);

            if(existItem == null){
                return NotFound();
            }

            _context.items.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}

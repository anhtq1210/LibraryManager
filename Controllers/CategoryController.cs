using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_12_04.Data;
using WebAPI_12_04.Models;
using WebAPI_12_04.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebAPI_12_04.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly LibDbContext _context;
        public CategoryController(LibDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryVM>>> GetAllCategory()
        {
             var categories = await _context.Category
             .Select(x => new { ID = x.ID, Name = x.Name, InitialDate = x.InitialDate })
                .ToListAsync();
             var categoryVms = categories.
             Select(x => new CategoryVM {ID= x.ID, Name = x.Name, InitialDate = x.InitialDate }).ToList();
             return categoryVms;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryVM>> GetCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            var categoryVM = new CategoryVM
            {
                ID = category.ID,
                Name = category.Name
            };

            return categoryVM;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrand(int id, CategoryCreateRequest categoryCreateRequest)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            category.Name = categoryCreateRequest.Name;
            category.InitialDate = categoryCreateRequest.InitialDate;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<CategoryVM>> PostBrand(CategoryCreateRequest categoryCreateRequest)
        {
            var category = new Category
            {
                Name = categoryCreateRequest.Name,
                InitialDate = categoryCreateRequest.InitialDate
            };

            _context.Category.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategory), new { id = category.ID }, null);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
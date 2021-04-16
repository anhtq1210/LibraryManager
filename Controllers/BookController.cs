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
    public class BookController : ControllerBase
    {
        private readonly LibDbContext _context;
        public BookController(LibDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookVM>>> GetBooks()
        {
            return await _context.Book
                .Select(x => new BookVM { ID = x.ID, Name = x.Name, Author = x.Author, PublicDate = x.PublicDate })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookVM>> GetBook(int id)
        {
            var book = await _context.Book.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            var bookVM = new BookVM
            {
                ID = book.ID,
                Name = book.Name,
                Author = book.Author,
                PublicDate = book.PublicDate,
            };

            return bookVM;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, BookCreateRequest bookCreateRequest)
        {
            var book = await _context.Book.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            book.Name = bookCreateRequest.Name;
            book.Author = bookCreateRequest.Author;
            book.InitialDate = bookCreateRequest.InitialDate;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<BookVM>> PostBook(BookCreateRequest bookCreateRequest)
        {
            var book = new Book
            {
                Name = bookCreateRequest.Name,
                Author = bookCreateRequest.Author,
                PublicDate = bookCreateRequest.PublicDate,
                InitialDate = bookCreateRequest.InitialDate,
                CategoryID = bookCreateRequest.CategoryID
            };

            _context.Book.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBook), new { id = book.ID }, null);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Book.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_12_04.Data;
using WebAPI_12_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_12_04.Models;
using WebAPI_12_04.ViewModel;
using WebAPI_12_04.Data;
namespace WebAPI_12_04.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : ControllerBase
    {
        private readonly LibDbContext _context;
        public RequestController(LibDbContext context)
        {
            _context = context;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using mf_dev_back_end.Models;

namespace mf_dev_back_end.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly AppDbContext _context;
        public VehiclesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Vehicles.ToListAsync();

            return View(data);
        }
    }
}

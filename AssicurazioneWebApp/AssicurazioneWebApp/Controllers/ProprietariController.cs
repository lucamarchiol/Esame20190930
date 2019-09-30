using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssicurazioneWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssicurazioneWebApp.Controllers
{
    public class ProprietariController : Controller
    {
        private readonly MagicContext _context;

        public ProprietariController(MagicContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Proprietari.ToListAsync());
        }
    }
}
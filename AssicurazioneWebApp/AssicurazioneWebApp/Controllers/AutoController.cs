using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssicurazioneWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace AssicurazioneWebApp.Controllers
{
    public class AutoController : Controller
    {
        private readonly MagicContext _context;

        public AutoController(MagicContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Auto);
        }
    }
}
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using AssicurazioneWebApp.Data;

namespace AssicurazioneWebApp.Controllers
{
    public class ProprietariController : Controller
    {
        private readonly MagicContext _context;

        public ProprietariController(MagicContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View( _context.Proprietari);
        }
    }
}
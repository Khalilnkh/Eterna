using Eterna.DAL;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {  
        private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<TeamTrainer> teamTrainers = _context.TeamTrainers.Include(t=>t.TeamPosition).ToList();
            return View(teamTrainers);
        }
    }
}

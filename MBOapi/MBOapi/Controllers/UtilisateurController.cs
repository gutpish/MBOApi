using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MBOapi.Database;
using MBOapi.Database.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MBOapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtilisateurController : ControllerBase
    {

        private readonly ILogger<UtilisateurController> _logger;
        private readonly MBOContext _context;

        public UtilisateurController(ILogger<UtilisateurController> logger, MBOContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public Utilisateur Login([FromBody] Utilisateur param)
        {
            Utilisateur utilisateur;
            using(_context)
            {
                utilisateur = _context.Utilisateurs.FirstOrDefault(x=> x.LoginUtilisateur == param.LoginUtilisateur && x.MotDePasseUtilisateur == param.MotDePasseUtilisateur);
            }
            return utilisateur;

        }
    }
}

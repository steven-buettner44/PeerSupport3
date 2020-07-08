using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PeerSupport3.Data;
using PeerSupport3.Models;

namespace PeerSupport3.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly PeerSupport3.Data.PeerSupport3Context _context;

        public IndexModel(PeerSupport3.Data.PeerSupport3Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

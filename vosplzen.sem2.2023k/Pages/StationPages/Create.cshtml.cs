using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vosplzen.sem2._2023k.Data;
using vosplzen.sem2._2023k.Data.Model;

namespace vosplzen.sem2._2023k.Pages.StationPages
{
    public class CreateModel : PageModel
    {

        [BindProperty]
        public Station Station { get; set; }

        private ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            Station = new Station();
            _context = context;
        }

        public IActionResult OnPost()
        {
            _context.Stations.Add(Station);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}

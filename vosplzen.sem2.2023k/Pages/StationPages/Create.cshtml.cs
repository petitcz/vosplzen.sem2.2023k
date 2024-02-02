using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vosplzen.sem2._2023k.Data;
using vosplzen.sem2._2023k.Data.Model;
using vosplzen.sem2._2023k.Services;
using static System.Collections.Specialized.BitVector32;

namespace vosplzen.sem2._2023k.Pages.StationPages
{
    public class CreateModel : PageModel
    {

        [BindProperty]
        public Station Station { get; set; }

        private IStationService _stationservice;

        public CreateModel(IStationService stationservice)
        {
            Station = new Station();
            _stationservice = stationservice;
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _stationservice.AddStation(Station);
        
            return RedirectToPage("./Index");
        }
    }
}

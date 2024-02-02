using Microsoft.AspNetCore.Mvc;
using System.Net;
using vosplzen.sem2._2023k.Data;
using vosplzen.sem2._2023k.Data.Migrations;
using vosplzen.sem2._2023k.Data.Model;

namespace vosplzen.sem2._2023k.Controllers
{

    [ApiController]
    [Route("api")]
    public class StationController : Controller
    {
        private ApplicationDbContext _context {  get; set; }

        public StationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("get-stations")]
        public IActionResult GetListOfStations()
        {
            var list = _context.Stations.ToList();
            return StatusCode(200, new JsonResult(list));

        }


        [HttpPost]
        [Route("add-station")]
        public IActionResult AddStation(Station station)
        {

            if(_context.Stations.Where(x=>x.Title.Equals(station.Title)).Any())
            {
                return StatusCode(400,
                    new JsonResult("Duplicities are not allowed. Sorry."));
            }

            _context.Stations.Add(station);
            _context.SaveChanges();

            return StatusCode(200, 
                new JsonResult("Station has been succesfully add."));

        }

    }
}

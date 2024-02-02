using vosplzen.sem2._2023k.Data;
using vosplzen.sem2._2023k.Data.Model;

namespace vosplzen.sem2._2023k.Services
{
    public class StationService:IStationService
    {
        private ApplicationDbContext _context {  get; set; }

        public StationService(ApplicationDbContext context) {
            _context = context;
        }

        public void AddStation(Station station)
        {
            _context.Stations.Add(station);
            _context.SaveChanges();
        }

    }
}

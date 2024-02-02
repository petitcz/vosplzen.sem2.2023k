using System.ComponentModel.DataAnnotations;

namespace vosplzen.sem2._2023k.Data.Model
{
    public class Station
    {
        [Key]
        public int Id {  get; set; }
        public string Title { get; set; }
        public int FloodLevel { get; set; }
        public int DroughtLevel { get; set; }
        public int TimeOutInMinutes { get; set; }

    }
}

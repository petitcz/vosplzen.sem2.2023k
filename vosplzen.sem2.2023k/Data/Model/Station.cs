using System.ComponentModel.DataAnnotations;

namespace vosplzen.sem2._2023k.Data.Model
{
    public class Station
    {
        [Key]
        public int Id {  get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        [Range(1,100)]
        public int FloodLevel { get; set; }

        [Required]
        [Range(1, 100)]
        public int DroughtLevel { get; set; }
        
        [Required]
        public int TimeOutInMinutes { get; set; }

    }
}

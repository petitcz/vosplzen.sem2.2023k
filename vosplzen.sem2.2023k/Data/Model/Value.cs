using System.ComponentModel.DataAnnotations;

namespace vosplzen.sem2._2023k.Data.Model
{
    public class Value
    {
        [Key]
        public int Id { get; set; }

        public int Val {  get; set; }

        public DateTime TimeStamp { get; set; }

        public int StationId {  get; set; }

        public virtual Station Station { get; set; }

    }
}

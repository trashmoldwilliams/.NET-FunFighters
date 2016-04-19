using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunFighters.Models
{
    [Table("fighters")]
    public class Fighter
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int wins { get; set; }
        public int imageid {get; set; }
        public int hp { get; set; }
        public int mp { get; set; }
        public int attack { get; set; }
        public int speed { get; set; }
        public int luck { get; set; }
    }
}
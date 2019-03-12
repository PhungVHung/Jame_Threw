using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace J4.Models
{
    public class Contest
    {
        [Key]
        public int Id_contest { get; set; }
        public string Name_contest { get; set; }
        public string Img_contest { get; set; }
        public string Link { get; set; }
        public string Describle { get; set; }
        public string CreateBy { get; set; }
    }
}

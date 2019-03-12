using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace J4.Models
{
    public class Announcenment
    {
        [Key]
        public int Id_announ { get; set; }
        public string Tittle_announ { get; set; }
        public string Describle_announ { get; set; }
        public string Image_announ { get; set; }
    }
}

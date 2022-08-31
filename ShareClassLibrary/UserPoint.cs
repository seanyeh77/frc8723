using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareClassLibrary
{
    public class UserPoint
    {
        [Required]
        public string ChineseName { get; set; }
        [Required]
        public string ID { get; set; }
        [Required]
        public int? grade { get; set; }
        [Required]
        public float monaverage { get; set; }
        [Required]
        public double dayaverage { get; set; }
        public double totaleverydayminute { get; set; }
        public int notcheckday { get; set; }
        public bool state { get; set; }
    }
}

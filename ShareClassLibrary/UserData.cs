using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareClassLibrary
{
    public class UserData
    {
        [Required]
        public string ID { get; set; }

        [Required]
        public int? grade { get; set; }

        [Required]
        public string ChineseName { get; set; }
        [Required]
        public bool freeze { get; set; } = false;
    }
}

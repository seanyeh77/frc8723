using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareClassLibrary
{
    public class UserLog
    {
        [Required]
        public string ChineseName { get; set; }

        [Required]
        public DateTime time { get; set; }
    }
}

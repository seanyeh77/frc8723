using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareClassLibrary
{
    public class StudentData:TeacherData
    {
        public List<string> Position { get; set; } = new List<string>();

    }
}

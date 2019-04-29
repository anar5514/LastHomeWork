using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04HomeWork.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public string Teacher { get; set; }
        public string KindOfService { get; set; }
        public int Level { get; set; }
        public Group Group { get; set; }
        public DateTime EndTime { get; set; }
    }
}

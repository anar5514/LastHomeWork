using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04HomeWork.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public int PassportNo { get; set; }
        public string FIN { get; set; }
        public string Username { get; set; }
        public Group Group { get; set; }
        public string KindOfService { get; set; }
        public int ContractNo { get; set; }
    }
}

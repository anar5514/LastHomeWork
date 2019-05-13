using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04HomeWork.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Branch Branch { get; set; }
        public string Note { get; set; }
        public Subject Subject { get; set; }
        public string KindOfService { get; set; }

        public Group Clone()
        {
            Group newgroup = new Group();
            newgroup.Branch = this.Branch;
            newgroup.Id = this.Id;
            newgroup.Level = this.Level;
            newgroup.Name = this.Name;
            newgroup.Note = this.Note;
            newgroup.Subject = this.Subject;
            return newgroup;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DAO
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName {  get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}

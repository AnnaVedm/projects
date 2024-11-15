using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DAO
{
    public class GroupSubject
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int SubjectId { get; set; }
        public int SemesterDuration { get; set; }

        //связь с группой и предметом
        public virtual Group Group { get; set; }
        public virtual Subject Subject { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DAO
{
    public class AttendanceMark
    {
        public int Id { get; set; }
        public string MarkName {  get; set; }

        // Навигационное свойство для связи с посещаемостью
        public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}

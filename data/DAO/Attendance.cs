using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DAO
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public int LessonA { get; set; } //начало диапазона уроков
        public int LessonB { get; set; } //конец диапазона уроков
        public int AttendanceMarkId { get; set; } //отметка о посещаемости

        //навигационные свойства
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual AttendanceMark AttendanceMark { get; set; }

    }
}

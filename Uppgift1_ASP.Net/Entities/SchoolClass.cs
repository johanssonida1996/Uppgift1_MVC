using System;
using System.Collections.Generic;
using System.ComponentModel;
using Uppgift1_ASP.Net.Data;

#nullable disable

namespace Uppgift1_ASP.Net.Entities
{
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            SchoolClassStudents = new HashSet<SchoolClassStudent>();
        }

        public Guid Id { get; set; }
        public string ClassName { get; set; }

        [DisplayName("Teacher")]
        public string TeacherId { get; set; }

        public virtual AppUser Teacher { get; set; }

        public virtual ICollection<SchoolClassStudent> SchoolClassStudents { get; set; }
    }
}

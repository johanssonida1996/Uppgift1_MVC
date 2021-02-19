using System;
using System.Collections.Generic;
using System.ComponentModel;
using Uppgift1_ASP.Net.Data;

#nullable disable

namespace Uppgift1_ASP.Net.Entities
{
    public partial class SchoolClassStudent
    {

        public Guid SchoolClassId { get; set; }

        public string StudentId { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }

    }
}

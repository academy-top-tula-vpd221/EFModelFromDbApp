using System;
using System.Collections.Generic;

namespace EFModelFromDbApp
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace EFModelFromDbApp
{
    public partial class Company
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace CS_EFCore.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}

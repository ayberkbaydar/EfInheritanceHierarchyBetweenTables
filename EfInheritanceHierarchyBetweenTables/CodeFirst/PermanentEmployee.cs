using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst
{
    public class PermanentEmployee : Employee
    {
        [Column(Order = 5)]
        public int AnnualSalary { get; set; }
    }
}
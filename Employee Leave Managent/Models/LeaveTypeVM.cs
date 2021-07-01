using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Leave_Managent.Models
{
    public class DetailsLeaveTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name ="Date Created")]
        public DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Models.ViewModels
{
    public class DetailsLeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }

        public DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
    }
}

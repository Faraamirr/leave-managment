using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Data
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }

        public DateTime DateCreated { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Forum.Models
{
    public class Role
    {
        public Guid Id { get; set; }

        [Display(Name = "Role")]
        public string RoleString { get; set; }

    }
}

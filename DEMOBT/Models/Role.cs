using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DEMOBT.Models
{
    public partial class Role
    {
        [Key]
        [StringLength(10)]
        public string RoleID { get; set; }

        [StringLength(10)]
        public string RoleName { get; set; }

    }
}
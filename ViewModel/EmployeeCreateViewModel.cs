using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModel
{
    public class EmployeeCreateViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "Office Email")]
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }

        public List<IFormFile> Photos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWithApi.Share
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3, ErrorMessage = "Name must be greater than 3 char")]
        public string Name { get; set; }
        [Required]
        [Range(20000, 3000000)]
        public int Salary { get; set; }
        [Required]
        [RegularExpression(@"^\w+\.(png|jpg)$", ErrorMessage = "Extention Must be .Png or .Jpg")]
        public string Img { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department? Department { get; set; }

        public override string ToString()
        {
            return $"Name:{Name} \t Salary:{Salary}";
        }
    }
}

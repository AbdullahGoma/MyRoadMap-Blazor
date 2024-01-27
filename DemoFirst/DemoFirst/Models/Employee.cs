﻿using System.ComponentModel.DataAnnotations;

namespace DemoFirst.Models
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

        public override string ToString()
        {
            return $"Name:{Name} \t Salary:{Salary}";
        }
    }
}

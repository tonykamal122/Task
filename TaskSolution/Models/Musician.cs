using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSolution.Models
{
    public class Musician
    {
        public int MusId { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string? FullName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [MaxLength(20, ErrorMessage = "Max length is 20 char")]
        [MinLength(5, ErrorMessage = "Max length is 5 char")]
        public string City { get; set; }
        [MaxLength(20, ErrorMessage = "Max length is 20 char")]
        [MinLength(5, ErrorMessage = "Max length is 5 char")]
        public string County { get; set; }

    }
}
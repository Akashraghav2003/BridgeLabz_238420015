using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Entity
{
    public class EmployeeEntity
    {
        [Key]
        public int employeeId { get; set; }

        [Required]
        public string? fristName { get; set; }

        [Required]
        public string? lastName { get; set; }

        [Required]
        public int phoneNumber {  get; set; }

        [Required]
        public string? eMail {  get; set; }
    }
}

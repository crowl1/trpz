using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class ManagerE
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public long ExecutionTime { get; set; }
        [Required]
        public long ReleaseTime { get; set; }
    }
}

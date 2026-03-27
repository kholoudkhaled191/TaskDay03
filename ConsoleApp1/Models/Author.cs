using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Models
    
{
    [Table("Writers")]
    internal class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]

        public string Name { get; set; }
        public string? Country { get; set; }

    }
}

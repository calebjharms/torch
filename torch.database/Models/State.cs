using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace torch.database.Models
{
    public class State
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(2)]
        public string code { get; set; }

        [Required]
        [StringLength(64)]
        public string name { get; set; }

        public virtual ICollection<Organization> Organizations { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace torch.database.Models
{
    /// <summary>
    /// General Organization Data
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }


        /// <summary>
        /// Clustered Index
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int clusterId { get; set; }

        [Required]
        public bool active { get; set; }

        [Required]
        [StringLength(64)]
        public string name { get; set; }


    }

}

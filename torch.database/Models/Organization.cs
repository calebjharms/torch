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

        [StringLength(256)]
        public string email { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(256)]
        public string address { get; set; }

        [StringLength(256)]
        public string address2 { get; set; }

        [StringLength(100)]
        public string city { get; set; }


        [ForeignKey("state")]
        public int stateId { get; set; }

        public virtual State state { get; set; }

        [StringLength(5)]
        public string zip { get; set; }

    }

}

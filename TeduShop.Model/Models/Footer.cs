using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        //AutoIncrement
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String ID { get; set; }
        
        [Required]
        public String Content { get; set; }
    }
}
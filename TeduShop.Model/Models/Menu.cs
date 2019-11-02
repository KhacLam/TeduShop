using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key] 
        //AutoIncrement
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String ID { set; get; }
        
        [Required]
        public String Name { set; get; }
        
        [Required]
        public string Url{ set; get; }
        public int? DislpayOreder{ set; get; }
        
        [Required]
        public int GroupID{ set; get; } 
    
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }
        
        public String Target { set; get; }        
        [Required]
        public bool Status{ set; get; }
    }
}
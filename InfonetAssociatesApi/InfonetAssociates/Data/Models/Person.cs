using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfonetAssociates.Data.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime DoB { get; set; }        
        public bool CSharpSkill { get; set; } 
        public bool CPlusPlusSkill { get; set; } 
        public bool JavaSkill { get; set; } 
        public bool PhpSkill { get; set; } 
        public bool SqlSkill { get; set; } 
        //public string? Resume { get; set; } 
        
    }
}

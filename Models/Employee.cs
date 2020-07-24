using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace trash.Models
{
    public class Employee
    {
             
        [Key]

        public int EmployeeId { get; set; }
        public int ZipCode { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
                
      
        
    }
    
      
    
}

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
    public class Customer
    {


        [Key]
       public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string WeeklyPickUpDay { get; set; }
        public DateTime StartSuspendDate { get; set; } 
        public DateTime StopSuspendDate { get; set; } 
        public DateTime OneTimePickUp { get; set; }
        public int GetBalance { get; set; } 
       
        //what other properties do I need here?
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
    }


}

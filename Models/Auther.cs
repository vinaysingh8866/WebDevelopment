using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPNetCoreWebsite.Models
{
    public class Auther
    {


        [Key]
        [HiddenInput]
        public int ID { get; set; }


        [Display(Name = "First Name")]
        [Required]
        public string Name { get; set; }


        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }


        [Display(Name = "Email")]
        [EmailAddress]
        [Required(ErrorMessage = "Please provide an Email address.")]
        public string Email { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }


        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name = "Website Address")]
        public string WebsiteAddress { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }


        [Display(Name = "Province")]
        public string Province { get; set; }


        [Display(Name = "Postal Code")]
        public int PostalCode { get; set; }





        public ICollection<Order> Orders { get; set; }


    }
}

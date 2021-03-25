using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace FirstASPNetCoreWebsite.Models
{
    public class Blog
    {

        [Display(Name = "Title")]
        public string Title { get; set; }


        [Display(Name = "Content")]
        public string Content { get; set; }


        [Display(Name = "Auther")]
        public string Auther { get; set; }


        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }


        public Blog()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstASPNetCoreWebsite.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstASPNetCoreWebsite.Pages.admin.auther
{
    public class CreateBlogModel : PageModel
    {


        [FromForm]
        public Auther Auther { get; set; } = new Auther();

        private List<Auther> Authers { get; set; } = new List<Auther>();
        public IEnumerable<SelectListItem> AutherList { get; private set; }
        public CreateBlogModel()
        {
            Auther a = new Auther()
            {
                Name = "Vinay",
                LastName = "Singh",
                Email = "vinaysingh8866@gmail.com"

            };
            Auther b = new Auther()
            {
                Name = "Vinay",
                LastName = "Singh",
                Email = "vinaysingh8866@gmail.com"

            };

            Auther c = new Auther()
            {
                Name = "Vinay",
                LastName = "Singh",
                Email = "vinaysingh8866@gmail.com"

            };


            Authers.Add(a);
            Authers.Add(b);
            Authers.Add(c);


        }



        public void OnGet()
        {
            AutherList = Authers.Select(cust =>
            {
                return new SelectListItem(String.Format("{0} ({1})", cust.Name, cust.Email), cust.Email);
            });

            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var cust in Authers)
            {
                list.Add(new SelectListItem(cust.Name, cust.Email));
            }
            AutherList = list;
        }
    }
}

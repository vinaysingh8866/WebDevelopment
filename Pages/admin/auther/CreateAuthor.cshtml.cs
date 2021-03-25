using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstASPNetCoreWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstASPNetCoreWebsite.Pages.admin.auther
{
    public class CreateAuthorModel : PageModel
    {
        public void OnGet()
        {

        }




        [FromForm]
        public Auther Auther { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OdczytCzasu.Pages
{
    public class Czas2Model : PageModel
    {
        public void OnGet()
        {
            var dateData = DateTime.UtcNow.ToString();
            ViewData["dateData"] = dateData;
        }
    }
}
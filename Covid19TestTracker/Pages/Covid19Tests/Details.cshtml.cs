using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19TestTracker.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Covid19TestTracker.Pages.Covid19Tests
{
    public class DetailsModel : PageModel
    {
        public Covid19Test Covid19Test { get; set; }
        public void OnGet()
        {
            Covid19Test = new Covid19Test() { Patient = new Patient()};

        }
    }
}

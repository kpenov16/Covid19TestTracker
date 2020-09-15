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
        private readonly ICovid19TestData covid19TestData;

        public Covid19Test Covid19Test { get; set; }

        public DetailsModel(ICovid19TestData covid19TestData)
        {
            this.covid19TestData = covid19TestData;
        }

        public IActionResult OnGet(string covid19TestId)
        {
            Covid19Test = covid19TestData.getById(covid19TestId);
            if(Covid19Test == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}

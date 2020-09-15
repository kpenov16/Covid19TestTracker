using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19TestTracker.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Covid19TestTracker.Pages.Covid19Tests
{
    public class EditModel : PageModel
    {
        private readonly ICovid19TestData covid19TestData;
        private readonly IHtmlHelper htmlHelper;

        public Covid19Test Covid19Test { get; set; }
        public IEnumerable<SelectListItem> Results { get; set; }
        public EditModel(ICovid19TestData covid19TestData, IHtmlHelper htmlHelper)
        {
            this.covid19TestData = covid19TestData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(string covid19TestId)
        {
            Results = htmlHelper.GetEnumSelectList<TestResult>();

            Covid19Test = covid19TestData.getById(covid19TestId);
            if(Covid19Test == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}

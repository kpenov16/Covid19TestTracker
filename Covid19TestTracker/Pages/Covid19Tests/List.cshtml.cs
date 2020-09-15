using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19TestTracker.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Covid19TestTracker.Pages.Covid19Tests
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly ICovid19TestData covid19TestData;

        public string Msg { get; set; }
        public IEnumerable<Covid19Test> Covid19Tests { get; set; }
        public ListModel(IConfiguration config, 
                         ICovid19TestData covid19TestData)
        {
            this.config = config;
            this.covid19TestData = covid19TestData;
        }

        public void OnGet()
        {
            Msg = config["Msg"];
            Covid19Tests = covid19TestData.GetAll();
        }
    }
}

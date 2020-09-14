using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Covid19TestTracker.Pages.Covid19Tests
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        public string Msg { get; set; }

        public ListModel(IConfiguration config)
        {
            this.config = config;
        }

        public void OnGet()
        {
            Msg = config["Msg"];
        }
    }
}

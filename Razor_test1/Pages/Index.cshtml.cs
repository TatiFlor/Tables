using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Razor_test1.Models;
using Razor_test1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_test1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileRowService RowService; //private
        public IEnumerable<Row> Rows { get; private set; }


        public IndexModel(ILogger<IndexModel> logger,
            JsonFileRowService rowService)
        {
            RowService = rowService;
            _logger = logger;
        }

        public void OnGet()
        {
            Rows = RowService.GetRows();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using EDDataAccessLibrary.DataAccess;
using EDDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EfDemoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _db;

        public int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        public IndexModel(ILogger<IndexModel> logger, PeopleContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            //LoadSampleData();
        }

        //private void LoadSampleData()
        //{
        //    if (_db.People.Count() == 0)
        //    {
        //        string file = System.IO.File.ReadAllText("generated.json");
        //        var people = JsonSerializer.Deserialize<List<Person>>(file);
        //        _db.AddRange(people);
        //        _db.SaveChanges();
        //    }
        //}
    }
}

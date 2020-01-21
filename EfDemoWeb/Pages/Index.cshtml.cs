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

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PeopleContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            //LoadSampleData();
            ViewData["MyNumber"] = 42;
            ViewData["MyString"] = "Hello World";
            string file = System.IO.File.ReadAllText("generated.json");
            var people = JsonSerializer.Deserialize<dynamic>(file);
            //var people2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(file);
            ViewData["MyList"] = people;
           // ViewData["MyList2"] = people2;
        }

        private void LoadSampleData()
        {
            //if (_db.People.Count() == 0)
            //{
            //    string file = System.IO.File.ReadAllText("generated.json");
            //    var people = JsonSerializer.Deserialize<List<Person>>(file);
            //    _db.AddRange(people);
            //    _db.SaveChanges();
            //}
            //string file = System.IO.File.ReadAllText("generated.json");
            // var people = JsonSerializer.Deserialize<List<Person>>(file);

        }
    }
}

using BDGWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class ReportController : Controller
{
    public IActionResult Index()
    {
        string jsonFile = Path.Combine(Directory.GetCurrentDirectory(), "BDG_Output.json");
        var users = new List<User>();

        if (System.IO.File.Exists(jsonFile))
        {
            var jsonData = System.IO.File.ReadAllText(jsonFile);
            users = JsonConvert.DeserializeObject<List<User>>(jsonData);
        }

        return View(users);
    }
}

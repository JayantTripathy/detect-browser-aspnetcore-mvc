using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
namespace detect_browser_aspnetcore_mvc.Models
{
    public class Browser
    {
        public string userAgent { get; set; }
        public Regex OS { get; set; }
        public Regex device { get; set; }
    }
}
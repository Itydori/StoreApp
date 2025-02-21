using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoreApp.Pages
{
    public class DemoModel : PageModel
    {
        public String? FullName => HttpContext?.Session?.GetString("name") ?? "Noname";
        public void OnGet()
        {
        }
        public void OnPost([FromForm]string name)
        {
           // Name = name;
           HttpContext.Session.SetString("name", name);
           HttpContext.Session.SetInt32("age", 20);
        }
    }
}

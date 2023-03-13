using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMessageWall.Pages
{
    public class MessageWallModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public List<string> FullNames { get; set; } = new List<string>();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string fullName = $"{FirstName} {LastName}";
            FullNames.Add(fullName);
            return Page();
        }
    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CountdownApp.Pages
{
    public class CounterModel : PageModel
    {
        public const int CountdownMinutes = 1;
        public const int CountdownSeconds = CountdownMinutes * 60;
        public const int WarningThreshold = 10;

        public void OnGet()
        {
            ViewData["WarningThreshold"] = WarningThreshold;
        }
    }
}

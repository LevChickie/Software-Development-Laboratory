using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Otthonbazar.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Otthonbazar.Pages.Advertisements
{
    public class CreateModel : PageModel
    {
        private readonly Otthonbazar.Data.ApplicationDbContext _context;

        [BindProperty]
        public Advertisement Advertisement { get; set; }

        public CreateModel(Otthonbazar.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name");
            return Page();
        }

        [Authorize]
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var city = _context.Cities.FirstOrDefault(c => c.Zip == Advertisement.City.Zip);
            Advertisement.City = city;
            _context.Advertisements.Add(Advertisement);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public ActionResult OnGetZip(int zip) => new JsonResult(_context.Cities.FirstOrDefault(c => c.Zip == zip.ToString()));
    }
}
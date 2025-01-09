using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]

    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(int? CategoryId)
        {
            if (CategoryId != null && CategoryId != 0)
            {
                Category = _context.Category.Find(CategoryId);
            }
        }

        public IActionResult OnPost()
        {
            Category? obj = _context.Category.Find(Category.CategoryId);
            if(obj == null)
            {
                return NotFound();
            }
            _context.Category.Remove(obj);
            _context.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}

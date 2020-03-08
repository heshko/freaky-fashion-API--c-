using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreakyFashion2.Areas.Admin.Pages.Categories
{
    public class NewModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        public NewModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public NewCategory _NewCategory { get; set; }

        public int MyProperty { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var NewCategory = new Category
            {
                ImgUrl = _NewCategory.ImgUrl,
                Name = _NewCategory.Name,
                UrlSlug = _NewCategory.Name.Replace(" ", "-")

            };
            _context.Categories.Add(NewCategory);
            _context.SaveChanges();

            return RedirectToPage("/Admin/Categories");
        }
    }
    public class NewCategory
    {
        [Required(ErrorMessage ="You should write"),Display(Name ="Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You should write"), Display(Name = "ImgUrl")]
        public string ImgUrl { get; set; }
    }
}

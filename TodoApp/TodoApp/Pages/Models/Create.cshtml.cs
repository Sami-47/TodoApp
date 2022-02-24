#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TodoApp.Data;

namespace TodoApp.Model
{
    public class CreateModel : PageModel
    {
        private readonly TodoApp.Data.TodoAppContext _context;

        public CreateModel(TodoApp.Data.TodoAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tasks Tasks { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //var userName = User.FindFirstValue(ClaimTypes.Email);
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Tasks.UserName = userName;
            _context.Tasks.Add(Tasks);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

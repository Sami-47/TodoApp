#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;

namespace TodoApp.Model
{
    public class DetailsModel : PageModel
    {
        private readonly TodoApp.Data.TodoAppContext _context;

        public DetailsModel(TodoApp.Data.TodoAppContext context)
        {
            _context = context;
        }

        public Tasks Tasks { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tasks = await _context.Tasks.FirstOrDefaultAsync(m => m.UserId == id);

            if (Tasks == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

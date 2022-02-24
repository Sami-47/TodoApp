#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;


namespace TodoApp.Model
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly TodoApp.Data.TodoAppContext _context;
        private readonly UserManager<IdentityUser> _signInManager;


        public IndexModel(TodoApp.Data.TodoAppContext context, UserManager<IdentityUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        public IList<Tasks> Tasks { get;set; }

        public async Task OnGetAsync()
        {

            var userName = _signInManager.GetUserName(User);
            Tasks = await _context.Tasks.Where(t=>t.UserName== userName ).ToListAsync();
        }
    }
}

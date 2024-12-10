using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Todoer.Models;

namespace Todoer.Pages_Todos
{
    public class IndexModel : PageModel
    {
        private readonly TodoAppDbContext _context;

        public IndexModel(TodoAppDbContext context)
        {
            _context = context;
        }

        public IList<Todo> Todo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Todo = await _context.Todo.ToListAsync();
        }
    }
}

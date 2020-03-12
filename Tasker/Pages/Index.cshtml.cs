﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class IndexModel : PageModel
    {
        ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Task> Tasks { get; set; }

        public void OnGet()
        {
            Tasks = _context.Tasks.OrderBy(x => x.Priority);
        }
    }
}
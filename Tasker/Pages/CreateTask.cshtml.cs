﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateTaskModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }

        [BindProperty]
        public Task NewTask { get; set; }

        public IActionResult OnPost()
        {
            var taskToAdd = new Task
            {
                Id = NewTask.Id,
                Title = NewTask.Title,
                Description = NewTask.Description,
                Priority = NewTask.Priority
            };

            _context.Tasks.Add(taskToAdd);

            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
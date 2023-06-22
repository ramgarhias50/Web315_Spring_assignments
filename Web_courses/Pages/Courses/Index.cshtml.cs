using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_courses;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Web_courses.Pages_Courses
{
    public class IndexModel : PageModel
    {
        private readonly coursesContext _context;

        public IndexModel(coursesContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string coursescategory { get; set; }
        public SelectList coursesCategory { set; get; }



        public async Task OnGetAsync()
        {
            IQueryable<string> courseQuery = from m in _context.Course orderby m.coursesCategory select m.coursesCategory;


            var course = from m in _context.Courses
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                course = course.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(coursescategory))
            {
                course = course.Where(x => x.coursesCategory == coursescategory);
            }
            coursesCategory = new SelectList(await courseQuery.Distinct().ToListAsync());
            Course = await course.ToListAsync();


        }
    }
}

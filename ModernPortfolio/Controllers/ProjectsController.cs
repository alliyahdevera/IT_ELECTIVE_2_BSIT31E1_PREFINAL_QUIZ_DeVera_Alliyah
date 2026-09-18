using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModernPortfolio.Models;

namespace ModernPortfolio.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View(ProjectStore.Projects);
        }

        public IActionResult Details(int id)
        {
            var project = ProjectStore.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return NotFound();

            ViewBag.Comments = ProjectStore.Comments
                .Where(c => c.ProjectId == id)
                .OrderByDescending(c => c.CreatedAt)
                .ToList();

            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddComment(int projectId, string author, string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                ProjectStore.Comments.Add(new Comment
                {
                    Id = ProjectStore.Comments.Count + 1,
                    ProjectId = projectId,
                    Author = string.IsNullOrWhiteSpace(author) ? "Anonymous" : author,
                    Text = text
                });
            }
            return RedirectToAction("Details", new { id = projectId });
        }
    }
}
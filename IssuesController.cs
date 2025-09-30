using Microsoft.AspNetCore.Mvc;
using MuniServices.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MuniServices.Controllers
{
    public class IssuesController : Controller
    {
        private static List<Issue> issues = new();

        public IActionResult Report() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(Issue issue, IFormFile media)
        {
            if (!ModelState.IsValid)
            {
                return View("Report", issue);
            }

            if (media != null && media.Length > 0)
            {
                var fileName = Path.GetFileName(media.FileName);
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                Directory.CreateDirectory(uploadsFolder);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using var stream = new FileStream(filePath, FileMode.Create);
                await media.CopyToAsync(stream);

                issue.MediaPath = "/uploads/" + fileName;
            }

            issue.ID = issues.Count + 1;
            issue.Status = "Received";
            issues.Add(issue);

            TempData["Message"] = "Issue submitted successfully!";
            return RedirectToAction("Status");
        }

        public IActionResult Status() => View(issues);

        [HttpGet]
        public IActionResult Feedback(int id)
        {
            var issue = issues.FirstOrDefault(i => i.ID == id);
            if (issue == null) return NotFound();
            return View(issue);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Feedback(int id, int rating, string feedback)
        {
            var issue = issues.FirstOrDefault(i => i.ID == id);
            if (issue == null) return NotFound();

            issue.Rating = rating;
            issue.Feedback = feedback;
            issue.Status = "Resolved";

            TempData["Message"] = "Feedback submitted successfully!";
            return RedirectToAction("Status");
        }
    }
}
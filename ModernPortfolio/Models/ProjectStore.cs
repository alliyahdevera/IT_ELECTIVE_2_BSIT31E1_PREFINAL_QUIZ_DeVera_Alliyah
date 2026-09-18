namespace ModernPortfolio.Models
{
    public class ProjectStore
    {
        public static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "MVC Authentication System",
                Description = "A hardcoded-login MVC app with cookie authentication, password reset, and account lockout after failed attempts.",
                GithubUrl = "https://github.com/yourusername/IT_ELECTIVE_2_MIDTERM_Q3_DEVERA_ALLIYAH",
                ThumbnailUrl = "/images/project1.png"
            },
            new Project
            {
                Id = 2,
                Title = "Help Desk Ticketing System",
                Description = "An MVC + EF Core app for managing support tickets, customers, employees, and ticket comments.",
                GithubUrl = "https://github.com/yourusername/IT_ELECTIVE_PREFINALS_PROJECT",
                ThumbnailUrl = "/images/project2.png"
            },
        };

        public static List<Comment> Comments = new List<Comment>();
    }
}

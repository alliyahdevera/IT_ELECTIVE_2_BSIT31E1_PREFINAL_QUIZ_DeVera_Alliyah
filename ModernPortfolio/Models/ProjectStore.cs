namespace ModernPortfolio.Models
{
    public class ProjectStore
    {
        public static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "Registrar Document Request System",
                BriefDescription = "A VB.NET and MySQL system for managing student document requests, payments, and release status.",
                Description = "An ongoing project for Integrative Programming in VB.NET and MySQL-based system designed to help a registrar's office manage students, document types, requests, payments, and release status. It provides an organized way to monitor pending and completed document requests such as Transcript of Records, Certificate of Enrollment, Certificate of Good Moral, and other school documents.",
                GithubUrl = "https://github.com/alliyahdevera/Registrar_Document_Request_System",
                ThumbnailUrl = "/photos/registrar.png"
            },

            new Project
            {
                Id = 2,
                Title = "MVC Authentication System",
                BriefDescription = "An ASP.NET Core MVC project with hardcoded login, cookie authentication, password reset, and account lockout.",
                Description = "A hardcoded-login MVC app with cookie authentication, password reset, and account lockout after failed attempts.",
                GithubUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_Q3_DEVERA_ALLIYAH",
                ThumbnailUrl = "/photos/auth.png"
            },

            new Project
            {
                Id = 3,
                Title = "Help Desk Ticketing System",
                BriefDescription = "A MVC + EF Core system for managing support tickets, customers, employees, and ticket comments.",
                Description = "A collaborative prefinal project in IT Elective 2 built with ASP.NET Core MVC and EF Core for managing support tickets, customers, employees, and ticket comments.",
                GithubUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_PREFINALS_PROJECT",
                ThumbnailUrl = "/photos/helpdesk.png"
            },

            new Project
            {
                Id = 4,
                Title = "IT Elective 2 PreFinal Examination Website",
                BriefDescription = "An ASP.NET Core MVC website that organizes PreFinal exam topics, questions, and answers.",
                Description = "A simple ASP.NET Core MVC website created for the IT Elective 2 PreFinal Examination. It organizes different exam topics and displays questions from the PreFinal Examination document together with their corresponding answers.",
                GithubUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_DeVera_Alliyah",
                ThumbnailUrl = "/photos/prefiexam.png"
            },

            new Project
            {
                Id = 5,
                Title = "Package Pickup Monitoring System",
                BriefDescription = "An ASP.NET Core MVC application designed to monitor incoming packages and package pickups.",
                Description = "The Package Pickup Monitoring System is an ASP.NET Core MVC application used to record, monitor, and manage incoming packages and their pickup status. It includes CRUD operations, search, validation, cookie authentication, Razor Views, Bootstrap, and an in-memory repository for handling data.",
                GithubUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_EXAM_6_DEVERA_ALLIYAH",
                ThumbnailUrl = "/photos/pickup.png"
            },

            new Project
            {
                Id = 6,
                Title = "Dream Bake POS",
                BriefDescription = "A bakery-themed Point of Sale web application built with ASP.NET Core MVC for processing bakery sales.",
                Description = "Dream Bake POS is an ASP.NET Core MVC Point of Sale application designed for a bakery. It allows cashiers to browse bakery products, add items to a cart, enter customer information, calculate orders, and complete transactions. The project uses in-memory repositories and a bakery-inspired brown and cream interface.",
                GithubUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_DEVERA_ALLIYAH",
                ThumbnailUrl = "/photos/pos.png"
            },

            new Project
            {
                Id = 7,
                Title = "MusicSpace",
                BriefDescription = "A music playlist web app where users build their own playlists from YouTube songs and play them directly in-browser.",
                Description = "MusicSpace is an ASP.NET Core MVC web application that lets users log in, build a personal playlist by adding YouTube songs, and play them using an embedded YouTube player. It also tracks a Top 5 Trending Songs list based on total play counts across all users. Users can remove individual songs, clear their whole playlist, and view their profile — all through a responsive, Bootstrap-styled interface.",
                GithubUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_Q1",
                ThumbnailUrl = "/photos/music.png"
            },
            new Project
            {
                Id = 8,
                Title = "Playlistify",
                BriefDescription = "A session-based playlist manager where users log in and build shareable YouTube playlists with per-track notes.",
                Description = "Playlistify is an ASP.NET Core MVC application that lets logged-in users create playlists made up of YouTube video links, each with an optional note. Playlists support dynamically adding or removing video rows (handled server-side, no JavaScript required) before saving. All saved playlists are listed on the dashboard along with their creator and track list, with each video link opening directly on YouTube.",
                GithubUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_MIDTERM_Q2_DEVERA_ALLIYAH",
                ThumbnailUrl = "/photos/Playlistify.png"
            },
            new Project
            {
                Id = 9,
                Title = "Student Information System",
                BriefDescription = "An ASP.NET Core MVC app using full Identity authentication with EF Core Code-First models for students, courses, and subjects.",
                Description = "This project sets up ASP.NET Core Identity for real user registration, login, and account management (as opposed to a hardcoded login), backed by Entity Framework Core with Code-First migrations. The data models cover a student information system — Students (with course and year level), Courses, and Subjects — laying the groundwork for a full academic records system.",
                GithubUrl = "https://github.com/alliyahdevera/IT_ELECTIVE_2_PREFINAL_ACTIVITY_1",
                ThumbnailUrl = "/photos/studentinfosystem.png"
            }
        };

        public static List<Comment> Comments = new List<Comment>();
    }
}

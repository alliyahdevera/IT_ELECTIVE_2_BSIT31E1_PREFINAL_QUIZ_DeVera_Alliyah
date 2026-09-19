# PREFINAL QUIZ - IT ELECTIVE 2 | DE VERA, ALLIYAH ALCEL G.
## Modern Portfolio — MVC Application

A modern portfolio built with ASP.NET Core MVC, showcasing my projects with a
table of contents, detail pages, a comment section, and a hardcoded login system.

## Login Credentials (Hardcoded)

> These are hardcoded in `Models/UserStore.cs` for demo purposes only.

| Field    | Value              |
|----------|--------------------|
| Email    | ally@gmail.com    |
| Password | Password123!       |

## Features

- **Hardcoded Login** — Cookie-based authentication (`[Authorize]`) protects
  every page except Login itself. Session expires after 30 minutes.
- **Table of Contents** — `Projects/Index` lists all projects as glass-styled
  cards with a thumbnail, title, and short description.
- **Project Detail Pages** — `Projects/Details/{id}` shows the full
  description, GitHub link, and comment section for each individual project.
- **Comment Section** — Visitors can post a name + comment on any project
  detail page; comments are stored in memory and shown newest-first.
- **Protected Routes with Return-URL** — Visiting a protected page while
  logged out redirects to Login, then sends you back to the exact page you
  were trying to reach after signing in.
- **CSRF Protection** — Comment and login forms are protected with
  `[ValidateAntiForgeryToken]`.

## Technologies Used

- ASP.NET Core MVC (.NET 10)
- Razor Views
- Cookie Authentication (`Microsoft.AspNetCore.Authentication.Cookies`)
- Bootstrap 5
- In-memory data store

## How to Run

1. Clone the repository.
2. Open `ModernPortfolio.sln` in Visual Studio (or run from the project folder).
3. Run the project: Press F5 or click the green play button.
4. Log in using the credentials above.

<div align="center">

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![EF Core](https://img.shields.io/badge/EF%20Core-8.0-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![Auth](https://img.shields.io/badge/Auth-ASP.NET%20Identity-E44D26?style=flat-square&logo=dotnet&logoColor=white)
![UI](https://img.shields.io/badge/UI-Bootstrap%205-7952B3?style=flat-square&logo=bootstrap&logoColor=white)
![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=csharp&logoColor=white)
![Database](https://img.shields.io/badge/Database-SQL%20Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)

![Pattern](https://img.shields.io/badge/Pattern-MVC-0078D4?style=flat-square)
![ORM](https://img.shields.io/badge/ORM-Entity%20Framework-512BD4?style=flat-square)
![IDE](https://img.shields.io/badge/IDE-Visual%20Studio%202022-5C2D91?style=flat-square&logo=visualstudio&logoColor=white)
![Status](https://img.shields.io/badge/Status-In%20Development-F59E0B?style=flat-square)

# 🎓 University Management System

*A full-featured academic platform for managing students, courses, faculty, and enrollments.*
*Built with ASP.NET Core MVC — clean, scalable, and role-based.*

</div>

---

## 📋 Table of Contents

- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Getting Started](#-getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Configuration](#configuration)
- [Project Structure](#-project-structure)
- [Screenshots](#-screenshots)
- [Contributing](#-contributing)
- [License](#-license)
- [Contact](#-contact)

---

## ✨ Features

- 👩‍🎓 **Student Management** — Register, view, update, and delete student records
- 📚 **Course Management** — Create and manage courses, assign instructors
- 👨‍🏫 **Faculty Administration** — Manage faculty profiles and department assignments
- 📝 **Enrollment System** — Enroll students in courses and track academic progress
- 🔐 **Authentication & Authorization** — Secure login with role-based access control
- 📊 **Dashboard** — Overview of system statistics and quick actions
- 📱 **Responsive Design** — Mobile-friendly UI powered by Bootstrap 5
- 🎨 **Design System** — Deep Navy + Warm Gold color palette with full 9-shade CSS custom property scales
- 🔤 **Design System** — Playfair Display + Inter professional font pairing via Google Fonts
- 🧩 **Design System** — Pre-built components: Sidebar, Topbar, Cards, Buttons, Forms, Tables, Badges, Alerts, Modals
- ✨ **Design System** — Keyframe animations: fadeInUp, slideInSidebar, pulseBadge, shimmer skeleton loading
- 📱 **Design System** — Fully responsive with prefers-reduced-motion support
- 🔗 **Design System** — Bootstrap 5 seamlessly extended via CSS custom properties (--bs-* overrides)

---

## 🛠 Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (.NET 8) |
| Language | C# |
| Frontend | Razor Views, Bootstrap 5, jQuery |
| Database | SQL Server |
| ORM | Entity Framework Core 8 |
| Authentication | ASP.NET Core Identity |
| IDE | Visual Studio 2022 |
| Design System | Custom CSS (CSS Variables + Bootstrap 5 Extensions) |

---

## 🚀 Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or VS Code)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express)
- [Git](https://git-scm.com/)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/EsraaShiref/University_Management_System.git
   cd University_Management_System
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Apply database migrations**
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. Open your browser and navigate to `https://localhost:5001`

### Configuration

1. Create `appsettings.Development.json` in the project root
2. Update the connection string with your SQL Server details:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=UniversityDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

> ⚠️ **Note:** `appsettings.Development.json` is excluded from version control. Never commit sensitive credentials to GitHub.

---

## 📁 Project Structure

```
University-Management-System/
│
├── Controllers/          # MVC Controllers (request handling & routing)
├── Models/               # Data models and ViewModels
├── Views/                # Razor view templates (.cshtml)
│   ├── Home/
│   ├── Shared/           # Layout, partial views
│   └── _ViewImports.cshtml
│
├── Properties/           # Launch settings
├── wwwroot/              # Static files (CSS, JS, images)
│   ├── css/
│   │   └── site.css        # Full design system (tokens, components, animations)
│   └── js/
│
├── appsettings.json               # App configuration
├── appsettings.Development.json   # Local dev config (not tracked)
├── Program.cs                     # App entry point & middleware
└── University-Management-System.csproj
```

---

## 📸 Screenshots

> _Screenshots will be added as the project progresses._

---

## 🤝 Contributing

Contributions are welcome! To contribute:

1. Fork the repository
2. Create a new branch
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Commit your changes
   ```bash
   git commit -m "Add: your feature description"
   ```
4. Push to your branch
   ```bash
   git push origin feature/your-feature-name
   ```
5. Open a **Pull Request**

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 📬 Contact

<div align="center">

**Esraa Shiref**

[![GitHub](https://img.shields.io/badge/GitHub-EsraaShiref-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/EsraaShiref)

---

*Built with ❤️ using ASP.NET Core MVC*

</div>
# 🎓 University Management System

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white)

A full-featured **University Management System** built with ASP.NET Core MVC, designed to streamline and manage core university operations such as student enrollment, course management, faculty administration, and more.

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

---

## 🛠 Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (.NET 8) |
| Language | C# |
| Frontend | Razor Views, Bootstrap 5, jQuery |
| Database | SQL Server / Entity Framework Core |
| ORM | Entity Framework Core |
| Authentication | ASP.NET Core Identity |
| IDE | Visual Studio 2022 |

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

1. Copy `appsettings.Development.json.example` to `appsettings.Development.json` (or create it manually)
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

**Esraa Shiref**

[![GitHub](https://img.shields.io/badge/GitHub-EsraaShiref-181717?style=flat&logo=github)](https://github.com/EsraaShiref)

---

> Built with ❤️ using ASP.NET Core MVC

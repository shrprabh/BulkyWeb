# BulkyWeb

![License](https://img.shields.io/github/license/shrprabh/BulkyWeb)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue)
![C#](https://img.shields.io/badge/C%23-10.0-purple)

## Overview

BulkyWeb is a comprehensive e-commerce application built using ASP.NET Core MVC with C#. The project demonstrates clean architecture principles, robust data management, and modern web development practices.

## 🚀 Features

- **Product Management**: Full CRUD operations for managing products with categories
- **User Authentication**: Identity-based authentication with role management
- **Shopping Cart**: Intuitive shopping experience with session management
- **Order Processing**: Complete order workflow from cart to confirmation
- **Admin Dashboard**: Detailed analytics and management interfaces
- **Responsive Design**: Mobile-first approach using Bootstrap 5

## 🛠️ Technologies

- **Backend**: ASP.NET Core MVC (.NET 8)
- **Database**: Entity Framework Core with SQL Server
- **Authentication**: ASP.NET Core Identity
- **Frontend**: HTML5, CSS3, JavaScript, Bootstrap 5
- **Payment Processing**: Integration with Stripe API
- **Dependency Injection**: Built-in ASP.NET Core DI container
- **Design Patterns**: Repository pattern, Unit of Work

## 📋 Prerequisites

- .NET 8.0 SDK
- SQL Server (LocalDB or higher)
- Visual Studio 2022 or VS Code

## 🔧 Setup and Installation

1. Clone the repository
```bash
git clone https://github.com/shrprabh/BulkyWeb.git
cd BulkyWeb
```

2. Update database connection string in `appsettings.json`

3. Apply database migrations
```bash
dotnet ef database update
```

4. Run the application
```bash
dotnet run
```

5. Navigate to `https://localhost:5001` in your browser

## 📊 Project Structure

```
BulkyWeb/
├── Bulky.DataAccess/     # Data access layer with EF Core
├── Bulky.Models/         # Domain models and view models
├── Bulky.Utility/        # Helper classes and constants
└── BulkyWeb/             # Main MVC application
    ├── Areas/
    │   ├── Admin/        # Admin area controllers and views
    │   ├── Customer/     # Customer area controllers and views
    │   └── Identity/     # Identity management
    ├── Controllers/      # API controllers
    ├── Views/            # Razor views
    └── wwwroot/          # Static files (CSS, JS, images)
```


## 🧪 Testing

```bash
dotnet test
```

## 🤝 Contributing

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📧 Contact

Your Name - [LinkedIn Profile](https://linkedin.com/in/yourprofile)

Project Link: [https://github.com/shrprabh/BulkyWeb](https://github.com/shrprabh/BulkyWeb)
```

Note: This project was developed as a demonstration of C# and ASP.NET Core skills for employment purposes.

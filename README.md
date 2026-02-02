# RazorPageDemoApp

A demo **ASP.NET Core Razor Pages** application showcasing **Product Management** with **Authentication, Authorization, and Role-based Access Control** using **ASP.NET Core Identity** and **SQL Server**.

This project is designed as a **learning + interview-ready demo**, built without EF migrations and using **manual SQL scripts** for database setup.

---

## ✨ Features

### 🔐 Authentication & Authorization

* User Registration
* Login / Logout (secure POST-based logout)
* ReturnUrl-based redirection after login
* Role-based authorization

### 👥 Roles

* **ADMIN** – Full access (user management, product CRUD)
* **MAINTAINER** – Product create & update
* **READONLY** – View-only access

Supports **multiple roles per user**.

---

### 📦 Product Management

* Product List
* Create Product
* Edit Product
* Delete Product
* Clean UI using **Bootstrap + custom CSS**

---

### 🛠 Admin User Management

(Admin-only area)

* List all users
* Create new users
* Assign one or more roles
* Update user roles

---

## 🧱 Tech Stack

* **ASP.NET Core Razor Pages (.NET 7/8)**
* **ASP.NET Core Identity** (custom table names)
* **Entity Framework Core** (no migrations)
* **SQL Server / SQL Express**
* **Bootstrap 5**
* **C#**

---

## 📁 Project Structure

```
RazorPageDemoApp
│
├── Pages
│   ├── Account
│   │   ├── Login
│   │   ├── Register
│   │   └── Logout
│   │
│   ├── Admin
│   │   ├── Users
│   │   ├── CreateUser
│   │   └── EditUser
│   │
│   ├── Products
│   │   ├── Index
│   │   ├── Create
│   │   ├── Edit
│   │   └── Delete
│   │
│   └── Shared
│       └── _Layout.cshtml
│
├── Data
│   ├── ApplicationDbContext.cs
│   └── ProductRepository.cs
│
├── wwwroot
│   └── css
│       └── site.css
│
└── Program.cs
```

---

## 🗄 Database Setup (Manual SQL)

> ⚠️ This project does **NOT** use EF migrations.


## 🔧 Configuration

### Connection String (`appsettings.json`)

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=DESKTOP-XXXX\\SQLEXPRESS;Database=RazorPagesDemo;Trusted_Connection=True;TrustServerCertificate=True"
}
```

---

## ▶️ How to Run

1. Clone the repository
2. Create database and tables using provided SQL scripts in Script folder
3. Update connection string
4. Run the application
5. Register a user
6. Assign roles via Admin → User Management

---

## 🧠 Learning Outcomes

* Razor Pages fundamentals
* ASP.NET Core Identity internals
* Custom Identity table mapping
* Role-based UI & authorization
* Real-world authentication flows

---



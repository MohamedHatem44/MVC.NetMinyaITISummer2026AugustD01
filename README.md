# MVC.NetMinyaITISummer2026AugustD01

# 🔷 ASP.NET Core MVC – Day 1 Basics (.NET 9)

This project is a .NET 9 ASP.NET Core MVC Web Application that demonstrates the basics of:

- MVC Architecture  
- Controllers & Actions  
- Action Results  
- Routing  
- Model Binding  
- Passing Data to Views  
- Razor Syntax  
- Working with In-Memory Data  

---

# 📁 Project Structure

```
ASP.NETCoreD01
│
├── Controllers
│   ├── HomeController
│   ├── EmployeeController
│   └── TestController
│
├── Models
│   └── Employee
│
├── Views
│   ├── Home
│   ├── Employee
│   └── Test
│
└── Program.cs
```

---

# 🚀 What This Project Does

- Displays a list of employees
- Shows employee details by Id
- Demonstrates different ActionResult types
- Explains basic Razor syntax
- Shows how routing works

---

# 📌 MVC Pattern

| Part | Role |
|------|------|
| Model | Represents data |
| View | Displays UI |
| Controller | Handles requests |

Flow:

User → Controller → Model → View → Browser

---

# 📌 EmployeeController

Uses a static `List<Employee>` as a fake database.

## 🔹 Get All Employees

```csharp
public IActionResult GetAll()
{
    return View(employees);
}
```

Displays all employees in a table.

---

## 🔹 Get Employee By Id

```csharp
public IActionResult GetById(int id)
```

- Uses Model Binding
- Returns `NotFound()` if employee doesn't exist
- Displays employee details page

Example:

```
/Employee/GetById/3
```

---

# 📌 TestController

Demonstrates different Action Results:

- `string`
- `ContentResult`
- `JsonResult`
- `ViewResult`
- `IActionResult`

Example:

```csharp
public JsonResult ShowHello3()
{
    return new JsonResult(new { Message = "Hello" });
}
```

---

# 📌 Razor Basics

Razor allows mixing C# with HTML.

## Inline Expression

```csharp
<p>@Model.Name</p>
```

## Code Block

```csharp
@{
    int x = 10;
}
```

## Loop

```csharp
@for(int i = 0; i < 5; i++)
{
    <p>@i</p>
}
```

---

# 🛠 Requirements

- .NET 9 SDK  
- Visual Studio 2022+

---

# ▶ Run The Project

```bash
dotnet run
```

Or press **F5** in Visual Studio.

---

# 🎯 Key Takeaway

This project explains how:

- MVC works
- Controllers return different results
- Data is passed from Controller to View
- Razor renders dynamic HTML

It is the foundation before working with databases and advanced MVC features.

# 👨‍💻 Author

Mohamed Hatem  
Software Engineer  

---
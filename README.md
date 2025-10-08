# Employee Management System  

A simple **Employee Management web application** built with **ASP.NET Core MVC (.NET 8)** using **N-Tier architecture**.  
The system allows user registration, login/logout, and employee management (CRUD operations).  

---

## ✨ Features
- 👥 User Registration (Employee / Admin roles)  
- 🔑 Login / Logout (Cookie-based authentication)  
- 📋 Employee Management (CRUD: Create, Read, Update, Delete)  
- 🛡️ Role-based access (Admin can add employees, Employee has limited access)  
- 🔍 Datatable integration with Sorting and Searching  
- 🎨 Bootstrap 5 UI with Modal  
- 🔔 Toast notifications for actions (Register, Login, Delete, etc.)  

---

## 🛠️ Tech Stack
- **Backend:** ASP.NET Core MVC (.NET 8), EF Core  
- **Frontend:** Bootstrap 5  
- **Database:** SQL Server  
- **Authentication:** Cookie-based authentication  

---

## ⚙️ Setup Instructions  

### 1️⃣ Clone the repository

git clone https://github.com/yourusername/EmployeeManagement.git

cd EmployeeManagement

2️⃣ Open in Visual Studio

Open EmployeeManagement.sln in Visual Studio 2022 (or later).

3️⃣ Configure Database

Update appsettings.json with your SQL Server connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;"
}

4️⃣ Apply Migrations

Run the following commands in Package Manager Console:

Add-Migration InitialCreate

Update-Database

5️⃣ Seed Default Users (for demo)

Run this SQL script in your SQL Server:

USE EmployeeDB;

-- Insert default Admin

INSERT INTO [Users] (Username, Password, Role)
VALUES ('admin', '1234', 'Admin');

-- Insert default Employee

INSERT INTO [Users] (Username, Password, Role)
VALUES ('employee', '1234', 'Employee');

6️⃣ Run the Project

Press F5 in Visual Studio or run:

dotnet run


The app will run at:
👉 https://localhost:5001 or http://localhost:5000


📸 Screenshots

🔹 Registration
<img width="1902" height="745" alt="Registration" src="https://github.com/user-attachments/assets/4215ae41-c48f-4e72-bbbb-52ad18a3bfb0" />

🔹 Login
<img width="1917" height="642" alt="Login" src="https://github.com/user-attachments/assets/d152335c-d016-4900-9360-a9eea56b2bf8" />

🔹 Dashboard
<img width="1917" height="565" alt="Dashboard" src="https://github.com/user-attachments/assets/c578fcb6-c0d7-4a3f-a700-eb25650e17ce" />

🔹 Add Employee
<img width="1920" height="644" alt="Add" src="https://github.com/user-attachments/assets/cccaa0ab-25bc-4e77-9cb6-115908bd419d" />

🔹 Delete Confirmation Modal
<img width="1918" height="556" alt="DeleteConfirmModal" src="https://github.com/user-attachments/assets/867ac8aa-f276-4164-831e-f2689216af88" />

👨‍💻 Author

Md. Kamrul Hassan Khan

📧 Email: kamrulmuh39@gmail.com



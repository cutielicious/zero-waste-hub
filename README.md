# Zero Waste Hub

A community recycling management system built as a Windows Forms desktop application in C#. The system is designed to help track raw materials received from suppliers, manage customer and supplier records, process sales, and generate reports on recycling activity.

Repository: https://github.com/cutielicious/zero-waste-hub

---

## About This Project

Zero Waste Hub is a group project (Group20_Project) developed to support a community recycling system. It allows staff to log in securely, record materials received for recycling, manage supplier and customer information, process sales/purchases of recyclable materials, and view reports on top-performing sales and materials over a given period.

---

## Features

Based on the application's structure, Zero Waste Hub includes the following functionality:

- **User Login/Logoff** - Secure access to the system with session handling
- **Customer Management** - Add, view, and manage customer records
- **Supplier Management** - Add, view, and manage supplier records
- **Material Type Management** - Define and manage categories of recyclable materials
- **Material Received Tracking** - Record raw materials received from suppliers, including weight/processing records
- **Buy/Sale Processing** - Handle purchase and sale transactions for materials
- **Cart System** - Track items added during a sale/purchase transaction
- **Sales Reports** - View top-selling materials and sales transactions over a selected period
- **Session Management** - Maintain user session state throughout the application

---

## Tech Stack

| Category | Technology |
|----------|------------|
| Language | C# |
| Framework | .NET (Windows Forms) |
| IDE | Visual Studio |
| UI Type | Desktop Application (WinForms) |

---

## Project Structure

```
zero-waste-hub/
│
├── Group20_Project.csproj          # Project file (build configuration)
├── Program.cs                       # Application entry point
├── Session.cs                       # Handles user session data
├── CartItems.cs                     # Manages items in a cart/transaction
├── Logo.jpg                         # Application logo
│
├── Form1.cs / .Designer.cs / .resx           # Main dashboard form
├── frmBuy.cs / .Designer.cs / .resx           # Buy/purchase transaction form
├── frmCustomers.cs / .Designer.cs / .resx     # Customer management form
├── frmSuppliers.cs / .Designer.cs / .resx     # Supplier management form
├── frmSale.cs / .Designer.cs / .resx          # Sale transaction form
├── frmSaleTransactionPerPeriod.cs / .Designer.cs / .resx   # Sales report by period
├── frmReportTopSale.cs / .Designer.cs / .resx              # Top sales report
├── frmMaterialReceived.cs / .Designer.cs / .resx           # Material intake form
├── frmMaterialTypes.cs / .Designer.cs / .resx              # Material type management
├── frmLogoff.cs / .Designer.cs / .resx        # Logoff form
├── frmView.cs / .Designer.cs / .resx           # View records form
├── Report_Top_10.cs / .Designer.cs             # Top 10 report form
│
├── .gitignore
└── README.md                        # Project documentation (this file)
```

---

## Getting Started

### Prerequisites

- Windows operating system
- Visual Studio 2019 or later (with .NET desktop development workload installed)
- .NET Framework/SDK compatible with the project (as specified in the `.csproj` file)

### Installation and Running

1. Clone the repository:
   ```
   git clone https://github.com/cutielicious/zero-waste-hub.git
   ```
2. Open `Group20_Project.csproj` in Visual Studio.
3. Restore/build the solution (Build > Build Solution, or press `Ctrl+Shift+B`).
4. Run the application (press `F5` or click Start) - this launches the login form first.
5. Log in to access the main dashboard and navigate to the various modules (Customers, Suppliers, Materials, Sales, Reports).

---

## How It Works

1. The application starts at the login form (`frmLogIn`), as defined in `Program.cs`.
2. Once logged in, the user session is tracked via `Session.cs`.
3. From the main dashboard (`Form1`), users can navigate to manage suppliers, customers, and material types.
4. Materials received from suppliers are logged through `frmMaterialReceived`.
5. Sales and purchases are processed through `frmSale` and `frmBuy`, with items tracked using `CartItems.cs`.
6. Reports on sales performance and material trends can be generated through `frmReportTopSale`, `frmSaleTransactionPerPeriod`, and `Report_Top_10`.
7. Users can log off securely through `frmLogoff`.

---

## Author / Group

Group 20 - Developed as part of a collaborative school/university project by a team of 5 members.

| Name | Role/Contribution |
|------|--------------------|
| Mudau Khuthadzo | Login & Session Management |
| Itumeleng Maleka | Customer & Supplier Modules |
| Mlambo Mbali | Material Received & Material Types |
| Delphy Stone | Sales & Cart Processing |
| Tholoana Mothibi | Reports & Testing |

---

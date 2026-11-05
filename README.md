# 🖥️ PC Builder Bangladesh — Desktop Inventory & Custom PC Ordering System

![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/Framework-.NET%208.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/GUI-Windows%20Forms%20(WFA)-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![MS SQL Server](https://img.shields.io/badge/Database-MS%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Visual Studio 2022](https://img.shields.io/badge/IDE-Visual%20Studio%202022-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

> **A role-based desktop management and e-commerce system built using C# .NET 8 Windows Forms and Microsoft SQL Server that streamlines hardware inventory tracking, user administration, and custom PC rig configuration.**

---

## 📖 Project Overview & Academic Context

**PC Builder Bangladesh** is a full-featured desktop application engineered as the capstone term project for the **CSC2210: Object Oriented Programming 2** course during the **Fall 2024–2025** semester at the **American International University-Bangladesh (AIUB)**.

Designed around Object-Oriented Programming (OOP) principles and relational database integration, the platform addresses real-world retail workflows in the computer hardware market. It provides a unified Graphical User Interface (GUI) with role-based access control (RBAC) across three distinct user tiers: **Admin**, **Staff**, and **Customers**.

### 🎓 Course Metadata
* **Institution:** American International University-Bangladesh (AIUB)
* **Department:** Department of Computer Science (Faculty of Science & Technology)
* **Course Code & Title:** CSC2210 — Object Oriented Programming 2 (Section: S)
* **Semester:** Fall 2024–2025
* **Group Number:** Group 01
* **Course Supervisor:** Tamanna Zaman Bristy

---

## 🛠️ Technologies & Tools Used

* **Programming Language:** C# (Object-Oriented Programming)
* **Application Framework:** .NET 8.0 (Windows Forms Application / WFA)
* **Database Management System:** Microsoft SQL Server (T-SQL, ADO.NET Data Access)
* **Data Representation:** `DataGridView` controls, dynamic cart state management, and parameterized CRUD operations
* **Development Environment:** Microsoft Visual Studio 2022

---

## 🏗️ System Architecture & ER Model

The application follows a **3-Tier Desktop Architecture** separating the Windows Forms presentation layer, C# OOP business logic/validation layer, and MS SQL Server persistence layer.

```text
+-------------------------------------------------------------------------+
|                   PRESENTATION LAYER (Windows Forms GUI)                |
|   [Login / Sign-Up Form]   |   [Admin Panel]   |   [Staff & User UI]    |
+------------------------------------+------------------------------------+
                                     |
                                     v
+-------------------------------------------------------------------------+
|                 BUSINESS LOGIC & OOP LAYER (C# .NET 8.0)                |
|  +-------------------+  +--------------------+  +--------------------+  |
|  | Role-Based Auth   |  | Inventory & Stock  |  | Custom PC Builder  |  |
|  | & Form Validation |  | Filtering Engine   |  | & Dynamic Cart     |  |
|  +-------------------+  +--------------------+  +--------------------+  |
+------------------------------------+------------------------------------+
                                     |
                             (ADO.NET / SQLClient)
                                     |
                                     v
+-------------------------------------------------------------------------+
|               DATA PERSISTENCE LAYER (Microsoft SQL Server)             |
|  +------------------+  +---------------------+  +--------------------+  |
|  | User Tables:     |  | Hardware Tables (8):|  | Transaction Tables:|  |
|  | Admin, Staff,    |  | CPU, GPU/Monitor,   |  | Order (Single),    |  |
|  | Customer         |  | RAM, ROM, Mobo, etc.|  | PCorder (Custom)   |  |
|  +------------------+  +---------------------+  +--------------------+  |
+-------------------------------------------------------------------------+
```

### Entity-Relationship (ER) Cardinality Summary
* **`ADMIN` $\xrightarrow{1..*}$ `CUSTOMER` / `STAFF`:** Admin manages (creates, updates, deletes, and audits) multiple Staff and Customer accounts.
* **`STAFF` $\xrightarrow{1..*}$ `PC_COMPONENTS`:** Staff manages inventory items across 8 hardware categories and monitors stock availability.
* **`CUSTOMER` $\xrightarrow{1..*}$ `PC_COMPONENTS`:** Customers browse and select single or multiple hardware components.
* **`CUSTOMER` $\xrightarrow{1..*}$ `ORDER` / `PC_ORDER`:** Customers place single-item orders or bundled custom PC rig orders, which are subsequently managed and fulfilled by **`STAFF`**.

---

## ✨ Key Features & Role-Based Functionalities

### 🛡️ 1. Administrator Module (`Admin`)
The Admin holds system-wide privileges over user management and security oversight:
* **Database-Level Authentication:** Admin accounts are provisioned directly at the database level (no public registration) using a unique `Name` (Primary Key) and `Pass`.
* **Direct User Provisioning:** Create pre-verified `Customer` or `Staff` accounts with Name, Contact Number, Password, Email, and Residential Address.
* **User Directory & Search:** View all registered Customers and Staff in a unified `DataGridView` or filter records instantaneously by `Name`.
* **Account Modification & Removal:** Update user credentials and contact details in real time or permanently remove accounts from the database.

### 📦 2. Inventory & Order Staff Module (`Staff`)
Staff members control the hardware catalog, stock levels, and order fulfillment pipeline:
* **Self-Registration & Login:** New staff members can register via the unified Sign-Up portal by selecting the `Staff` role.
* **Multi-Category Product Addition:** Add new hardware items with unique `ID` (Primary Key), `Name`, `Brand`, `Model`, `Price`, `Quantity`, and `Storage` into 8 dedicated component tables:
  * **Monitor** | **Mouse** | **Keyboard** | **CPU (Casing/Cooler)** | **Processor** | **Motherboard** | **RAM** | **ROM (SSD/HDD)**
* **Category-Sorted Product Deletion:** Filter inventory by hardware category (automatically sorted in ascending order by `ID`) and delete obsolete products.
* **Live Stock Auditing:** Dual-grid dashboard displaying **Available Products** (in-stock items) alongside **Stock Out Products** (items with zero quantity) for rapid restocking decisions.
* **Dual Order Queue Management:** View and process both **Placed Orders** (individual component purchases) and **Placed PC Orders** (full custom rig builds), sorted by `Serial` number.

### 🛒 3. Customer & Custom PC Builder Module (`Customer`)
Customers experience an intuitive shopping and custom rig-building workflow:
* **Customer Registration & Authentication:** Quick onboarding with password visibility toggles and form validation.
* **Interactive Custom PC Builder (`OrderPC`):**
  * Browse live inventory across all 8 component categories.
  * Dynamically **Add** or **Delete** components into slots for Monitor, Mouse, Keyboard, CPU, Processor, Motherboard, RAM, and ROM.
  * Real-time calculation of cumulative `TotalPrice` and concatenated `Products` list.
  * Custom `BillingName` support (for gifting or third-party delivery).
* **Individual Component Ordering (`OrderProduct`):** Purchase standalone accessories or replacement parts with automatic quantity multiplication (`TotalQuantity` $\times$ `UnitPrice`).
* **Checkout & Payment:** Integrated **Cash on Delivery (COD)** confirmation workflow.

---

## 🗄️ Database Schema & Normalization (2NF)

All database tables are normalized to **Second Normal Form (2NF)**, ensuring every non-key attribute is fully functionally dependent on the table's Primary Key.

| Entity / Table Group | Primary Key (PK) | Attributes / Columns |
| :--- | :--- | :--- |
| **`Admin`** | `Name` | `Pass` |
| **`Staff`** | `NAME` | `PASS`, `NUMBER`, `MAIL`, `ADDRESS` |
| **`Customer`** | `NAME` | `PASS`, `NUMBER`, `MAIL`, `ADDRESS` |
| **Hardware Tables (x8)**<br>*(CPU, Keyboard, Monitor, Motherboard, Mouse, Processor, Ram, Rom)* | `Id` | `Name`, `Price`, `Brand`, `Model`, `Quantity`, `Image`, `Storage` |
| **`PCorder`** *(Custom Builds)* | `Serial` *(Identity 1,1)* | `Name`, `Products`, `TotalPrice` |
| **`Order`** *(Single Items)* | `Serial` *(Identity 1,1)* | `Buyer Name`, `Quantity`, `Total_Price` |

<details>
<summary><b>🔽 Click to Expand Complete MS SQL Server (T-SQL) Table Creation Script</b></summary>

```sql
-- 1. Admin Table
CREATE TABLE [dbo].[Admin] (
    [Pass] INT NOT NULL,
    [Name] NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

-- 2. Staff Table
CREATE TABLE [dbo].[Staff] (
    [NAME]    NCHAR (10)    NOT NULL,
    [PASS]    INT           NOT NULL,
    [NUMBER]  NCHAR (10)    NULL,
    [MAIL]    NVARCHAR (50) NULL,
    [ADDRESS] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([NAME] ASC)
);

-- 3. Customer Table
CREATE TABLE [dbo].[Customer] (
    [NAME]    NCHAR (10)    NOT NULL,
    [PASS]    INT           NOT NULL,
    [NUMBER]  NCHAR (10)    NULL,
    [MAIL]    NVARCHAR (50) NULL,
    [ADDRESS] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([NAME] ASC)
);

-- 4. Custom PC Order Table
CREATE TABLE [dbo].[PCorder] (
    [Serial]     INT IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NULL,
    [Products]   VARCHAR (50) NULL,
    [TotalPrice] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Serial] ASC)
);

-- 5. Individual Component Order Table
CREATE TABLE [dbo].[Order] (
    [Serial]      INT IDENTITY (1, 1) NOT NULL,
    [Buyer Name]  VARCHAR (50) NULL,
    [Quantity]    VARCHAR (50) NULL,
    [Total_Price] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Serial] ASC)
);

-- 6. Hardware Component Tables (CPU, Keyboard, Monitor, Motherboard, Mouse, Processor, Ram, Rom)
-- Note: Repeat structure below for [Keyboard], [Monitor], [Motherboard], [Mouse], [Processor], [Ram], and [Rom]
CREATE TABLE [dbo].[CPU] (
    [Id]       INT            NOT NULL,
    [Name]     VARCHAR (50)   NULL,
    [Price]    VARCHAR (50)   NULL,
    [Brand]    VARCHAR (50)   NULL,
    [Model]    VARCHAR (50)   NULL,
    [Quantity] VARCHAR (50)   NULL,
    [Image]    NVARCHAR (255) NULL,
    [Storage]  VARCHAR (50)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```
</details>

---

## ⚙️ Installation & Local Setup Guide

### Prerequisites
1. **Visual Studio 2022** with the **.NET Desktop Development** workload installed.
2. **.NET 8.0 SDK**.
3. **Microsoft SQL Server** (Express, Developer, or LocalDB) & **SQL Server Management Studio (SSMS)**.

### Step-by-Step Execution
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/PC-Builder-Bangladesh.git
   cd PC-Builder-Bangladesh
   ```
2. **Initialize the Database:**
   * Open **SSMS**, create a new database, and execute the T-SQL table creation queries provided in the expandable section above.
   * Insert a default Admin record into `[dbo].[Admin]` so you can log into the Admin Dashboard:
     ```sql
     INSERT INTO [dbo].[Admin] ([Name], [Pass]) VALUES ('admin', 1234);
     ```
3. **Configure Connection String:**
   * Open the `.sln` file in **Visual Studio 2022**.
   * Update the `SqlConnection` connection string in the project source code to match your local SQL Server instance (`Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DB_NAME;Integrated Security=True`).
4. **Build & Run:**
   * Press **F5** or click **Start** in Visual Studio 2022 to launch the application.

---

## 🚀 Future Scope & Enhancements

* **Component Compatibility Checker:** Automatically verify CPU socket and Motherboard chipset compatibility (e.g., AM5 vs. LGA1700) and RAM generation (DDR4 vs. DDR5) during custom PC configuration.
* **Online Payment Gateways:** Expand beyond Cash on Delivery (COD) to support bKash, Nagad, and SSLCommerz sandbox integrations.
* **Automated PDF Invoice Generation:** Generate downloadable PDF receipts and warranty slips upon order confirmation.
* **Password Hashing:** Upgrade authentication storage from plain integers/strings to salted SHA-256/BCrypt password hashes.

---

## 👥 Group Members & Contributors

Developed by **Group 01** (Section S, Fall 2024–2025):

| # | Name | Student ID | Role |
| :---: | :--- | :---: | :--- |
| 1 | **Shahadat Hossain** | `23-51341-1` | Full-Stack .NET Developer & Database Architect |
| 2 | **Hamidul Islam** | `23-50447-1` | Windows Forms UI/UX & Module Developer |

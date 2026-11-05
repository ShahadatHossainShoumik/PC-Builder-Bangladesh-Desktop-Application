<div align="center">

# PC Builder Bangladesh
### *Enterprise Desktop Inventory Management & Custom PC Configuration System*

![C#](https://img.shields.io/badge/C%23-12.0-512BD4?style=flat-square&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-8.0_Windows_Forms-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/Database-Microsoft_SQL_Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)
![ADO.NET](https://img.shields.io/badge/Data_Access-ADO.NET-0078D4?style=flat-square&logo=microsoft&logoColor=white)
![Visual Studio](https://img.shields.io/badge/IDE-Visual_Studio_2022-5C2D91?style=flat-square&logo=visualstudio&logoColor=white)
![Status](https://img.shields.io/badge/Build-Completed-2EA043?style=flat-square)

**Course:** CSC2210 — Object Oriented Programming 2 (Section: S | Group: 01)  
**Semester:** Fall 2024–2025 | **Institution:** American International University-Bangladesh (AIUB)  
**Supervisor:** Tamanna Zaman Bristy | **Domain:** Retail ERP & Custom Hardware E-Commerce

</div>

---

## Table of Contents
- [Project Overview](#project-overview)
- [Business Context & Target Users](#business-context--target-users)
- [Technology Stack & Architecture](#technology-stack--architecture)
- [Database Schema & Normalization (2NF)](#database-schema--normalization-2nf)
- [Core Modules & Functional Specifications](#core-modules--functional-specifications)
- [Object-Oriented Design & System Workflow](#object-oriented-design--system-workflow)
- [Installation & Deployment Guide](#installation--deployment-guide)
- [Project Engineering Team](#project-engineering-team)

---

## Project Overview
**PC Builder Bangladesh** is a multi-tier desktop management and retail ordering system built on the **.NET 8.0 framework** using **C# Windows Forms Application (WFA)** and **Microsoft SQL Server**. 

Developed following strict Object-Oriented Programming (OOP) principles and relational database normalization standards, the platform unifies retail hardware inventory management, administrative user oversight, and an interactive custom PC rig configurator. The application enforces Role-Based Access Control (RBAC) across three distinct operational tiers—**Administrator**, **Staff**, and **Customer**—ensuring secure data flow, real-time stock auditing, and automated order processing.

---

## Business Context & Target Users
Retail computer hardware businesses manage complex multi-category inventories alongside custom-built PC orders. This system addresses those operational requirements across three user groups:

* **System Administrators:** Maintain organizational security by provisioning internal accounts, auditing registered users, updating credentials, and revoking access.
* **Inventory & Fulfillment Staff:** Track real-time stock levels across eight hardware categories, identify out-of-stock components instantaneously, and process both standalone accessory orders and bundled custom PC builds.
* **Retail Customers:** Browse hardware catalogs, dynamically configure full custom desktop rigs with live price aggregation, or purchase standalone components via a streamlined checkout workflow.

---

## Technology Stack & Architecture

| Layer / Category | Technology | Implementation Details |
| :--- | :--- | :--- |
| **Core Language** | **C# (.NET 8.0)** | Object-oriented business logic, event-driven form controllers, and input validation |
| **Presentation Layer** | **Windows Forms (WinForms)** | Desktop Graphical User Interface (GUI), `DataGridView` data binding, and multi-form navigation |
| **Persistence Layer** | **Microsoft SQL Server** | Relational storage across 13 normalized tables (`Admin`, `Staff`, `Customer`, `Order`, `PCorder`, and 8 component tables) |
| **Data Access Layer** | **ADO.NET (`System.Data.SqlClient`)** | Relational CRUD operations, SQL query execution, and tabular dataset synchronization |
| **Development Environment** | **Visual Studio 2022** | UI designer, build management, and SQL Server Object Explorer integration |
| **Version Control** | **Git & GitHub** | Source control, documentation, and release management |

### Three-Tier System Architecture

```text
+-------------------------------------------------------------------------+
|                   PRESENTATION LAYER (WinForms Desktop UI)              |
|   [Authentication Portal]   |   [Admin Console]   |   [Staff & User UI] |
+------------------------------------+------------------------------------+
                                     |
                                     v
+-------------------------------------------------------------------------+
|                 APPLICATION & OOP LOGIC LAYER (C# .NET 8.0)             |
|  +-------------------+  +--------------------+  +--------------------+  |
|  | Role-Based Access |  | Inventory & Stock  |  | Custom Rig Builder |  |
|  | & Form Validation |  | Filtering Engine   |  | & Cart Aggregator  |  |
|  +-------------------+  +--------------------+  +--------------------+  |
+------------------------------------+------------------------------------+
                                     |
                             (ADO.NET / T-SQL)
                                     |
                                     v
+-------------------------------------------------------------------------+
|               DATA PERSISTENCE LAYER (Microsoft SQL Server)             |
|  +------------------+  +---------------------+  +--------------------+  |
|  | Identity Tables: |  | Catalog Tables (8): |  | Transaction Tables:|  |
|  | Admin, Staff,    |  | CPU, Monitor, RAM,  |  | Order (Single),    |  |
|  | Customer         |  | ROM, Mobo, Mouse... |  | PCorder (Custom)   |  |
|  +------------------+  +---------------------+  +--------------------+  |
+-------------------------------------------------------------------------+
```

---

## Database Schema & Normalization (2NF)

* **Database Engine:** Microsoft SQL Server (T-SQL)
* **Normalization Standard:** **Second Normal Form (2NF)** — All non-key attributes are fully functionally dependent on each table's Clustered Primary Key.
* **Catalog Partitioning:** Hardware inventory is segmented into **8 dedicated component tables** (`CPU`, `Keyboard`, `Monitor`, `Motherboard`, `Mouse`, `Processor`, `Ram`, `Rom`) to optimize category-specific querying and sorting.

| Table Name | Primary Key | Schema Attributes & Data Types | Purpose |
| :--- | :--- | :--- | :--- |
| **`Admin`** | `Name` (`NCHAR(10)`) | `Pass` (`INT`) | Stores internal system administrator credentials |
| **`Staff`** | `NAME` (`NCHAR(10)`) | `PASS` (`INT`), `NUMBER` (`NCHAR(10)`), `MAIL` (`NVARCHAR(50)`), `ADDRESS` (`NCHAR(10)`) | Stores inventory and order management staff profiles |
| **`Customer`** | `NAME` (`NCHAR(10)`) | `PASS` (`INT`), `NUMBER` (`NCHAR(10)`), `MAIL` (`NVARCHAR(50)`), `ADDRESS` (`NCHAR(10)`) | Stores registered customer accounts and billing details |
| **`[Components]`** *(x8 Tables)* | `Id` (`INT`) | `Name`, `Price`, `Brand`, `Model`, `Quantity`, `Storage` (`VARCHAR(50)`), `Image` (`NVARCHAR(255)`) | Stores hardware specs and stock levels for all 8 component categories |
| **`Order`** | `Serial` (`INT IDENTITY`) | `Buyer_Name`, `Quantity`, `Total_Price` (`VARCHAR(50)`) | Logs standalone single-component customer purchases |
| **`PCorder`** | `Serial` (`INT IDENTITY`) | `Name`, `Products`, `TotalPrice` (`VARCHAR(50)`) | Logs multi-component custom PC rig orders |

<details>
<summary><b>Click to Expand: Entity-Relationship (ER) Cardinality & T-SQL Schema Definitions</b></summary>
<br>

### Entity-Relationship Mapping
* **`ADMIN` (1..*) ➔ `CUSTOMER` / `STAFF`:** Administrators provision, update, search, and remove multiple Customer and Staff records.
* **`STAFF` (1..*) ➔ `PC_COMPONENTS`:** Staff members manage hardware entries across all 8 component tables.
* **`CUSTOMER` (1..*) ➔ `PC_COMPONENTS`:** Customers select single or multiple components to build orders.
* **`CUSTOMER` (1..*) ➔ `ORDER` / `PC_ORDER`:** Customers generate transaction records that are audited and fulfilled by **`STAFF`**.

### T-SQL Table Creation Scripts
```sql
-- 1. User Role Tables
CREATE TABLE [dbo].[Admin] (
    [Pass] INT NOT NULL,
    [Name] NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

CREATE TABLE [dbo].[Staff] (
    [NAME]    NCHAR (10)    NOT NULL,
    [PASS]    INT           NOT NULL,
    [NUMBER]  NCHAR (10)    NULL,
    [MAIL]    NVARCHAR (50) NULL,
    [ADDRESS] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([NAME] ASC)
);

CREATE TABLE [dbo].[Customer] (
    [NAME]    NCHAR (10)    NOT NULL,
    [PASS]    INT           NOT NULL,
    [NUMBER]  NCHAR (10)    NULL,
    [MAIL]    NVARCHAR (50) NULL,
    [ADDRESS] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([NAME] ASC)
);

-- 2. Order Transaction Tables
CREATE TABLE [dbo].[PCorder] (
    [Serial]     INT IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NULL,
    [Products]   VARCHAR (50) NULL,
    [TotalPrice] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Serial] ASC)
);

CREATE TABLE [dbo].[Order] (
    [Serial]      INT IDENTITY (1, 1) NOT NULL,
    [Buyer_Name]  VARCHAR (50) NULL,
    [Quantity]    VARCHAR (50) NULL,
    [Total_Price] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Serial] ASC)
);

-- 3. Hardware Component Table Template (Applied to CPU, Keyboard, Monitor, Motherboard, Mouse, Processor, Ram, Rom)
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

## Core Modules & Functional Specifications

1. **Administrator Management Suite (`Admin`):**
   - **Database-Enforced Security:** Admin accounts cannot be created via public sign-up forms; they are provisioned directly within SQL Server to prevent privilege escalation.
   - **Direct User Provisioning (`Add User`):** Creates pre-verified `Customer` or `Staff` accounts with full contact metadata.
   - **Live Directory & Search (`Show User`):** Queries and displays all registered users in a unified `DataGridView` with instant filtering by `Name`.
   - **Account Maintenance (`Update Info` & `Delete User`):** Modifies user contact details, passwords, or unique usernames, and permanently removes inactive accounts.

2. **Inventory & Fulfillment Suite (`Staff`):**
   - **Multi-Category Product Registration (`AddProduct`):** Inserts new hardware items (`Id`, `Name`, `Brand`, `Price`, `Model`, `Quantity`, `Storage`) into the selected category table (`Monitor`, `Mouse`, `Keyboard`, `CPU`, `Processor`, `Motherboard`, `RAM`, or `ROM`).
   - **Category-Filtered Removal (`DeleteProduct`):** Dynamically loads products by category sorted in ascending order by `Id` for one-click deletion.
   - **Dual-Grid Stock Auditing (`ProductDetails`):** Displays side-by-side views of **Available Products** (in stock) and **Stock Out Products** (`Quantity = 0`) to streamline restocking.
   - **Order Queue Management (`ShowOrder`):** Provides separate real-time views for **Placed Orders** (single items) and **Placed PC Orders** (custom builds), sorted sequentially by `Serial`.

3. **Customer Shopping & Custom PC Builder Suite (`Customer`):**
   - **Interactive Custom Rig Configurator (`OrderPC`):** Allows users to switch across all 8 hardware categories, add or remove individual components from dedicated hardware slots, and dynamically compute the cumulative `TotalPrice` and concatenated `Products` manifest.
   - **Standalone Component Purchasing (`OrderProduct`):** Supports direct single-category hardware purchases with automatic quantity-based price calculation (`TotalQuantity * Price`).
   - **Third-Party Billing & Checkout:** Supports custom `BillingName` assignment for gift or recipient deliveries and concludes with a **Cash on Delivery (COD)** confirmation workflow.

---

## Object-Oriented Design & System Workflow

<details>
<summary><b>Click to Expand: OOP Principles, Validation & Data Verification</b></summary>
<br>

* **Encapsulation & Modular Form Design:**
  * Each functional workflow (Authentication, Admin CRUD, Staff Inventory Control, Customer Rig Configuration, and Payment Confirmation) is encapsulated within dedicated Windows Form classes.
* **Input Validation & Data Integrity:**
  * Enforces primary key uniqueness on User `Name` and Product `Id` fields prior to database insertion.
  * Implements password masking with interactive visibility toggles (`Show Password` checkboxes) across Login, Sign-Up, Add User, and Update User forms.
  * Validates role selection radio buttons (`Customer` vs. `Staff`) and category selectors before executing SQL transactions.
* **Dynamic State Synchronization:**
  * Selecting any row in a `DataGridView` automatically populates bound textboxes for immediate editing or order calculation, ensuring real-time synchronization between the UI state and underlying SQL Server records.

</details>

---

## Installation & Deployment Guide

### 1. Clone the Repository
```bash
git clone https://github.com/<your-username>/PC-Builder-Bangladesh-Desktop-App.git
cd PC-Builder-Bangladesh-Desktop-App
```

### 2. Configure Microsoft SQL Server
1. Open **SQL Server Management Studio (SSMS)** or **Visual Studio SQL Server Object Explorer**.
2. Create a new database for the application.
3. Execute the T-SQL table creation scripts provided in the [Database Schema](#database-schema--normalization-2nf) section to initialize the `Admin`, `Staff`, `Customer`, `Order`, `PCorder`, and 8 hardware component tables.
4. Insert an initial Administrator record into the `[dbo].[Admin]` table for first-time login.

### 3. Update Database Connection & Run
1. Open the `.sln` solution file in **Visual Studio 2022** (ensure the **.NET Desktop Development** workload with **.NET 8.0** is installed).
2. Update the SQL Server connection string in the project configuration/data access class to point to your local SQL Server instance.
3. Press **F5** (or click **Start**) to build and launch the desktop application.

---

## Project Engineering Team

| Name | Student ID | Role & Module Responsibility |
| :--- | :--- | :--- |
| **Shahadat Hossain** | `23-51341-1` | System Architecture, Database Schema Design, Admin & Custom PC Builder Modules |
| **Hamidul Islam** | `23-50447-1` | Staff Inventory Management, Stock Auditing Grids & Order Processing Modules |
| **Razia Fahmida Haque** | `23-50740-1` | Customer Authentication, Standalone Product Ordering, UI Design & Validation |

---

<div align="center">
  <i>Developed for CSC2210 (Object Oriented Programming 2) — Fall 2024–2025 Semester at American International University-Bangladesh (AIUB).</i>
</div>[pc_builder_bangladesh_c_net_project_readme.md](https://github.com/user-attachments/files/34446933/pc_builder_bangladesh_c_net_project_readme.md)

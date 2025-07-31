# 📺 TV Interaction Dashboard

This is an interactive analytics dashboard built using **Blazor Web App (Server)**, **Telerik UI for Blazor** and **Entity Framework Core**. It tracks and visualizes viewer interactions in front of TVs installed at various plant locations.

The dashboard displays key metrics and charts based on viewer interaction data such as total interactions, average viewing duration and trends over time.

---

## 🚀 Features

- 🔧 **Filterable Dashboard**  
  - Plant → Location → Time (enforced selection order)
  - Preset and custom datetime filters (Last 24h, 7d, 14d, 30d, Custom)

- 📊 **Visual Analytics**  
  - Total Interactions and Average Duration KPI cards  
  - Line Charts: Interactions Per Day, Average Duration Per Day  
  - Bar Chart: Interactions by TV Unit (Left, Center, Right)  
  - Line + Bar Combo Chart: Interactions vs. Average Duration with dual Y-axes  
  - Heatmap: Peak Viewing Hours by Day
  - Full Interaction Logs

- 📦 **Export Support**  
  - Export any chart to PNG or JPG  
  - Export buttons accessible via toolbar above each chart
  - Export Interaction Logs to CSV  
  - Charts export cleanly without UI buttons included

- 🧠 **Smart UI Behaviors**
  - Charts respond to selected filters  
  - Zooming, panning, tooltips, and responsive design  
  - No Data Templates when no results are available
  - Toggle Zero-Data Inclusion


---

## 🛠️ Tech Stack

- [.NET 8](https://dotnet.microsoft.com/)
- [Blazor Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [Telerik UI for Blazor](https://www.telerik.com/blazor-ui)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/)
- SQL Server (for data storage)
- JavaScript Interop (for export functionality)


---

## ⚙️ Setup Instructions

### 1. Clone the Repository
git clone https://github.com/your-username/InteractionDashboard.git
cd InteractionDashboard

### 2. Configure the Database Connection
Create your own development config:

- Locate appsettings.json and make a copy of it with the name "appsettings.Development.json" or run the following command:
cp appsettings.json appsettings.Development.json

Then edit appsettings.Development.json with your actual connection string based on the comments in the file.

### 3. Run the Project
Open the solution in Visual Studio 2022, restore NuGet packages, and hit Run.

Make sure you have:

Telerik UI for Blazor installed and licensed

Access to the Microsoft SQL Server database you're connecting to

---

## 🛡 Security
Your actual database connection is not exposed.

The .gitignore file excludes appsettings.Development.json from being tracked by Git.

---

## 📌 Notes
This project uses Telerik UI components, so you need an active license.

Default plant and location are pre-selected on load (e.g., PN1 and Ground Floor).

Charts and filters are built to match internal Figma designs.

---

## 📄 License
This project is maintained internally and is not currently under a public license. Contributions are welcomed.

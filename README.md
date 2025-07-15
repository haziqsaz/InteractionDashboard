# 📺 TV Interaction Dashboard (Blazor + Telerik UI)

This is an interactive analytics dashboard built using **Blazor Server**, **Telerik UI for Blazor** and **Entity Framework Core**. It tracks and visualizes viewer interactions in front of TVs installed at various plant locations.

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

---

## 🛠️ Technologies Used

- [.NET 8](https://dotnet.microsoft.com/)
- [Blazor Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [Telerik UI for Blazor](https://www.telerik.com/blazor-ui)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/)
- SQL Server (for data storage)
- JavaScript Interop (for export functionality)

---

## 🧪 Requirements

- Visual Studio 2022 or later
- Telerik UI for Blazor (licensed)
- SQL Server Management Studio 2021 (Or other DB)

---

# 💊 State Pharmaceutical Cooperation (SPC) - SOA System  

✨ **A modern SOA solution for pharmaceutical supply chain management**  
*Built with .NET SOAP APIs, MySQL, and cross-platform clients*  

![System Overview](Screenshots_application/home.png)  

---

## 🚀 **Key Features**  

| Feature                | Description                                                                 | Screenshot                          |
|------------------------|-----------------------------------------------------------------------------|-------------------------------------|
| **🧾 Supplier Registration** | Register suppliers via web or SPC branches.                                 | ![Supplier](Screenshots_application/supplier.png) |
| **📦 Stock Management**     | Real-time inventory updates from plants/warehouses.                         | ![Stock](Screenshots_application/addDrug.png)<br>![Register 2](Screenshots_application/addDrug1.png)     |
| **🔍 Drug Search & Order (Pharmacy Dashboard)**  | Pharmacies search/order drugs.                             | ![Order](Screenshots_application/pharmacyDash.png)<br>![Register 2](Screenshots_application/pharmacydash2.png)      |
| **🔍 Add new stock by Staff** | Staff can search and add and manage new stock directly in the system.                    | ![Supplier](Screenshots_application/staffDash.png)<br>![Register 2](Screenshots_application/addnewdetail.png) |
| **🔐 Login** | Secure login functionality for different user roles.                               | ![Supplier](Screenshots_application/login.png) |
| **📝 Supplier Registration** | Pharmacies can register via a dedicated form.                                 | ![Supplier](Screenshots_application/pharmacyregister.png)<br>![Register 2](Screenshots_application/pharmacyregister1.png) |
---

## **SOAP Web Service Overview**

<p>💡 Our system includes multiple SOAP-based web services. Below is an example of one such service used for supplier registration.</p>


| Name                | Description                                                                 |Method      |  Screenshot                          |
|------------------------|-----------------------------------------------------------------------------|-------------------------------------|-------------------------------------|
| **🧾SupplierWebService** | Provides supplier registration functionality through web or SPC branches. Includes automatic ID generation and supplier data insertion.                                |AutoSupplierId() , InsertSupplier()                                 | ![Supplier](Screenshots_application/webservice.png) |

## 🛠 **Tech Stack**  

- **🌐 Backend**: `.NET 6 + WCF (SOAP)`  
- **🗃 Database**: `MySQL 
- **📱 Clients**: `ASP.NET Web Application (.NET Framework) 
- **📡 API**: `XML/SOAP` for cross-platform compatibility  

---

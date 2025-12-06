# 🏢 LeaveFlow - Vállalati Jelenlét és Szabadságkezelő Rendszer

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)
![Angular](https://img.shields.io/badge/Angular-18+-DD0031?style=flat&logo=angular)
![TypeScript](https://img.shields.io/badge/TypeScript-3178C6?style=flat&logo=typescript)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat&logo=docker)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat&logo=microsoft-sql-server)

A **LeaveFlow** egy modern, Full-Stack vállalati webalkalmazás, amelyet a belső HR folyamatok, különösen a szabadságkérelmek és a szervezeti felépítés kezelésére terveztem.

A projekt **Monorepo** struktúrát használ, amely magában foglalja a .NET alapú REST API-t és a hozzá tartozó Angular frontend klienst.

---

## 🚀 Funkciók

### Backend (.NET API)
* **API Architektúra:** RESTful szolgáltatások, Clean Architecture elvek.
* **Adatkezelés:** Repository Pattern és Unit of Work a tiszta adathozzáférésért.
* **Dokumentáció:** Swagger UI XML kommentekkel a fejlesztők számára.
* **Adatbázis:** Code-First / Database-First megközelítés EF Core-ral, Docker konténerben.

### Frontend (Angular Client)
* **Modern UI:** Komponens alapú architektúra (Standalone Components).
* **Reaktív Adatkezelés:** RxJS és `Async Pipe` használata a valós idejű adatmegjelenítéshez.
* **Struktúra:** Szeparált Service réteg az API kommunikációhoz.
* **Megjelenítés:** Dinamikus táblázatok és adatlisták.

---

## 🏗️ Technológiai Stack

| Terület | Technológiák |
| :--- | :--- |
| **Backend** | .NET 8, ASP.NET Core Web API, C# |
| **Frontend** | Angular v18, TypeScript, RxJS, HTML5, CSS3 |
| **Adatbázis** | Microsoft SQL Server 2022 (Docker) |
| **ORM** | Entity Framework Core |
| **Eszközök** | Swagger (OpenAPI), Docker, Git |

---

## 📂 Projekt Struktúra (Monorepo)

```text
LeaveFlow/             (Gyökérkönyvtár)
├── LeaveFlowAPI/      (Backend Projekt - .NET)
│   ├── Controllers/
│   ├── Repositories/
│   └── ...
├── LeaveFlow-Client/  (Frontend Projekt - Angular)
│   ├── src/app/
│   └── ...
└── README.md
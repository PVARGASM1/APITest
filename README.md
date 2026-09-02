# APITest
Prueba técnica

# Prueba Técnica - API Productos

Prueba técnica para Desarrollador Junior .Net + SQL. 
En este proyecto se implementa una API REST para la gestión de productos, desarrollada en **.NET** con **Entity Framework Core** y **SQL Server**.  
Incluye operaciones CRUD (GET, POST, PUT, DELETE), validaciones, eliminación lógica (soft delete +o cambio de estado del producto) y documentación con Swagger.
---

## 📋 Prerequisitos

Antes de ejecutar el proyecto, asegúrate de tener instalado:

- .NET 8 SDK o superior  
- SQL Server (local)  
- SQL Server Management Studio (SSMS)  
- Visual Studio 2022 / VS Code  
- Git  

---

## 🔧 Instalar y Ejecutar API

    $ git clone https://github.com/PVARGASM1/APITest/tree/main
    $ cd PruebaTecnica.Api


## 🗄️ Crear la base de datos

1. Abre **SQL Server Management Studio (SSMS) o SQL Server**.  
2. Conéctate a tu servidor SQL.  
3. Abre el archivo [`database.sql`](./database/database.sql).  
4. Ejecuta el script completo.  

El archivo `database.sql` contiene:


## Connection String
Configurar en `APITest/PruebaTecnica.Api/appsettings.json`:

  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=PruebaTecnica;Trusted_Connection=True;"
  }

## 🛠️ Desarrollo Local 
## Ejecutar la API

  1. Abrir terminal en `APITest/PruebaTecnica.Api`
  2. Restaurar paquetes: `dotnet restore`
  4. Ejecutar: `dotnet run`
  5. Swagger disponible en `https://localhost:{puerto}/swagger`

## Endpoints

  - `GET /api/productos` -> Lista productos activos por defecto
  - `GET /api/productos/{id}` -> Obtener por id
  - `POST /api/productos` -> Crear producto
  - `PUT /api/productos/{id}` -> Actualizar producto
  - `DELETE /api/productos/{id}` -> Eliminación lógica (Activo = 0)


## Decisiones técnicas

- **Soft delete** para conservar historial, solo cambia estado a false, según requerimiento.

## 👥 Contributions 🛠️

- Paula Andrea Vargas - (https://github.com/PVARGASM1)






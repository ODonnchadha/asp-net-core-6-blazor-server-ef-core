## Building a Data-driven ASP.NET Core 6 Blazor Server Application with EF Core
- by Thomas Claudius Huber

- OVERVIEW:
  - This course will teach you how to use Blazor Server and Entity Framework Core to build a data-driven web application with .NET and C#.

- CREATING THE BLAZOR SERVER PROJECT:
  - Hosting models:
    - Blazor WebAssembly: Browser. On top of .NET runtime. Need API for data access.
    - Blazor Server: Browser. (DOM only.) blazor.server.js. SignalR. Blazor Application. Data storage.
      - Application code is *not* served to the client. Support for thin clients due to logic executed on the server.
      - Does not scale well. Every user connected. High latency. No offline support.

- SETTING UP ENTITY FRAMEWORK CORE:
  ```javascript
    script-migration
    add-migration seed
    update-database
  ```

- READING & SHOWING A LIST OF DATA:
  - [Ctrl] + k + d: to format HTML code.
  - DbContextFactory: Via SignalR. Compomemnt within browser is tied to lifetime.
    - The lifetime of a DbContext instance is typically very short. 
      - Unit of work. (1) Create context. (2) Load Employees. (3) Dispose context. Not possible with injection.
      - IDbContextFactory.
      ```csharp
        builder.Services.AddDbContext<EmployeeManagerDbContext>(
          options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("x")));
        
        builder.Services.AddDbContextFactory<EmployeeManagerDbContext>(
          options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("x")));
      ```
  
- IMPLEMENTING PAGINATION:
  - View -> Other Windows -> C# Interactive
    - Execute C# code to try out and validate.

- ADDING A NEW DATA ITEM:
  - Building a form to add a new employee.
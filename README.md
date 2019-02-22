# ChinookCoreAPISolution
API example with .net core

Install:

- Install-Package Microsoft.EntityFrameworkCore.SqlServer
- Install-Package Microsoft.EntityFrameworkCore.Tools
- Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design

To construct models from database:

- Scaffold-DbContext "Server=.;Database=Chinook;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

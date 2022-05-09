# ASP.NET CORE MVC APP WITH ENTITY FRAMEWORK AND SQL SERVER DEVELOPMENT CONTAINER
After cloning this repository open it within Visual Studio Code.

When prompted, select re-open in development container.

When the development container is running open a terminal within Visual Studio Code such that your commands will be executed on your development container.

Execute the following commands:

``` bash
dotnet dev-certs https --trust
dotnet tools restore
```

Then go to the Run and Debug tool in Visual Studio Code and hit the play button or press F5 to begin running the application.

## Adding Database Tables
- Create the class
- Add the class to the DbContext
- Execute the following commands

```bash
dotnet ef migrations add SomeMigrationName
dotnet ef database update
```

Sample scaffolded controller:

```bash
dotnet aspnet-codegenerator controller -name ItemsController -m MyApplication.Web.Data.Item -dc MyApplication.Web.Data.ApplicationDbContext -scripts -udl -f -outDir ./Controllers
```
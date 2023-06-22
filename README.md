I am going to take web Cousrses to show Online Courses at one page


dotnet tool install --global dotnet-ef --version 5
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

dotnet-aspnet-codegenerator razorpage -m Course -dc coursesContext -udl -outDir Pages/Courses --referenceScriptLibraries -sqlite


Assignment 2
dotnet ef migrations add rating
dotnet ef migrations add reviews
dotnet ef database update
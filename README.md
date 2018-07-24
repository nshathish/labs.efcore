## Labs.EfCore.Lesson1.DAL.Sql
* This project should be either a console app or asp.net core app (for the cli commands to run, it needs an entry point)
* But if you are going to use PackageManager commands then this could be a class library project

    ### Packages needed
    * Microsoft.EntityFrameworkCore
    * Microsoft.EntityFrameworkCore.Design
    * Microsoft.EntityFrameworkCore.SqlServer
    * Microsoft.EntityFrameworkCore.Tools
    * Microsoft.Extension.Configuration.Json
    * Microsoft.AspNetCore.Identity.EntityFrameworkCore

    ### Running ef CLI commands
    * if you are inside Labs.EfCore.Lesson1.DAL.Sql folder

        `dotnet ef migrations add <migration-name> -o <output-folder-relative-to-current-folder>`
    * if you are at the root of the project

        `dotnet ef migrations add <migration-name> -o <output-folder-relative-to-project> -s Labs.EfCore.Lesson1.DAL.Sql -p Labs.EfCore.Lesson1.DAL.Sql`
    * Update the database

        `dotnet ef database update`
    * if you make a mistake with migration, no option to force recreate it, but to remove the migration and add it again (will always remove the last migration)
    
        `dotnet ef migrations remove`
        
__efcore CLI commands__<br />
http://www.entityframeworktutorial.net/efcore/cli-commands-for-ef-core-migration.aspx<br />
__gitignore creation__<br />
https://www.gitignore.io/

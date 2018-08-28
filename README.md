# AN-N6A_TEC-Clase2

## Instalacion de ambiente

* [.NET Core 2.1 downloads](https://www.microsoft.com/net/download/dotnet-core/2.1)
* [.NET Core 2.1 downloads](https://code.visualstudio.com/Download)


## Commandos para creacion de proyecto WebApi

C:\
λ cd Temp\

C:\Temp
λ mkdir Clase2

C:\Temp
λ cd Clase2\

C:\Temp\Clase2
**λ dotnet new sln**
Getting ready...
The template "Solution File" was created successfully.

C:\Temp\Clase2
λ dir
 Volume in drive C is OS
 Volume Serial Number is 44F2-E369

 Directory of C:\Temp\Clase2

08/27/2018  01:39 PM    <DIR>          .
08/27/2018  01:39 PM    <DIR>          ..
08/27/2018  01:39 PM               540 Clase2.sln
               1 File(s)            540 bytes
               2 Dir(s)  66,287,546,368 bytes free

C:\Temp\Clase2

**dotnet new webapi -au none --no-https -n City.WebApi**

C:\Temp\Clase2\
λ dotnet new webapi -au none --no-https -n City.WebApi
The template "ASP.NET Core Web API" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on City.WebApi\City.WebApi.csproj...
  Restoring packages for C:\Temp\Clase2\City.WebApi\City.WebApi.csproj...
  Generating MSBuild file C:\Temp\Clase2\City.WebApi\obj\City.WebApi.csproj.nuget.g.props.
  Generating MSBuild file C:\Temp\Clase2\City.WebApi\obj\City.WebApi.csproj.nuget.g.targets.
  Restore completed in 3.24 sec for C:\Temp\Clase2\City.WebApi\City.WebApi.csproj.

Restore succeeded.

bajo un nivel

C:\Temp\Clase2
**λ dotnet sln add City.WebApi\City.WebApi.csproj**
Project `City.WebApi\City.WebApi.csproj` added to the solution.

**code .**

Commando | Resultado
------------ | -------------
dotnet new sln | Creamos solucion (solo útil para VisualStudio, cuando queremos abrir la solución y levantar los proyectos asociados)
dotnet new webapi -au none --no-https -n City.WebApi | crear un nuevo Proyecto del template WebApi (.csproj)


**(Work in progress)**

https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc?view=aspnetcore-2.1 
 
 
Download SDK https://www.microsoft.com/net/download/dotnet-core/2.1   C# for VC https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp   To test do the following: npm run test or F5 in VS Code with the "Launch Tests" debug configuration.   
From <https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp>  
 
dotnet new 
https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore21 
 
- dotnet  -au none --no-https -n name 
- code .

dotnet new sln   
From <https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln>  
  dotnet sln todo.sln add todo-app/todo-app.csproj   
From <https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln>  

      Dotnet sln list     dotnet sln todo.sln add todo-app/todo-app.csproj   
      
From <https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln>  
 
   Add EF Core   https://docs.microsoft.com/en-us/ef/core/index     dotnet add package Microsoft.EntityFrameworkCore 
dotnet add package Microsoft.EntityFrameworkCore.InMemory 

# AN-N6A_TEC-Clase2

## Instalacion de ambiente

* [.NET Core 2.1 downloads](https://www.microsoft.com/net/download/dotnet-core/2.1)
* [Visual Code](https://code.visualstudio.com/Download)

### Extensiones para Visual Code
```
Conviene utilizar el Menu de extensiones dentro del Visual Code
```
![Menu](/images/vc_menu.png)
* OmniSharp

	Escribimos C# en la barra de busqueda, es el primero en la lista.
	[+ Info](https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger.md)

	![OmniSharp](/images/omni_sharp.png)

* C# Extensions

	Escribimos C# Extensions en la barra de busqueda, es el primero en la lista
	Nos facilita la creacion de clases e interfaces
	[+ Info](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions)

### Seleccion de template para web api

[Pasos en Visual Studio 2017](docs/vs2017.md)

## Commandos para creacion de proyecto WebApi - (Visual Code)

```
C:\
λ cd Temp\

C:\Temp
λ mkdir Clase2

C:\Temp
λ cd Clase2\

C:\Temp\Clase2
```
**λ dotnet new sln**
```
Getting ready...
The template "Solution File" was created successfully.

C:\Temp\Clase2
λ dir
 Volume in drive C is OS
 Volume Serial Number is XXXX-XXXX

 Directory of C:\Temp\Clase2

08/27/2018  01:39 PM    <DIR>          .
08/27/2018  01:39 PM    <DIR>          ..
08/27/2018  01:39 PM               540 Clase2.sln
               1 File(s)            540 bytes
               2 Dir(s)  66,287,546,368 bytes free

C:\Temp\Clase2
```
**dotnet new webapi -au none --no-https -n City.WebApi**
```
C:\Temp\Clase2\
```
λ dotnet new webapi -au none --no-https -n City.WebApi
```
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
```
**λ dotnet sln add City.WebApi\City.WebApi.csproj**
```
Project `City.WebApi\City.WebApi.csproj` added to the solution.
```
**code .**


Commando | Resultado
------------ | -------------
dotnet new sln | Creamos solucion (solo útil para VisualStudio, cuando queremos abrir la solución y levantar los proyectos asociados)
dotnet new webapi -au none --no-https -n City.WebApi | crear un nuevo Proyecto del template WebApi (.csproj)
code . | levana ua=na nueva ventana del Visual Code, con el contendio de la carpeta en que nos encontramos
dotnet sln add | asociamos el proyecto creado al .sln


### Trabajando en Visual Code

![Menu](/images/vc_first.png)

```
Al ingresar si no esta existe la configuracion de ejeccución, nos pregunta para generar la misma.
El launch.json que vimos en clase.
```

**(Work in progress)**

To test do the following: npm run test or F5 in VS Code with the "Launch Tests" debug configuration.   
From <https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp>  

* [dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore21)

* [dotnet new sln](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)  

      Dotnet sln list     dotnet sln todo.sln add todo-app/todo-app.csproj   

From <https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln>  


## EF Core
   Add EF Core   https://docs.microsoft.com/en-us/ef/core/index     
```
	 dotnet add package Microsoft.EntityFrameworkCore	 
	 dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

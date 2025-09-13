# Initialization

## Solution

To declare a solution

```pwsh title="Déclaration d'une solution"
dotnet new sln -o MyLibTemplate --framework "net8.0"
```

## Projects

Projects are generally inside solution folder.

```pwsh
cd ./MyLibTemplate
```

To declare a class lib

```pwsh
dotnet new classlib -o MyLibTemplate --framework "net8.0"
dotnet sln add ./MyLibTemplate/MyLibTemplate.csproj
```

To declare a test lib related to the class lib

```pwsh
dotnet new xunit -o MyLibTemplate.Tests --framework "net8.0"
dotnet sln add ./MyLibTemplate.Tests/MyLibTemplate.Tests.csproj
dotnet add MyLibTemplate.Tests/MyLibTemplate.Tests.csproj reference MyLibTemplate/MyLibTemplate.csproj
```

To declare a console binary related to the class lib

```pwsh
dotnet new console -n MyLibTemplate.Console --framework "net8.0"
dotnet sln add ./MyLibTemplate.Console/MyLibTemplate.Console.csproj
dotnet add ./MyLibTemplate.Console/MyLibTemplate.Console.csproj reference ./MyLibTemplate/MyLibTemplate.csproj
```

To declare a MVC web app

```pwsh
dotnet new mvc -n MyLibTemplate.Web -au None --framework "net8.0"
dotnet sln add ./MyLibTemplate.Web/MyLibTemplate.Web.csproj
```
To declare an API web app

```pwsh
dotnet new webapi --use-controllers -o MyLibTemplate.Api
dotnet sln add ./MyLibTemplate.Api/MyLibTemplate.Api.csproj
```

To build and test

```pwsh
dotnet test
```

To build

```pwsh
dotnet build
```

To run console binary

```pwsh
.\MyLibTemplate.Console\bin\Debug\net8.0\MyLibTemplate.Console.exe
.\MyLibTemplate.Console\bin\Debug\net8.0\MyLibTemplate.Console.exe "Alice"
.\MyLibTemplate.Web\bin\Debug\net8.0\MyLibTemplate.Web.exe
.\MyLibTemplate.Api\bin\Debug\net8.0\MyLibTemplate.Api.exe
```
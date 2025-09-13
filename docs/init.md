# Initialization

## Solution

To declare a solution

```pwsh title="Déclaration d'une solution"
dotnet new sln -o MyLibTemplate
```

## Projects

Projects are generally inside solution folder.

```pwsh
cd ./MyLibTemplate
```

To declare a class lib

```pwsh
dotnet new classlib -o MyLibTemplate
dotnet sln add ./MyLibTemplate/MyLibTemplate.csproj
```

To declare a test lib related to the class lib

```pwsh
dotnet new xunit -o MyLibTemplate.Tests
dotnet sln add ./MyLibTemplate.Tests/MyLibTemplate.Tests.csproj
dotnet add MyLibTemplate.Tests/MyLibTemplate.Tests.csproj reference MyLibTemplate/MyLibTemplate.csproj
```

To declare a console binary related to the class lib

```pwsh
dotnet new console -n MyLibTemplate.Console
dotnet sln add ./MyLibTemplate.Console/MyLibTemplate.Console.csproj
dotnet add ./MyLibTemplate.Console/MyLibTemplate.Console.csproj reference ./MyLibTemplate/MyLibTemplate.csproj
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
.\MyLibTemplate.Console\bin\Debug\net9.0\MyLibTemplate.Console.exe
.\MyLibTemplate.Console\bin\Debug\net9.0\MyLibTemplate.Console.exe "Alice"
```
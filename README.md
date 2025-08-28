# dotnet-lib-template

Template to create a dotnet library.

## Structure

[C# unit test testing tells us...](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-xunit)

```bash
dotnet new sln -o MyLibTemplate
cd ./MyLibTemplate
dotnet new classlib -o MyLibTemplate
dotnet sln add ./MyLibTemplate/MyLibTemplate.csproj
dotnet new xunit -o MyLibTemplate.Tests
dotnet sln add ./MyLibTemplate.Tests/MyLibTemplate.Tests.csproj
dotnet add MyLibTemplate.Tests/MyLibTemplate.Tests.csproj reference MyLibTemplate/MyLibTemplate.csproj
dotnet new console -n MyLibTemplate.Console
dotnet add .\MyLibTemplate.Console\MyLibTemplate.Console.csproj reference .\MyLibTemplate\MyLibTemplate.csproj
dotnet sln add ./MyLibTemplate.Console/MyLibTemplate.Console.csproj
dotnet build
dotnet test
```
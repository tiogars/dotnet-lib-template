# Utilise l'image officielle .NET SDK pour builder
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MyLibTemplate.Api/MyLibTemplate.Api.csproj", "MyLibTemplate.Api/"]
RUN dotnet restore "MyLibTemplate.Api/MyLibTemplate.Api.csproj"
COPY . .
WORKDIR "/src/MyLibTemplate.Api"
RUN dotnet publish "MyLibTemplate.Api.csproj" -c Release -o /app/publish

# Utilise l'image officielle .NET Runtime pour exécuter
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "MyLibTemplate.Api.dll"]

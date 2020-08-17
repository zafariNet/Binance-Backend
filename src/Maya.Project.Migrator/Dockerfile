#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Maya.Project.Migrator/Maya.Project.Migrator.csproj", "src/Maya.Project.Migrator/"]
COPY ["src/Maya.Project.EntityFrameworkCore/Maya.Project.EntityFrameworkCore.csproj", "src/Maya.Project.EntityFrameworkCore/"]
COPY ["src/Maya.Project.Core/Maya.Project.Core.csproj", "src/Maya.Project.Core/"]
COPY ["src/Maya.Project.Core.Shared/Maya.Project.Core.Shared.csproj", "src/Maya.Project.Core.Shared/"]
RUN dotnet restore "src/Maya.Project.Migrator/Maya.Project.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Maya.Project.Migrator"
RUN dotnet build "Maya.Project.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Maya.Project.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Maya.Project.Migrator.dll"]

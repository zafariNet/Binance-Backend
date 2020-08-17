#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Maya.Project.Web.Host/Maya.Project.Web.Host.csproj", "src/Maya.Project.Web.Host/"]
COPY ["src/Maya.Project.Web.Core/Maya.Project.Web.Core.csproj", "src/Maya.Project.Web.Core/"]
COPY ["src/Maya.Project.Application/Maya.Project.Application.csproj", "src/Maya.Project.Application/"]
COPY ["src/Maya.Project.Application.Shared/Maya.Project.Application.Shared.csproj", "src/Maya.Project.Application.Shared/"]
COPY ["src/Maya.Project.Core.Shared/Maya.Project.Core.Shared.csproj", "src/Maya.Project.Core.Shared/"]
COPY ["src/Maya.Project.Core/Maya.Project.Core.csproj", "src/Maya.Project.Core/"]
COPY ["src/Maya.Project.EntityFrameworkCore/Maya.Project.EntityFrameworkCore.csproj", "src/Maya.Project.EntityFrameworkCore/"]
COPY ["src/Maya.Project.GraphQL/Maya.Project.GraphQL.csproj", "src/Maya.Project.GraphQL/"]
RUN dotnet restore "src/Maya.Project.Web.Host/Maya.Project.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Maya.Project.Web.Host"
RUN dotnet build "Maya.Project.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Maya.Project.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Maya.Project.Web.Host.dll"]

#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Vissoft.WebApi/Vissoft.WebApi.csproj", "Vissoft.WebApi/"]
COPY ["Vissoft.Application/Vissoft.Application.csproj", "Vissoft.Application/"]
COPY ["Vissoft.Core/Vissoft.Core.csproj", "Vissoft.Core/"]
COPY ["Vissoft.Infrastructure/Vissoft.Infrastructure.csproj", "Vissoft.Infrastructure/"]
RUN dotnet restore "./Vissoft.WebApi/./Vissoft.WebApi.csproj"
COPY . .
WORKDIR "/src/Vissoft.WebApi"
RUN dotnet build "./Vissoft.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Vissoft.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ["Vissoft.WebApi/Images", "/app/Images"]
ENTRYPOINT ["dotnet", "Vissoft.WebApi.dll"]
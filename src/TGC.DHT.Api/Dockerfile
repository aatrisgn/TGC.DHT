#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# FROM mcr.microsoft.com/dotnet/aspnet:8.0-bookworm-slim-arm64v8 AS base <-- Used for Raspberry PI
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TGC.DHT.Api.csproj", "TGC.DHT.Api/"]
RUN dotnet restore "./TGC.DHT.Api/./TGC.DHT.Api.csproj"

WORKDIR "/src/TGC.DHT.Api"
COPY . .

RUN dotnet build "./TGC.DHT.Api.csproj" -c $BUILD_CONFIGURATION  -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./TGC.DHT.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TGC.DHT.Api.dll"]
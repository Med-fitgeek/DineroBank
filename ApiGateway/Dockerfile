# Stage 0: Base runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 5000

# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the csproj files to restore
COPY ["ApiGateway/ApiGateway.csproj", "ApiGateway/"]

RUN dotnet restore "ApiGateway/ApiGateway.csproj"

# Copy the necessary source code
COPY ["ApiGateway/ ApiGateway/"]

WORKDIR /src/ApiGateway
RUN dotnet build "ApiGateway.csproj" -c $BUILD_CONFIGURATION -o /src/build

# Stage 2: Publish
FROM build AS publish
WORKDIR /src/ApiGateway
RUN dotnet publish "ApiGateway.csproj" -c $BUILD_CONFIGURATION -o /src/publish /p:UseAppHost=false

# Stage 3: Final
FROM base AS final
WORKDIR /app
COPY --from=publish /src/publish .
ENTRYPOINT ["dotnet", "ApiGateway.dll"]

# --- Build stage ---
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore
COPY ApiGateway/*.csproj ./ApiGateway/
RUN dotnet restore ApiGateway/ApiGateway.csproj

# Copy everything + build
COPY ApiGateway/. ./ApiGateway/
WORKDIR /src/ApiGateway
RUN dotnet publish -c Release -o /app/publish --no-restore

# --- Runtime stage ---
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

# Copy published output
COPY --from=build /app/publish .

# Keys are mounted by docker-compose into /app/keys/
VOLUME ["/app/keys"]

EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000

ENTRYPOINT ["dotnet", "ApiGateway.dll"]

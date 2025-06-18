# Use official .NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use official .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and project files
COPY dotnet-hello-world.sln ./
COPY hello-world-api/hello-world-api.csproj ./hello-world-api/
RUN dotnet restore ./hello-world-api/hello-world-api.csproj

# Copy the remaining files and build
COPY . .
WORKDIR /src/hello-world-api
RUN dotnet build -c Release -o /app/build

# Publish the application
RUN dotnet publish -c Release -o /app/publish

# Final image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "hello-world-api.dll"]

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /app

# Copy the project file
COPY *.sln ./
COPY ShipManagementService.App/*.csproj ./ShipManagementService.App/
COPY ShipManagementService.Core/*.csproj ./ShipManagementService.Core/
COPY ShipManagementService.Infrastructure/*.csproj ./ShipManagementService.Infrastructure/

# Restore the packages
RUN dotnet restore

# Copy everything else
COPY . ./
WORKDIR /app/ShipManagementService.App

FROM build AS publish
# Build the release
RUN dotnet publish -c Release -o out

# Build the runtime image
FROM microsoft/aspnetcore:2.0 AS runtime
WORKDIR /app

# Copy the output from the build env
COPY --from=publish /app/ShipManagementService.App/out ./

ENTRYPOINT [ "dotnet", "ShipManagementService.App.dll" ]
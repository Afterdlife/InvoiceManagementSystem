FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/InvoiceManagementSystem.Web.Host/InvoiceManagementSystem.Web.Host.csproj", "src/InvoiceManagementSystem.Web.Host/"]
COPY ["src/InvoiceManagementSystem.Web.Core/InvoiceManagementSystem.Web.Core.csproj", "src/InvoiceManagementSystem.Web.Core/"]
COPY ["src/InvoiceManagementSystem.Application/InvoiceManagementSystem.Application.csproj", "src/InvoiceManagementSystem.Application/"]
COPY ["src/InvoiceManagementSystem.Core/InvoiceManagementSystem.Core.csproj", "src/InvoiceManagementSystem.Core/"]
COPY ["src/InvoiceManagementSystem.EntityFrameworkCore/InvoiceManagementSystem.EntityFrameworkCore.csproj", "src/InvoiceManagementSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/InvoiceManagementSystem.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/InvoiceManagementSystem.Web.Host", "src/InvoiceManagementSystem.Web.Host"]
COPY ["src/InvoiceManagementSystem.Web.Core", "src/InvoiceManagementSystem.Web.Core"]
COPY ["src/InvoiceManagementSystem.Application", "src/InvoiceManagementSystem.Application"]
COPY ["src/InvoiceManagementSystem.Core", "src/InvoiceManagementSystem.Core"]
COPY ["src/InvoiceManagementSystem.EntityFrameworkCore", "src/InvoiceManagementSystem.EntityFrameworkCore"]
WORKDIR "/src/src/InvoiceManagementSystem.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "InvoiceManagementSystem.Web.Host.dll"]

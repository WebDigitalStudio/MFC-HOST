FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Mf.Web.Host/Mf.Web.Host.csproj", "src/Mf.Web.Host/"]
COPY ["src/Mf.Web.Core/Mf.Web.Core.csproj", "src/Mf.Web.Core/"]
COPY ["src/Mf.Application/Mf.Application.csproj", "src/Mf.Application/"]
COPY ["src/Mf.Core/Mf.Core.csproj", "src/Mf.Core/"]
COPY ["src/Mf.EntityFrameworkCore/Mf.EntityFrameworkCore.csproj", "src/Mf.EntityFrameworkCore/"]
WORKDIR "/src/src/Mf.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Mf.Web.Host", "src/Mf.Web.Host"]
COPY ["src/Mf.Web.Core", "src/Mf.Web.Core"]
COPY ["src/Mf.Application", "src/Mf.Application"]
COPY ["src/Mf.Core", "src/Mf.Core"]
COPY ["src/Mf.EntityFrameworkCore", "src/Mf.EntityFrameworkCore"]
WORKDIR "/src/src/Mf.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Mf.Web.Host.dll"]

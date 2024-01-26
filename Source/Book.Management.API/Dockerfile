FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Source/Book.Management.API/Book.Management.API.csproj", "Source/Book.Management.API/"]
COPY ["Source/Book.Management.Application/Book.Management.Application.csproj", "Source/Book.Management.Application/"]
COPY ["Source/Book.Management.Infrastructure/Book.Management.Infrastructure.csproj", "Source/Book.Management.Infrastructure/"]
COPY ["Source/Book.Management.Domain/Book.Management.Domain.csproj", "Source/Book.Management.Domain/"]
RUN dotnet restore "Source/Book.Management.API/Book.Management.API.csproj"
COPY . .
WORKDIR "/src/Source/Book.Management.API"
RUN dotnet build "Book.Management.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Book.Management.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Book.Management.API.dll"]

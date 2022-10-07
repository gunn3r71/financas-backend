FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Financas.Api/Financas.Api.csproj", "Financas.Api/"]
RUN dotnet restore "src/Financas.Api/Financas.Api.csproj"
COPY . .
WORKDIR "/src/Financas.Api"
RUN dotnet build "Financas.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Financas.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Financas.Api.dll"]

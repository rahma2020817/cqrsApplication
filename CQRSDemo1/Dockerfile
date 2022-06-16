FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CQRSDemo1/CQRSDemo1.csproj", "CQRSDemo1/"]
RUN dotnet restore "CQRSDemo1/CQRSDemo1.csproj"
COPY . .
WORKDIR "/src/CQRSDemo1"
RUN dotnet build "CQRSDemo1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CQRSDemo1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CQRSDemo1.dll"]

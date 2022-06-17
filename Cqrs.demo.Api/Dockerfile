FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Cqrs.demo.Api/Cqrs.demo.Api.csproj", "Cqrs.demo.Api/"]
RUN dotnet restore "Cqrs.demo.Api/Cqrs.demo.Api.csproj"
COPY . .
WORKDIR "/src/Cqrs.demo.Api"
RUN dotnet build "Cqrs.demo.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cqrs.demo.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cqrs.demo.Api.dll"]

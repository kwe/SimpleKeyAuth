FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SimpleKeyAuth/SimpleKeyAuth.csproj", "SimpleKeyAuth/"]
RUN dotnet restore "SimpleKeyAuth/SimpleKeyAuth.csproj"
COPY . .
WORKDIR "/src/SimpleKeyAuth"
RUN dotnet build "SimpleKeyAuth.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleKeyAuth.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleKeyAuth.dll"]

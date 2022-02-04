FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PublicCNPJ.API/PublicCNPJ.API.csproj", "PublicCNPJ.API/"]
RUN dotnet restore "PublicCNPJ.API/PublicCNPJ.API.csproj"
COPY . .
WORKDIR "/src/PublicCNPJ.API"
RUN dotnet build "PublicCNPJ.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PublicCNPJ.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet PublicCNPJ.API.dll
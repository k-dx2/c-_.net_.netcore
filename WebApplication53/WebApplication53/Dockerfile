#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["WebApplication53/WebApplication53.csproj", "WebApplication53/"]
RUN dotnet restore "WebApplication53/WebApplication53.csproj"
COPY . .
WORKDIR "/src/WebApplication53"
RUN dotnet build "WebApplication53.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication53.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication53.dll"]
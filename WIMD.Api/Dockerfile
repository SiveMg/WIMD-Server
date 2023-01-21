#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WIMD.Api/WIMD.Api.csproj", "WIMD.Api/"]
RUN dotnet restore "WIMD.Api/WIMD.Api.csproj"
COPY . .
WORKDIR "/src/WIMD.Api"
RUN dotnet build "WIMD.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WIMD.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WIMD.Api.dll"]
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["LoadBalancerReact/LoadBalancerReact.csproj", "LoadBalancerReact/"]
RUN dotnet restore "LoadBalancerReact/LoadBalancerReact.csproj"
COPY . .
WORKDIR "/src/LoadBalancerReact"
RUN dotnet build "LoadBalancerReact.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LoadBalancerReact.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LoadBalancerReact.dll"]
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
#COPY ["ForDocker/ForDocker.csproj", "ForDocker/"]
COPY ForDocker.csproj ForDocker.csproj
#RUN dotnet restore "ForDocker/ForDocker.csproj"
RUN dotnet restore "ForDocker.csproj"
COPY . .
#WORKDIR "/src/ForDocker"
WORKDIR "/src"
RUN dotnet build "ForDocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ForDocker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ForDocker.dll"]
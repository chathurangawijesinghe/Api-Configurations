#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["Kaddis.Framework.Clients.TestBlazorClient/Kaddis.Framework.Clients.TestBlazorClient.csproj", "Kaddis.Framework.Clients.TestBlazorClient/"]
RUN dotnet restore "Kaddis.Framework.Clients.TestBlazorClient/Kaddis.Framework.Clients.TestBlazorClient.csproj"
COPY . .
WORKDIR "/src/Kaddis.Framework.Clients.TestBlazorClient"
RUN dotnet build "Kaddis.Framework.Clients.TestBlazorClient.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kaddis.Framework.Clients.TestBlazorClient.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kaddis.Framework.Clients.TestBlazorClient.dll"]
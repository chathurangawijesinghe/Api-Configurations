#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["02 APIs/Kaddis.Framework.APIs.Test/Kaddis.Framework.APIs.Test.csproj", "02 APIs/Kaddis.Framework.APIs.Test/"]
RUN dotnet restore "02 APIs/Kaddis.Framework.APIs.Test/Kaddis.Framework.APIs.Test.csproj"
COPY . .
WORKDIR "/src/02 APIs/Kaddis.Framework.APIs.Test"
RUN dotnet build "Kaddis.Framework.APIs.Test.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kaddis.Framework.APIs.Test.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kaddis.Framework.APIs.Test.dll"]
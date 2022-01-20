FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app 
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebApi.csproj", "./"] 
COPY . .
WORKDIR "/src/."
RUN dotnet build "WebApi.csproj" -c Release -o /app/build

FROM build AS publish 
RUN dotnet publish  "WebApi.csproj" -c Release -o /app/publish 

FROM base AS final
WORKDIR /app
# ENV ASPNETCORE_URLS=http//*:5000
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet","WebApi.dll" ]
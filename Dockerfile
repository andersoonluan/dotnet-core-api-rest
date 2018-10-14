FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY dotnet-core-api-rest.csproj dotnet-core-api-rest/
RUN dotnet restore dotnet-core-api-rest/dotnet-core-api-rest.csproj

WORKDIR /src/dotnet-core-api-rest
COPY . .
RUN dotnet build dotnet-core-api-rest.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish dotnet-core-api-rest.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dotnet-core-api-rest.dll"]

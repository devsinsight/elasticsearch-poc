FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY Elasticsearch.API/Elasticsearch.API.csproj Elasticsearch.API/
RUN dotnet restore Elasticsearch.API/Elasticsearch.API.csproj
COPY . .
WORKDIR /src/Elasticsearch.API
RUN dotnet build Elasticsearch.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Elasticsearch.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Elasticsearch.API.dll"]

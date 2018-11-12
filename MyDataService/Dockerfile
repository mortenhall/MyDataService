FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MyDataService/MyDataService.csproj", "MyDataService/"]
RUN dotnet restore "MyDataService/MyDataService.csproj"
COPY . .
WORKDIR "/src/MyDataService"
RUN dotnet build "MyDataService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MyDataService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyDataService.dll"]
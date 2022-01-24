FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Reverse_String/Reverse_String.csproj", "Reverse_String/"]
RUN dotnet restore "Reverse_String/Reverse_String.csproj"
COPY . .
WORKDIR "/src/Reverse_String"
RUN dotnet build "Reverse_String.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reverse_String.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reverse_String.dll"]

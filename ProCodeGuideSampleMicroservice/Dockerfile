#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ProCodeGuideSampleMicroservice/ProCodeGuideSampleMicroservice.csproj", "ProCodeGuideSampleMicroservice/"]
RUN dotnet restore "ProCodeGuideSampleMicroservice/ProCodeGuideSampleMicroservice.csproj"
COPY . .
WORKDIR "/src/ProCodeGuideSampleMicroservice"
RUN dotnet build "ProCodeGuideSampleMicroservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProCodeGuideSampleMicroservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProCodeGuideSampleMicroservice.dll"]
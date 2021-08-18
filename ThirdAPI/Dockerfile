FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
WORKDIR /app
COPY *.sln .
COPY /ThirdAPI/*.csproj ./ThirdAPI/
COPY /ThirdAPI/*.config ./ThirdAPI/
COPY /ThirdAPI/. ./ThirdAPI/
RUN nuget restore
WORKDIR /app/ThirdAPI
RUN msbuild /p:Configuration=Release -r:False

FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019 AS runtime
WORKDIR /inetpub/wwwroot
COPY --from=build /app/ThirdAPI/. ./

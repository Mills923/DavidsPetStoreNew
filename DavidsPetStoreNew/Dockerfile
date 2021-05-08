FROM mcr.microsoft.com/dotnet/core/aspnet:5.0
FROM mcr.microsoft.com/dotnet/core/sdk:5.0

COPY /bin/Release/netcoreapp5.0/publish/ DavidsPetStoreNew/

ENV ASPNETCORE_ENVIRONMENT Production

EXPOSE 5000
WORKDIR /DavidsPetStoreNew
ENTRYPOINT ["dotnet", "DavidsPetStoreNew.dll", "--urls=http://0.0.0.0:5000"]

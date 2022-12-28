FROM mcr.microsoft.com/dotnet/runtime:6.0

WORKDIR /FibCalc

COPY FibCalc/bin/Release/net6.0/publish .

ENTRYPOINT ["dotnet","FibCalc.dll"]
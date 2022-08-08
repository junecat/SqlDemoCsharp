FROM ubuntu:latest
RUN apt-get update
RUN apt-get install -y wget
RUN wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN rm packages-microsoft-prod.deb
RUN apt-get update
RUN apt-get install -y apt-transport-https
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
RUN apt-get install -y dotnet-sdk-6.0
# dotnet sdk is installed!

COPY ./SqlDemoCsharp /App/SqlDemoCsharp
WORKDIR /App/SqlDemoCsharp
RUN dotnet publish -c release
CMD mkdir /App/publish-output/
CMD cp -r /App/SqlDemoCsharp/bin/Release/net6.0/publish/* /App/publish-output
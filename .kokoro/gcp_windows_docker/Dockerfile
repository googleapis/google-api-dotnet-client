# We use the .NET 6 Windows Server Core 2019 official image as starter.
# Kokoro supports up to Windows Server 2019 only.
# We build in .NET 6
FROM mcr.microsoft.com/dotnet/sdk:6.0-windowsservercore-ltsc2019

# Install extra .NET target frameworks that we test in.
# https://github.com/dotnet/dotnet-docker/blob/main/documentation/scenarios/installing-dotnet.md#installing-from-dotnet-install-script
# Setup Powershell
RUN powershell -Command $ErrorActionPreference = 'Stop';
RUN powershell -Command $ProgressPreference = 'SilentlyContinue';
# Download dotnet-install.ps1
RUN powershell -Command Invoke-WebRequest -UseBasicParsing -Uri https://dot.net/v1/dotnet-install.ps1 -OutFile dotnet-install.ps1;
# Install .NET Core 3.1
RUN powershell -Command ./dotnet-install.ps1 -InstallDir '/Program Files/dotnet' -Channel 3.1;
# Delete dotnet-install.ps1
RUN powershell -Command Remove-Item -Force dotnet-install.ps1;

# Install Chocolatey
ENV ChocolateyUseWindowsCompression false
RUN powershell -NoProfile -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"

# Install Chocolatey packages
RUN choco install git.install -y

# Default to PowerShell.
# This is what Kokoro owned Docker images do. We'll do the same at least for now.
CMD ["powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]

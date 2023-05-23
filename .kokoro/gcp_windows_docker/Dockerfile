# We use the .NET 6 Windows Server Core 2019 official image as starter.
# Kokoro supports up to Windows Server 2019 only.
# We build in .NET 6
FROM mcr.microsoft.com/dotnet/sdk:6.0-windowsservercore-ltsc2019

# Setup Powershell
RUN powershell -Command $ErrorActionPreference = 'Stop';
RUN powershell -Command $ProgressPreference = 'SilentlyContinue';

# Install Chocolatey
ENV ChocolateyUseWindowsCompression false
RUN powershell -NoProfile -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"

# Install .NET Core 3.1
RUN choco install -y --no-progress dotnetcore-3.1-sdk

# Install Git
RUN choco install -y --no-progress git

# Default to PowerShell.
# This is what Kokoro owned Docker images do. We'll do the same at least for now.
CMD ["powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]

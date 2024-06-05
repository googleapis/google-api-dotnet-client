# We use the .NET Framework 4.8 Windows Server Core 2019 official image as starter.
# Chocolatey requires .NET Framework 4.8, which in turn requires a reboot after install.
# Chocolatey recommends starting with an image that already has .NET Framework 4.8 installed.
# Kokoro supports up to Windows Server 2019 only.
# We build in .NET 6 so we need to install .NET 6 after.
FROM mcr.microsoft.com/dotnet/framework/runtime:4.8-windowsservercore-ltsc2019

# Setup Powershell
RUN powershell -Command $ErrorActionPreference = 'Stop';
RUN powershell -Command $ProgressPreference = 'SilentlyContinue';

# Install Chocolatey
ENV ChocolateyUseWindowsCompression false
RUN powershell -NoProfile -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"

# Install .NET Core 3.0 which we need for Google.Apis.Auth.AspNetCore3
RUN choco install -y --no-progress dotnetcore-3.0-sdk

# Install .NET 6
RUN choco install -y --no-progress dotnet-6.0-sdk

# Install Git
RUN choco install -y --no-progress git

# Default to PowerShell.
# This is what Kokoro owned Docker images do. We'll do the same at least for now.
CMD ["powershell.exe", "-NoLogo", "-ExecutionPolicy", "Bypass"]

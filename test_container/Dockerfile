# This Dockerfile describes the test environment for the libraries, as close as
# possible to what is run on travis.
FROM mono:4.4

# Install dependencies for .NET Core, and to run tests.
# Install .NET Core dependencies
RUN apt-get update \
    && apt-get install -y --no-install-recommends \
        libc6 \
        libcurl3 \
        libgcc1 \
        liblttng-ust0 \
        libssl1.0.0 \
        libstdc++6 \
        libtinfo5 \
        libuuid1 \
        zlib1g \
        ca-certificates \
        curl \
        git \
    && apt-get clean

# Install the .NET package.
ENV DOTNET_CORE_VERSION 1.0.0
RUN curl -SL https://dotnetcli.blob.core.windows.net/dotnet/preview/Binaries/${DOTNET_CORE_VERSION}/dotnet-debian-x64.${DOTNET_CORE_VERSION}.tar.gz --output dotnet.tar.gz \
    && mkdir -p /usr/share/dotnet \
    && tar -zxf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz \
    && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet

# Add tools.
RUN mkdir -p /tools/
ADD ./run_tests.sh /tools/
RUN curl -sL https://nuget.org/nuget.exe --output /tools/nuget.exe

# Run the tests.
ENTRYPOINT ["/tools/run_tests.sh"]

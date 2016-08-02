# This Dockerfile describes the test environment for the libraries, as close as
# possible to what is run on travis.
FROM mono:4.4

# Install dependencies.
RUN apt-get update \
    && apt-get install -y --no-install-recommends \
      git \
    && apt-get clean

# Add tools.
RUN mkdir -p /tools/
ADD ./nuget.exe /tools/
ADD ./run_tests.sh /tools/

# Run the tests.
ENTRYPOINT ["/tools/run_tests.sh"]

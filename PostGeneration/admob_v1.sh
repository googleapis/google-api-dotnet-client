#!/bin/bash

CODE_GENERATION_DIR="$1"

# GenerateMediationReport and GenerateNetworkReport are actually streaming APIs, so
# the response type is effectively an array.
sed -i 's/AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateMediationReportResponse>/AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateMediationReportResponse[]>/g' \
  "$CODE_GENERATION_DIR"/Google.Apis.AdMob.v1/Google.Apis.AdMob.v1.cs
sed -i 's/AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateNetworkReportResponse>/AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateNetworkReportResponse[]>/g' \
  "$CODE_GENERATION_DIR"/Google.Apis.AdMob.v1/Google.Apis.AdMob.v1.cs  
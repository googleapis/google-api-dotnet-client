#!/bin/bash

# GenerateMediationReport and GenerateNetworkReport are actually streaming APIs, so
# the response type is effectively an array.
sed -i 's/AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateMediationReportResponse>/AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateMediationReportResponse[]>/g' \
  Src/Generated/Google.Apis.AdMob.v1/Google.Apis.AdMob.v1.cs
sed -i 's/AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateNetworkReportResponse>/AdMobBaseServiceRequest<Google.Apis.AdMob.v1.Data.GenerateNetworkReportResponse[]>/g' \
  Src/Generated/Google.Apis.AdMob.v1/Google.Apis.AdMob.v1.cs  
using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

using Google.Apis;
using Google.Apis.Tools.CodeGen;

using Google.Apis.Discovery;

namespace Google.Apis.Samples.ComandLineServiceGenerator
{
	class MainClass
	{
		public static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MainClass));
		#region AdSense Api
		public const string AdSenseV0_3_Json = @"
{
 ""kind"": ""discovery#describeItem"",
 ""name"": ""adsense"",
 ""version"": ""v1beta3"",
 ""description"": ""AdSense Management API"",
 ""restBasePath"": ""/adsense/v1beta3/"",
 ""rpcPath"": ""/rpc"",
 ""schemas"": {
  ""AdClients"": {
   ""id"": ""AdClients"",
   ""type"": ""object"",
   ""properties"": {
    ""etag"": {
     ""type"": ""string"",
     ""description"": ""ETag of this response for caching purposes.""
    },
    ""items"": {
     ""type"": ""array"",
     ""description"": ""The ad clients returned in this list response."",
     ""items"": {
      ""type"": ""object"",
      ""properties"": {
       ""id"": {
        ""type"": ""string"",
        ""description"": ""Unique identifier of this ad client.""
       },
       ""kind"": {
        ""type"": ""string"",
        ""description"": ""Kind of resource this is, in this case adsense#adClient."",
        ""default"": ""adsense#adClient""
       },
       ""name"": {
        ""type"": ""string"",
        ""description"": ""Name of this ad client.""
       },
       ""supportsReporting"": {
        ""type"": ""boolean"",
        ""description"": ""Whether this ad client supports being reported on.""
       }
      }
     }
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of list this is, in this case adsense#adClients."",
     ""default"": ""adsense#adClients""
    }
   }
  },
  ""AdUnits"": {
   ""id"": ""AdUnits"",
   ""type"": ""object"",
   ""properties"": {
    ""etag"": {
     ""type"": ""string"",
     ""description"": ""ETag of this response for caching purposes.""
    },
    ""items"": {
     ""type"": ""array"",
     ""description"": ""The ad units returned in this list response."",
     ""items"": {
      ""type"": ""object"",
      ""properties"": {
       ""code"": {
        ""type"": ""string"",
        ""description"": ""Code of this ad unit, not necessarily unique across ad clients.""
       },
       ""id"": {
        ""type"": ""string"",
        ""description"": ""Unique identifier of this ad unit. This should be considered an opaque identifier; it is not safe to rely on it being in any particular format.""
       },
       ""kind"": {
        ""type"": ""string"",
        ""description"": ""Kind of resource this is, in this case adsense#adUnit."",
        ""default"": ""adsense#adUnit""
       },
       ""name"": {
        ""type"": ""string"",
        ""description"": ""Name of this ad unit.""
       }
      }
     }
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of list this is, in this case adsense#adUnits."",
     ""default"": ""adsense#adUnits""
    }
   }
  },
  ""AdsenseReportsGenerateRequest"": {
   ""id"": ""AdsenseReportsGenerateRequest"",
   ""type"": ""object"",
   ""properties"": {
    ""currency"": {
     ""type"": ""string"",
     ""description"": ""Optional currency to use when reporting on monetary metrics. Defaults to the account's currency if not set.""
    },
    ""date_range"": {
     ""type"": ""object"",
     ""description"": ""The date range to report on."",
     ""properties"": {
      ""end_date"": {
       ""type"": ""string"",
       ""description"": ""End of the date range to report on in \""YYYY-MM-DD\"" format, inclusive.""
      },
      ""start_date"": {
       ""type"": ""string"",
       ""description"": ""Start of the date range to report on in \""YYYY-MM-DD\"" format, inclusive.""
      }
     }
    },
    ""dimensions"": {
     ""type"": ""array"",
     ""description"": ""Dimensions to base the report on, specifying the groupings to query from the items in the scope.  The dimensions to include in the report. Each dimension is a column on the left of the report, used to group the rows. Dimensions are columns with textual data.  Normally at least one dimension is specified, however it is possible to generate reports without dimensions, for example to find out the totals and averages of a particular query."",
     ""items"": {
      ""type"": ""string""
     }
    },
    ""locale"": {
     ""type"": ""string"",
     ""description"": ""Optional locale to use for translating report output to a local language. Defaults to \""en_US\"" if not specified.""
    },
    ""metrics"": {
     ""type"": ""array"",
     ""description"": ""Metrics are the numeric columns to retrieve from the items in the scope. The values for each selected metric are accumulated across the selected dimensions."",
     ""items"": {
      ""type"": ""string""
     }
    },
    ""pagination"": {
     ""type"": ""object"",
     ""description"": ""Optionally specifies how to paginate the rows of the report output. If not defined, all rows of the report will be retrieved up to the available limit of 10,000 rows. If more rows are present in the report, multiple calls must be made, setting start_row to 10000 in the second call and so on."",
     ""properties"": {
      ""row_count"": {
       ""type"": ""integer"",
       ""description"": ""Number of rows to return in the report, starting from start_row, or -1 to retrieve all rows from start_row on. No more than the limit of 10,000 rows will be returned, even if this value is set higher. Defaults to -1, i.e. retrieving all rows from start_row on.""
      },
      ""start_row"": {
       ""type"": ""integer"",
       ""description"": ""Row in the report to start retrieving output from, beginning at 0. Defaults to 0, i.e. starting at the first row in the report.""
      }
     }
    },
    ""scope"": {
     ""type"": ""object"",
     ""description"": ""The scope of the report is the items this report will scan to collect data to report on. It is either a list of ad client ids, ad unit ids, custom channel ids or URL channel ids identifying the objects to be part of the scope. Only one list may be specified. The specified list may contain any amount of items.  The type of the scope dictates what dimensions can be used in the report. If ad unit or channel dimensions are used, the corresponding type of scope must also be used. For example, if AD_UNIT_CODE is used as a dimension ad_unit_ids must be specified as the scope, with no other list given in the scope."",
     ""properties"": {
      ""ad_client_ids"": {
       ""type"": ""array"",
       ""description"": ""Specifies a scope over a set of ad clients. Each item in this list is an ad client id, uniquely identifying an ad client.  If this list is specified, none of the other lists in the scope may be specified."",
       ""items"": {
        ""type"": ""string""
       }
      },
      ""ad_unit_ids"": {
       ""type"": ""array"",
       ""description"": ""Specifies a scope over a set of ad units. Each item in this list is an ad unit id, uniquely identifying an ad unit.  If this list is specified, none of the other lists in the scope may be specified.  This list must be specified if ad unit dimensions are used, for example AD_UNIT_CODE."",
       ""items"": {
        ""type"": ""string""
       }
      },
      ""custom_channel_ids"": {
       ""type"": ""array"",
       ""description"": ""Specifies a scope over a set of custom channels. Each item in this list is a custom channel id, uniquely identifying a custom channel.  If this list is specified, none of the other lists in the scope may be specified.  This list must be specified if custom channel dimensions are used, for example CUSTOM_CHANNEL_CODE."",
       ""items"": {
        ""type"": ""string""
       }
      },
      ""url_channel_ids"": {
       ""type"": ""array"",
       ""description"": ""Specifies a scope over a set of URL channels. Each item in this list is a URL channel id, uniquely identifying a URL channel.  If this list is specified, none of the other lists in the scope may be specified.  This list must be specified if URL channel dimensions are used, for example URL_CHANNEL_PATTERN."",
       ""items"": {
        ""type"": ""string""
       }
      }
     }
    },
    ""sorts"": {
     ""type"": ""array"",
     ""description"": ""Columns to sort the report result on. The report is sorted by the first specified column, then by the second (if any), and so on. Sort columns can be either dimensions or metrics. The rows of the table can be in any order if no sort columns are specified."",
     ""items"": {
      ""type"": ""object"",
      ""properties"": {
       ""column"": {
        ""type"": ""string"",
        ""description"": ""The name of the dimension or metric to sort on.""
       },
       ""descending"": {
        ""type"": ""boolean"",
        ""description"": ""If true, sort this column in descending order. If not specified the column is sorted in ascending order.""
       }
      }
     }
    }
   }
  },
  ""AdsenseReportsGenerateResponse"": {
   ""id"": ""AdsenseReportsGenerateResponse"",
   ""type"": ""object"",
   ""properties"": {
    ""headers"": {
     ""type"": ""array"",
     ""description"": ""The header names of the columns requested in the report. This is a list of names; one for each dimension in the request, followed by one for each metric in the request."",
     ""items"": {
      ""type"": ""string""
     }
    },
    ""rows"": {
     ""type"": ""array"",
     ""description"": ""The output rows of the report. Each row is a list of cells; one for each dimension in the request, followed by one for each metric in the request. The dimension cells contain strings, and the metric cells contain numbers."",
     ""items"": {
      ""type"": ""array"",
      ""items"": {
       ""type"": ""string""
      }
     }
    }
   }
  },
  ""CustomChannels"": {
   ""id"": ""CustomChannels"",
   ""type"": ""object"",
   ""properties"": {
    ""etag"": {
     ""type"": ""string"",
     ""description"": ""ETag of this response for caching purposes.""
    },
    ""items"": {
     ""type"": ""array"",
     ""description"": ""The custom channels returned in this list response."",
     ""items"": {
      ""type"": ""object"",
      ""properties"": {
       ""code"": {
        ""type"": ""string"",
        ""description"": ""Code of this custom channel, not necessarily unique across ad clients.""
       },
       ""id"": {
        ""type"": ""string"",
        ""description"": ""Unique identifier of this custom channel. This should be considered an opaque identifier; it is not safe to rely on it being in any particular format.""
       },
       ""kind"": {
        ""type"": ""string"",
        ""description"": ""Kind of resource this is, in this case adsense#customChannel."",
        ""default"": ""adsense#customChannel""
       },
       ""name"": {
        ""type"": ""string"",
        ""description"": ""Name of this custom channel.""
       }
      }
     }
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of list this is, in this case adsense#customChannels."",
     ""default"": ""adsense#customChannels""
    }
   }
  },
  ""UrlChannels"": {
   ""id"": ""UrlChannels"",
   ""type"": ""object"",
   ""properties"": {
    ""etag"": {
     ""type"": ""string"",
     ""description"": ""ETag of this response for caching purposes.""
    },
    ""items"": {
     ""type"": ""array"",
     ""description"": ""The URL channels returned in this list response."",
     ""items"": {
      ""type"": ""object"",
      ""properties"": {
       ""id"": {
        ""type"": ""string"",
        ""description"": ""Unique identifier of this URL channel. This should be considered an opaque identifier; it is not safe to rely on it being in any particular format.""
       },
       ""kind"": {
        ""type"": ""string"",
        ""description"": ""Kind of resource this is, in this case adsense#urlChannel."",
        ""default"": ""adsense#urlChannel""
       },
       ""urlPattern"": {
        ""type"": ""string"",
        ""description"": ""URL Pattern of this URL channel. Does not include \""http://\"" or \""https://\"". Example: www.example.com/home""
       }
      }
     }
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of list this is, in this case adsense#urlChannels."",
     ""default"": ""adsense#urlChannels""
    }
   }
  }
 },
 ""resources"": {
  ""adclients"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""ad_clients"",
     ""rpcMethod"": ""adsense.adclients.list"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all ad clients in this AdSense account."",
     ""response"": {
      ""$ref"": ""AdClients""
     }
    }
   }
  },
  ""adunits"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""ad_clients/{ad_client_id}/ad_units"",
     ""rpcMethod"": ""adsense.adunits.list"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all ad units in this AdSense account."",
     ""parameters"": {
      ""ad_client_id"": {
       ""restParameterType"": ""path"",
       ""required"": true,
       ""description"": ""Ad client for which to list ad units."",
       ""type"": ""string""
      }
     },
     ""parameterOrder"": [
      ""ad_client_id""
     ],
     ""response"": {
      ""$ref"": ""AdUnits""
     }
    }
   }
  },
  ""customchannels"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""ad_clients/{ad_client_id}/custom_channels"",
     ""rpcMethod"": ""adsense.customchannels.list"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all custom channels in this AdSense account."",
     ""parameters"": {
      ""ad_client_id"": {
       ""restParameterType"": ""path"",
       ""required"": true,
       ""description"": ""Ad client for which to list custom channels."",
       ""type"": ""string""
      }
     },
     ""parameterOrder"": [
      ""ad_client_id""
     ],
     ""response"": {
      ""$ref"": ""CustomChannels""
     }
    }
   }
  },
  ""reports"": {
   ""methods"": {
    ""generate"": {
     ""restPath"": ""reports/generate"",
     ""rpcMethod"": ""adsense.reports.generate"",
     ""httpMethod"": ""POST"",
     ""description"": ""Generate an AdSense report based on the JSON-formatted report request sent in the HTML body. Returns the result as JSON; to retrieve output in CSV format specify \""alt\u003dcsv\"" as a query parameter."",
     ""request"": {
      ""$ref"": ""AdsenseReportsGenerateRequest""
     },
     ""response"": {
      ""$ref"": ""AdsenseReportsGenerateResponse""
     }
    }
   }
  },
  ""urlchannels"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""ad_clients/{ad_client_id}/url_channels"",
     ""rpcMethod"": ""adsense.urlchannels.list"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all URL channels in this AdSense account."",
     ""parameters"": {
      ""ad_client_id"": {
       ""restParameterType"": ""path"",
       ""required"": true,
       ""description"": ""Ad client for which to list URL channels."",
       ""type"": ""string""
      }
     },
     ""parameterOrder"": [
      ""ad_client_id""
     ],
     ""response"": {
      ""$ref"": ""UrlChannels""
     }
    }
   }
  }
 }
}
";
		#endregion
		
		#region AdSense Api V1A4
		public const string AdSenseV1A4Json = @"
		{
 ""kind"": ""discovery#describeItem"",
 ""name"": ""adsense"",
 ""version"": ""v1alpha4"",
 ""description"": ""AdSense Management API"",
 ""restBasePath"": ""/adsense/v1alpha4/"",
 ""rpcPath"": ""/rpc"",
 ""schemas"": {
  ""AdClient"": {
   ""id"": ""AdClient"",
   ""type"": ""object"",
   ""properties"": {
    ""id"": {
     ""type"": ""string"",
     ""description"": ""Unique identifier of this ad client.""
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of resource this is, in this case adsense#adClient."",
     ""default"": ""adsense#adClient""
    },
    ""name"": {
     ""type"": ""string"",
     ""description"": ""Name of this ad client.""
    },
    ""supportsReporting"": {
     ""type"": ""boolean"",
     ""description"": ""Whether this ad client supports being reported on.""
    }
   }
  },
  ""AdClients"": {
   ""id"": ""AdClients"",
   ""type"": ""object"",
   ""properties"": {
    ""etag"": {
     ""type"": ""string"",
     ""description"": ""ETag of this response for caching purposes.""
    },
    ""items"": {
     ""type"": ""array"",
     ""description"": ""The ad clients returned in this list response."",
     ""items"": {
      ""$ref"": ""AdClient""
     }
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of list this is, in this case adsense#adClients."",
     ""default"": ""adsense#adClients""
    }
   }
  },
  ""AdUnit"": {
   ""id"": ""AdUnit"",
   ""type"": ""object"",
   ""properties"": {
    ""code"": {
     ""type"": ""string"",
     ""description"": ""Code of this ad unit, not necessarily unique across ad clients.""
    },
    ""id"": {
     ""type"": ""string"",
     ""description"": ""Unique identifier of this ad unit. This should be considered an opaque identifier; it is not safe to rely on it being in any particular format.""
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of resource this is, in this case adsense#adUnit."",
     ""default"": ""adsense#adUnit""
    },
    ""name"": {
     ""type"": ""string"",
     ""description"": ""Name of this ad unit.""
    }
   }
  },
  ""AdUnits"": {
   ""id"": ""AdUnits"",
   ""type"": ""object"",
   ""properties"": {
    ""etag"": {
     ""type"": ""string"",
     ""description"": ""ETag of this response for caching purposes.""
    },
    ""items"": {
     ""type"": ""array"",
     ""description"": ""The ad units returned in this list response."",
     ""items"": {
      ""$ref"": ""AdUnit""
     }
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of list this is, in this case adsense#adUnits."",
     ""default"": ""adsense#adUnits""
    }
   }
  },
  ""AdsenseReportsGenerateRequest"": {
   ""id"": ""AdsenseReportsGenerateRequest"",
   ""type"": ""object"",
   ""properties"": {
    ""currency"": {
     ""type"": ""string"",
     ""description"": ""Optional currency to use when reporting on monetary metrics. Defaults to the account's currency if not set.""
    },
    ""date_range"": {
     ""type"": ""object"",
     ""description"": ""The date range to report on."",
     ""properties"": {
      ""end_date"": {
       ""type"": ""string"",
       ""description"": ""End of the date range to report on in \""YYYY-MM-DD\"" format, inclusive.""
      },
      ""start_date"": {
       ""type"": ""string"",
       ""description"": ""Start of the date range to report on in \""YYYY-MM-DD\"" format, inclusive.""
      }
     }
    },
    ""dimensions"": {
     ""type"": ""array"",
     ""description"": ""Dimensions to base the report on, specifying the groupings to query from the items in the scope.  The dimensions to include in the report. Each dimension is a column on the left of the report, used to group the rows. Dimensions are columns with textual data.  Normally at least one dimension is specified, however it is possible to generate reports without dimensions, for example to find out the totals and averages of a particular query.  Possible dimension names:  DATE WEEK MONTH HOUR AD_CLIENT_ID AD_CLIENT_NAME PRODUCT_CODE PRODUCT_NAME AD_UNIT_ID AD_UNIT_CODE AD_UNIT_NAME AD_UNIT_SIZE_CODE AD_UNIT_SIZE_NAME CUSTOM_CHANNEL_ID CUSTOM_CHANNEL_CODE CUSTOM_CHANNEL_NAME URL_CHANNEL_ID URL_CHANNEL_NAME AD_FORMAT_CODE AD_FORMAT_NAME BRANDING_TYPE_CODE BRANDING_TYPE_NAME BUYER_NETWORK_ID BUYER_NETWORK_NAME BID_TYPE_CODE BID_TYPE_NAME DOMAIN_NAME COUNTRY_CODE COUNTRY_NAME TARGETING_TYPE_CODE TARGETING_TYPE_NAME"",
     ""items"": {
      ""type"": ""string""
     }
    },
    ""locale"": {
     ""type"": ""string"",
     ""description"": ""Optional locale to use for translating report output to a local language. Defaults to \""en_US\"" if not specified.""
    },
    ""metrics"": {
     ""type"": ""array"",
     ""description"": ""Metrics are the numeric columns to retrieve from the items in the scope. The values for each selected metric are accumulated across the selected dimensions.  Possible metric names:  PAGE_VIEWS PAGE_VIEWS_CTR PAGE_VIEWS_RPM AD_REQUESTS AD_REQUESTS_COVERAGE AD_REQUESTS_CTR AD_REQUESTS_RPM MATCHED_AD_REQUESTS MATCHED_AD_REQUESTS_CTR MATCHED_AD_REQUESTS_RPM INDIVIDUAL_AD_IMPRESSIONS INDIVIDUAL_AD_IMPRESSIONS_CTR INDIVIDUAL_AD_IMPRESSIONS_RPM CLICKS EARNINGS TOTAL_EARNINGS COST_PER_CLICK"",
     ""items"": {
      ""type"": ""string""
     }
    },
    ""pagination"": {
     ""type"": ""object"",
     ""description"": ""Optionally specifies how to paginate the rows of the report output. If not defined, all rows of the report will be retrieved up to the available limit of 10,000 rows. If more rows are present in the report, multiple calls must be made, setting start_row to 10000 in the second call and so on."",
     ""properties"": {
      ""row_count"": {
       ""type"": ""integer"",
       ""description"": ""Number of rows to return in the report, starting from start_row, or -1 to retrieve all rows from start_row on. No more than the limit of 10,000 rows will be returned, even if this value is set higher. Defaults to -1, i.e. retrieving all rows from start_row on.""
      },
      ""start_row"": {
       ""type"": ""integer"",
       ""description"": ""Row in the report to start retrieving output from, beginning at 0. Defaults to 0, i.e. starting at the first row in the report.""
      }
     }
    },
    ""scope"": {
     ""type"": ""object"",
     ""description"": ""The scope of the report is the items this report will scan to collect data to report on. It is either a list of ad client ids, ad unit ids, custom channel ids or URL channel ids identifying the objects to be part of the scope. Only one list may be specified. The specified list may contain any amount of items.  The type of the scope dictates what dimensions can be used in the report. If ad unit or channel dimensions are used, the corresponding type of scope must also be used. For example, if AD_UNIT_CODE is used as a dimension ad_unit_ids must be specified as the scope, with no other list given in the scope."",
     ""properties"": {
      ""ad_client_ids"": {
       ""type"": ""array"",
       ""description"": ""Specifies a scope over a set of ad clients. Each item in this list is an ad client id, uniquely identifying an ad client.  If this list is specified, none of the other lists in the scope may be specified."",
       ""items"": {
        ""type"": ""string""
       }
      },
      ""ad_unit_ids"": {
       ""type"": ""array"",
       ""description"": ""Specifies a scope over a set of ad units. Each item in this list is an ad unit id, uniquely identifying an ad unit.  If this list is specified, none of the other lists in the scope may be specified.  This list must be specified if ad unit dimensions are used, for example AD_UNIT_CODE."",
       ""items"": {
        ""type"": ""string""
       }
      },
      ""custom_channel_ids"": {
       ""type"": ""array"",
       ""description"": ""Specifies a scope over a set of custom channels. Each item in this list is a custom channel id, uniquely identifying a custom channel.  If this list is specified, none of the other lists in the scope may be specified.  This list must be specified if custom channel dimensions are used, for example CUSTOM_CHANNEL_CODE."",
       ""items"": {
        ""type"": ""string""
       }
      },
      ""url_channel_ids"": {
       ""type"": ""array"",
       ""description"": ""Specifies a scope over a set of URL channels. Each item in this list is a URL channel id, uniquely identifying a URL channel.  If this list is specified, none of the other lists in the scope may be specified.  This list must be specified if URL channel dimensions are used, for example URL_CHANNEL_PATTERN."",
       ""items"": {
        ""type"": ""string""
       }
      }
     }
    },
    ""sorts"": {
     ""type"": ""array"",
     ""description"": ""Columns to sort the report result on. The report is sorted by the first specified column, then by the second (if any), and so on. Sort columns can be either dimensions or metrics. The rows of the table can be in any order if no sort columns are specified.  Possible column names:  DATE WEEK MONTH HOUR AD_CLIENT_ID AD_CLIENT_NAME PRODUCT_CODE PRODUCT_NAME AD_UNIT_ID AD_UNIT_CODE AD_UNIT_NAME AD_UNIT_SIZE_CODE AD_UNIT_SIZE_NAME CUSTOM_CHANNEL_ID CUSTOM_CHANNEL_CODE CUSTOM_CHANNEL_NAME URL_CHANNEL_ID URL_CHANNEL_NAME AD_FORMAT_CODE AD_FORMAT_NAME BRANDING_TYPE_CODE BRANDING_TYPE_NAME BUYER_NETWORK_ID BUYER_NETWORK_NAME BID_TYPE_CODE BID_TYPE_NAME DOMAIN_NAME COUNTRY_CODE COUNTRY_NAME TARGETING_TYPE_CODE TARGETING_TYPE_NAME PAGE_VIEWS PAGE_VIEWS_CTR PAGE_VIEWS_RPM AD_REQUESTS AD_REQUESTS_COVERAGE AD_REQUESTS_CTR AD_REQUESTS_RPM MATCHED_AD_REQUESTS MATCHED_AD_REQUESTS_CTR MATCHED_AD_REQUESTS_RPM INDIVIDUAL_AD_IMPRESSIONS INDIVIDUAL_AD_IMPRESSIONS_CTR INDIVIDUAL_AD_IMPRESSIONS_RPM CLICKS EARNINGS TOTAL_EARNINGS COST_PER_CLICK"",
     ""items"": {
      ""type"": ""object"",
      ""properties"": {
       ""column"": {
        ""type"": ""string"",
        ""description"": ""The name of the dimension or metric to sort on.""
       },
       ""descending"": {
        ""type"": ""boolean"",
        ""description"": ""If true, sort this column in descending order. If not specified the column is sorted in ascending order.""
       }
      }
     }
    }
   }
  },
  ""AdsenseReportsGenerateResponse"": {
   ""id"": ""AdsenseReportsGenerateResponse"",
   ""type"": ""object"",
   ""properties"": {
    ""headers"": {
     ""type"": ""array"",
     ""description"": ""The header names of the columns requested in the report. This is a list of names; one for each dimension in the request, followed by one for each metric in the request."",
     ""items"": {
      ""type"": ""object"",
      ""properties"": {
       ""name"": {
        ""type"": ""string""
       },
       ""type"": {
        ""type"": ""string""
       }
      }
     }
    },
    ""rows"": {
     ""type"": ""array"",
     ""description"": ""The output rows of the report. Each row is a list of cells; one for each dimension in the request, followed by one for each metric in the request. The dimension cells contain strings, and the metric cells contain numbers."",
     ""items"": {
      ""type"": ""array"",
      ""items"": {
       ""type"": ""string""
      }
     }
    },
    ""total_matched_rows"": {
     ""type"": ""integer"",
     ""description"": ""The total number of rows matched by the report request. Fewer rows may be returned in the response due to being limited by the row count requested or the report row limit.""
    }
   }
  },
  ""CustomChannel"": {
   ""id"": ""CustomChannel"",
   ""type"": ""object"",
   ""properties"": {
    ""code"": {
     ""type"": ""string"",
     ""description"": ""Code of this custom channel, not necessarily unique across ad clients.""
    },
    ""id"": {
     ""type"": ""string"",
     ""description"": ""Unique identifier of this custom channel. This should be considered an opaque identifier; it is not safe to rely on it being in any particular format.""
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of resource this is, in this case adsense#customChannel."",
     ""default"": ""adsense#customChannel""
    },
    ""name"": {
     ""type"": ""string"",
     ""description"": ""Name of this custom channel.""
    }
   }
  },
  ""CustomChannels"": {
   ""id"": ""CustomChannels"",
   ""type"": ""object"",
   ""properties"": {
    ""etag"": {
     ""type"": ""string"",
     ""description"": ""ETag of this response for caching purposes.""
    },
    ""items"": {
     ""type"": ""array"",
     ""description"": ""The custom channels returned in this list response."",
     ""items"": {
      ""$ref"": ""CustomChannel""
     }
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of list this is, in this case adsense#customChannels."",
     ""default"": ""adsense#customChannels""
    }
   }
  },
  ""UrlChannel"": {
   ""id"": ""UrlChannel"",
   ""type"": ""object"",
   ""properties"": {
    ""id"": {
     ""type"": ""string"",
     ""description"": ""Unique identifier of this URL channel. This should be considered an opaque identifier; it is not safe to rely on it being in any particular format.""
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of resource this is, in this case adsense#urlChannel."",
     ""default"": ""adsense#urlChannel""
    },
    ""urlPattern"": {
     ""type"": ""string"",
     ""description"": ""URL Pattern of this URL channel. Does not include \""http://\"" or \""https://\"". Example: www.example.com/home""
    }
   }
  },
  ""UrlChannels"": {
   ""id"": ""UrlChannels"",
   ""type"": ""object"",
   ""properties"": {
    ""etag"": {
     ""type"": ""string"",
     ""description"": ""ETag of this response for caching purposes.""
    },
    ""items"": {
     ""type"": ""array"",
     ""description"": ""The URL channels returned in this list response."",
     ""items"": {
      ""$ref"": ""UrlChannel""
     }
    },
    ""kind"": {
     ""type"": ""string"",
     ""description"": ""Kind of list this is, in this case adsense#urlChannels."",
     ""default"": ""adsense#urlChannels""
    }
   }
  }
 },
 ""resources"": {
  ""adclients"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""ad_clients"",
     ""rpcMethod"": ""adsense.adclients.list"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all ad clients in this AdSense account."",
     ""response"": {
      ""$ref"": ""AdClients""
     }
    }
   }
  },
  ""adunits"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""ad_clients/{ad_client_id}/ad_units"",
     ""rpcMethod"": ""adsense.adunits.list"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all ad units in this AdSense account."",
     ""parameters"": {
      ""ad_client_id"": {
       ""restParameterType"": ""path"",
       ""required"": true,
       ""description"": ""Ad client for which to list ad units."",
       ""type"": ""string""
      }
     },
     ""parameterOrder"": [
      ""ad_client_id""
     ],
     ""response"": {
      ""$ref"": ""AdUnits""
     }
    }
   }
  },
  ""customchannels"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""ad_clients/{ad_client_id}/custom_channels"",
     ""rpcMethod"": ""adsense.customchannels.list"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all custom channels in this AdSense account."",
     ""parameters"": {
      ""ad_client_id"": {
       ""restParameterType"": ""path"",
       ""required"": true,
       ""description"": ""Ad client for which to list custom channels."",
       ""type"": ""string""
      }
     },
     ""parameterOrder"": [
      ""ad_client_id""
     ],
     ""response"": {
      ""$ref"": ""CustomChannels""
     }
    }
   }
  },
  ""reports"": {
   ""methods"": {
    ""generate"": {
     ""restPath"": ""reports/generate"",
     ""rpcMethod"": ""adsense.reports.generate"",
     ""httpMethod"": ""POST"",
     ""description"": ""Generate an AdSense report based on the JSON-formatted report request sent in the HTML body. Returns the result as JSON; to retrieve output in CSV format specify \""alt\u003dcsv\"" as a query parameter."",
     ""request"": {
      ""$ref"": ""AdsenseReportsGenerateRequest""
     },
     ""response"": {
      ""$ref"": ""AdsenseReportsGenerateResponse""
     }
    }
   }
  },
  ""urlchannels"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""ad_clients/{ad_client_id}/url_channels"",
     ""rpcMethod"": ""adsense.urlchannels.list"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all URL channels in this AdSense account."",
     ""parameters"": {
      ""ad_client_id"": {
       ""restParameterType"": ""path"",
       ""required"": true,
       ""description"": ""Ad client for which to list URL channels."",
       ""type"": ""string""
      }
     },
     ""parameterOrder"": [
      ""ad_client_id""
     ],
     ""response"": {
      ""$ref"": ""UrlChannels""
     }
    }
   }
  }
 }
}";
#endregion
		
		#region buzz discovery 0.3
        public const string BuzzV0_3_Json = @"{
 'name': 'buzz',
 'version': 'v1',
 'description': 'Buzz APIs for Buzz Posts, etc.',
 'restBasePath': '/buzz/v1/',
 'rpcPath': '/rpc',
 'features': [
  'dataWrapper'
 ],
 'schemas': {
  'Activitiylist': '{\'id\':\'Activitiylist\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'items\':{\'items\':{\'$ref\':\'ChiliActivitiesResourceJson\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#activityFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliActivitiesCountJson': '{\'id\':\'ChiliActivitiesCountJson\',\'properties\':{\'counts\':{\'additionalProperties\':{\'items\':{\'properties\':{\'timestamp\':{\'type\':\'string\'},\'count\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#countFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliActivitiesExtractpeoplefromsearchJson': '{\'id\':\'ChiliActivitiesExtractpeoplefromsearchJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliActivitiesListJson': '{\'id\':\'ChiliActivitiesListJson\',\'$ref\':\'Activitiylist\'}',
  'ChiliActivitiesResourceJson': '{\'id\':\'ChiliActivitiesResourceJson\',\'properties\':{\'visibility\':{\'properties\':{\'entries\':{\'items\':{\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'}},\'type\':\'object\'},\'placeholder\':{\'type\':\'any\'},\'targetLang\':{\'type\':\'any\'},\'placeName\':{\'type\':\'any\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'properties\':{\'liked\':{\'items\':{\'properties\':{\'count\':{\'type\':\'integer\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'}},\'type\':\'object\'},\'crosspostSource\':{\'type\':\'any\'},\'actor\':{\'properties\':{\'id\':{\'type\':\'any\'},\'profileUrl\':{\'type\':\'any\'},\'thumbnailUrl\':{\'type\':\'any\'},\'name\':{\'type\':\'any\'}},\'type\':\'object\'},\'object\':{\'properties\':{\'untranslatedContent\':{\'type\':\'any\'},\'targetLang\':{\'type\':\'any\'},\'liked\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'actor\':{\'properties\':{\'id\':{\'type\':\'any\'},\'profileUrl\':{\'type\':\'any\'},\'thumbnailUrl\':{\'type\':\'any\'},\'name\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':{\'type\':\'string\'},\'detectedlLang\':{\'type\':\'any\'},\'shareOriginal\':{\'$ref\':\'ChiliActivitiesResourceJson\'},\'originalContent\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'content\':{\'type\':\'any\'},\'attachments\':{\'items\':{\'properties\':{\'content\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'type\':{\'type\':\'string\'}},\'type\':\'object\'},\'type\':\'array\'},\'comments\':{\'items\':{\'$ref\':\'ChiliCommentsResourceJson\'},\'type\':\'array\'}},\'type\':\'object\'},\'detectedlLang\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#activity\',\'type\':\'string\'},\'geocode\':{\'type\':\'any\'},\'annotation\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'source\':{\'properties\':{\'title\':{\'type\':\'any\'}},\'type\':\'object\'},\'placeId\':{\'type\':\'any\'},\'address\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'verbs\':{\'items\':{\'type\':\'string\'},\'type\':\'array\'},\'radius\':{\'type\':\'any\'},\'categories\':{\'items\':{\'properties\':{\'schema\':{\'type\':\'any\'},\'term\':{\'type\':\'any\'},\'label\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'untranslatedTitle\':{\'type\':\'any\'},\'published\':{\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliActivitiesSearchJson': '{\'id\':\'ChiliActivitiesSearchJson\',\'$ref\':\'Activitiylist\'}',
  'ChiliActivitiesTrackJson': '{\'id\':\'ChiliActivitiesTrackJson\',\'$ref\':\'Activitiylist\'}',
  'ChiliCommentsListJson': '{\'id\':\'ChiliCommentsListJson\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'items\':{\'items\':{\'$ref\':\'ChiliCommentsResourceJson\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#commentFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliCommentsResourceJson': '{\'id\':\'ChiliCommentsResourceJson\',\'properties\':{\'content\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'detectedLang\':{\'type\':\'any\'},\'untranslatedContent\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'targetLang\':{\'type\':\'any\'},\'placeholder\':{\'type\':\'any\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'properties\':{\'inReplyTo\':{\'items\':{\'properties\':{\'ref\':{\'type\':\'any\'},\'source\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'}},\'type\':\'object\'},\'actor\':{\'properties\':{\'id\':{\'type\':\'any\'},\'profileUrl\':{\'type\':\'any\'},\'thumbnailUrl\':{\'type\':\'any\'},\'name\':{\'type\':\'any\'}},\'type\':\'object\'},\'published\':{\'type\':\'string\'},\'kind\':{\'default\':\'buzz#comment\',\'type\':\'string\'},\'originalContent\':{\'type\':\'any\'}},\'type\':\'object\'}',
  'ChiliEntitiesListJson': '{\'id\':\'ChiliEntitiesListJson\',\'properties\':{\'entry\':{\'items\':{\'$ref\':\'ChiliEntitiesStarredResource\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#starredEntityFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliEntitiesStarredAddJson': '{\'id\':\'ChiliEntitiesStarredAddJson\',\'$ref\':\'ChiliEntitiesStarredResource\'}',
  'ChiliEntitiesStarredListJson': '{\'id\':\'ChiliEntitiesStarredListJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliEntitiesStarredResource\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#starredEntityFeedForUser\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliEntitiesStarredResource': '{\'id\':\'ChiliEntitiesStarredResource\',\'properties\':{\'summary\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'viewerStarAcl\':{\'items\':{\'properties\':{\'id\':{\'type\':\'any\'},\'tags\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'displayName\':{\'type\':\'any\'},\'kind\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'title\':{\'type\':\'any\'},\'chipsUiAcl\':{\'type\':\'any\'},\'totalNumStars\':{\'type\':\'any\'},\'starredBy\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'starredByViewer\':{\'type\':\'any\'},\'comment\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#entity\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliEntitiesdefaultaclResourceJson': '{\'id\':\'ChiliEntitiesdefaultaclResourceJson\',\'properties\':{\'viewerStarAcl\':{\'items\':{\'properties\':{\'id\':{\'type\':\'string\'},\'tags\':{\'items\':{\'type\':\'string\'},\'type\':\'array\'},\'displayName\':{\'type\':\'string\'},\'kind\':{\'type\':\'string\'}},\'type\':\'object\'},\'type\':\'array\'},\'chipsUiAcl\':{\'type\':\'string\'},\'kind\':{\'default\':\'buzz#entityAcl\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliGroupsListJson': '{\'id\':\'ChiliGroupsListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliGroupsResourceJson\'},\'type\':\'array\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#groupFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliGroupsResourceJson': '{\'id\':\'ChiliGroupsResourceJson\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'links\':{\'properties\':{\'self\':{\'items\':{\'properties\':{\'type\':{\'default\':\'application/json\',\'type\':\'string\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'}},\'type\':\'object\'},\'memberCount\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#group\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPeopleLikedJson': '{\'id\':\'ChiliPeopleLikedJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPeopleListJson': '{\'id\':\'ChiliPeopleListJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPeopleResharedJson': '{\'id\':\'ChiliPeopleResharedJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPeopleResourceJson': '{\'id\':\'ChiliPeopleResourceJson\',\'properties\':{\'turnOffs\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'heroes\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'ims\':{\'items\':{\'properties\':{\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'connected\':{\'type\':\'any\'},\'sports\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'languagesSpoken\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'religion\':{\'type\':\'any\'},\'turnOns\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'languages\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'cars\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'pets\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'gender\':{\'type\':\'any\'},\'humor\':{\'type\':\'any\'},\'activities\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'preferredUsername\':{\'type\':\'any\'},\'hasApp\':{\'type\':\'any\'},\'books\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'happiestWhen\':{\'type\':\'any\'},\'scaredOf\':{\'type\':\'any\'},\'nickname\':{\'type\':\'any\'},\'status\':{\'type\':\'any\'},\'emails\':{\'items\':{\'properties\':{\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'profileUrl\':{\'type\':\'any\'},\'food\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'utcOffset\':{\'type\':\'any\'},\'profileVideo\':{\'type\':\'any\'},\'smoker\':{\'type\':\'any\'},\'addresses\':{\'items\':{\'properties\':{\'region\':{\'type\':\'any\'},\'streetAddress\':{\'type\':\'any\'},\'formatted\':{\'type\':\'any\'},\'postalCode\':{\'type\':\'any\'},\'primary\':{\'type\':\'any\'},\'locality\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'country\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'birthday\':{\'type\':\'any\'},\'fashion\':{\'type\':\'any\'},\'interests\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'drinker\':{\'type\':\'any\'},\'movies\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'jobInterests\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'children\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'lookingFor\':{\'type\':\'any\'},\'romance\':{\'type\':\'any\'},\'aboutMe\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#person\',\'type\':\'string\'},\'bodyType\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'tvShows\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'name\':{\'properties\':{\'middleName\':{\'type\':\'any\'},\'formatted\':{\'type\':\'any\'},\'honorificPrefix\':{\'type\':\'any\'},\'familyName\':{\'type\':\'any\'},\'givenName\':{\'type\':\'any\'},\'honorificSuffix\':{\'type\':\'any\'}},\'type\':\'object\'},\'thumbnailUrl\':{\'type\':\'any\'},\'published\':{\'type\':\'string\'},\'relationships\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'profileSong\':{\'type\':\'any\'},\'note\':{\'type\':\'any\'},\'music\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'tags\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'anniversary\':{\'type\':\'any\'},\'politicalViews\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'accounts\':{\'items\':{\'properties\':{\'username\':{\'type\':\'any\'},\'userid\':{\'type\':\'any\'},\'domain\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'urls\':{\'items\':{\'properties\':{\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'organizations\':{\'items\':{\'properties\':{\'startDate\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'location\':{\'type\':\'any\'},\'description\':{\'type\':\'any\'},\'department\':{\'type\':\'any\'},\'primary\':{\'type\':\'any\'},\'name\':{\'type\':\'any\'},\'endDate\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'relationshipStatus\':{\'type\':\'any\'},\'phoneNumbers\':{\'items\':{\'properties\':{\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'livingArrangement\':{\'type\':\'any\'},\'currentLocation\':{\'type\':\'any\'},\'photos\':{\'items\':{\'properties\':{\'height\':{\'type\':\'any\'},\'width\':{\'type\':\'any\'},\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'quotes\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'sexualOrientation\':{\'type\':\'any\'},\'displayName\':{\'type\':\'any\'},\'ethnicity\':{\'type\':\'any\'}},\'type\':\'object\'}',
  'ChiliPeopleSearchJson': '{\'id\':\'ChiliPeopleSearchJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPhotoalbumsListJson': '{\'id\':\'ChiliPhotoalbumsListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliPhotoalbumsResourceJson\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#albumsFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPhotoalbumsResourceJson': '{\'id\':\'ChiliPhotoalbumsResourceJson\',\'properties\':{\'tags\':{\'items\':{\'type\':\'string\'},\'type\':\'array\'},\'id\':{\'type\':\'integer\'},\'firstPhotoId\':{\'type\':\'integer\'},\'title\':{\'type\':\'string\'},\'lastModified\':{\'type\':\'string\'},\'created\':{\'type\':\'string\'},\'description\':{\'type\':\'string\'},\'owner\':{\'properties\':{\'id\':{\'type\':\'string\'},\'profileUrl\':{\'type\':\'string\'},\'thumbnailUrl\':{\'type\':\'string\'},\'name\':{\'type\':\'string\'}},\'type\':\'object\'},\'links\':{\'properties\':{\'alternate\':{\'$ref\':\'Link\'},\'enclosure\':{\'$ref\':\'Link\'}},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#album\',\'type\':\'string\'},\'version\':{\'type\':\'integer\'}},\'type\':\'object\'}',
  'ChiliPhotosInsertJson': '{\'id\':\'ChiliPhotosInsertJson\',\'properties\':{\'collection\':{\'properties\':{\'albumId\':{\'type\':\'any\'},\'album\':{\'type\':\'any\'},\'photo\':{\'properties\':{\'photoUrl\':{\'type\':\'any\'}},\'type\':\'object\'}},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#album\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPhotosListJson': '{\'id\':\'ChiliPhotosListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliPhotosResourceJson\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#photosFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPhotosResourceJson': '{\'id\':\'ChiliPhotosResourceJson\',\'properties\':{\'lastModified\':{\'type\':\'string\'},\'album\':{\'properties\':{\'id\':{\'type\':\'integer\'},\'page_link\':{\'$ref\':\'Link\'}},\'type\':\'object\'},\'links\':{\'additionalProperties\':{\'items\':{\'$ref\':\'Link\'},\'type\':\'array\'},\'properties\':{\'alternate\':{\'items\':{\'$ref\':\'Link\'},\'type\':\'array\'}},\'type\':\'object\'},\'kind\':{\'type\':\'string\'},\'version\':{\'type\':\'integer\'},\'id\':{\'type\':\'integer\'},\'timestamp\':{\'type\':\'number\'},\'fileSize\':{\'type\':\'integer\'},\'title\':{\'type\':\'string\'},\'created\':{\'type\':\'string\'},\'description\':{\'type\':\'string\'},\'owner\':{\'properties\':{\'id\':{\'type\':\'string\'},\'profileUrl\':{\'type\':\'string\'},\'thumbnailUrl\':{\'type\':\'string\'},\'name\':{\'type\':\'string\'}},\'type\':\'object\'},\'video\':{\'$ref\':\'Video\'}},\'type\':\'object\'}',
  'ChiliRelatedListJson': '{\'id\':\'ChiliRelatedListJson\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'items\':{\'items\':{\'$ref\':\'ChiliRelatedResourceJson\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#relatedFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliRelatedResourceJson': '{\'id\':\'ChiliRelatedResourceJson\',\'properties\':{\'summary\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#related\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliVideosListJson': '{\'id\':\'ChiliVideosListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliPhotosResourceJson\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#videosFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'Link': '{\'id\':\'Link\',\'properties\':{\'title\':{\'type\':\'string\'},\'height\':{\'type\':\'integer\'},\'count\':{\'type\':\'integer\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'integer\'},\'type\':{\'type\':\'string\'},\'href\':{\'type\':\'string\'}},\'type\':\'object\'}',
  'Video': '{\'id\':\'Video\',\'properties\':{\'duration\':{\'type\':\'integer\'},\'streams\':{\'items\':{\'$ref\':\'Link\'},\'type\':\'array\'},\'size\':{\'type\':\'integer\'}},\'type\':\'object\'}'
 },
 'resources': {
  'activities': {
   'methods': {
    'count': {
     'restPath': 'activities/count',
     'rpcMethod': 'chili.activities.count',
     'httpMethod': 'GET',
     'parameters': {
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesCountJson'
     }
    },
    'delete': {
     'restPath': 'activities/{userId}/{scope}/{postId}',
     'rpcMethod': 'chili.activities.delete',
     'httpMethod': 'DELETE',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'postId': {
       'restParameterType': 'path',
       'pattern': '.*',
       'required': true,
       'repeated': false
      },
      'scope': {
       'restParameterType': 'path',
       'pattern': '@.*',
       'required': true,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     }
    },
    'extractPeopleFromSearch': {
     'restPath': 'activities/search/@people',
     'rpcMethod': 'chili.activities.extractPeopleFromSearch',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'bbox': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lat': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lon': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'pid': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'q': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'radius': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesExtractpeoplefromsearchJson'
     }
    },
    'get': {
     'restPath': 'activities/{userId}/@self/{postId}',
     'rpcMethod': 'chili.activities.get',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'postId': {
       'restParameterType': 'path',
       'pattern': '.*',
       'required': true,
       'repeated': false
      },
      'targetLang': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'truncateAtom': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesResourceJson'
     }
    },
    'insert': {
     'restPath': 'activities/{userId}/@self',
     'rpcMethod': 'chili.activities.insert',
     'httpMethod': 'POST',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'preview': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'request': {
      '$ref': 'ChiliActivitiesResourceJson'
     },
     'response': {
      '$ref': 'ChiliActivitiesResourceJson'
     }
    },
    'list': {
     'restPath': 'activities/{userId}/{scope}',
     'rpcMethod': 'chili.activities.list',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-comments': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-liked': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'scope': {
       'restParameterType': 'path',
       'pattern': '@(self|public|consumption|liked|comments)*',
       'required': true,
       'repeated': false
      },
      'targetLang': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'truncateAtom': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesListJson'
     }
    },
    'search': {
     'restPath': 'activities/search',
     'rpcMethod': 'chili.activities.search',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'bbox': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lat': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lon': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'pid': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'q': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'radius': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'targetLang': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'truncateAtom': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesSearchJson'
     }
    },
    'track': {
     'restPath': 'activities/track',
     'rpcMethod': 'chili.activities.track',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'bbox': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lat': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lon': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'pid': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'q': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'radius': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesTrackJson'
     }
    },
    'update': {
     'restPath': 'activities/{userId}/{scope}/{postId}',
     'rpcMethod': 'chili.activities.update',
     'httpMethod': 'PUT',
     'parameters': {
      'abuseType': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'postId': {
       'restParameterType': 'path',
       'pattern': '.*',
       'required': true,
       'repeated': false
      },
      'scope': {
       'restParameterType': 'path',
       'pattern': '@.*',
       'required': true,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'request': {
      '$ref': 'ChiliActivitiesResourceJson'
     },
     'response': {
      '$ref': 'ChiliActivitiesResourceJson'
     }
    }
   }
  }
 }
}";
        #endregion
		
		public static bool CheckValidationResult (object sender, X509Certificate cert, X509Chain X509Chain, SslPolicyErrors errors)
		{
			return true;
		}
		
		private static void DisableSllChecking()
		{
			ServicePointManager.ServerCertificateValidationCallback += CheckValidationResult;			
		}
		
		public static void Main (string[] args)
		{
			Logger.Debug("Logging Started");
			DisableSllChecking();
			//GenerateBuzzServiceV02 ();
			//GenerateAdSenseService ();
			GenerateBuzzServiceV03 ();
			GenerateAdSenseServiceV03 ();
			GenerateAdSenseServiceV1A4 ();
			Logger.Debug("All Done");
		}
		
		private static void GenerateBuzzServiceV02 ()
		{
			var serviceName = "buzz";
			var version = "v1";
			var clientNamespace ="Google.Apis.Samples.CommandLineGeneratedService.Buzz";
			var language = "CSharp";
			var output = "../../../CommandLineGeneratedService/Buzz/BuzzService.cs";
			
			GoogleServiceGenerator.GenerateService(serviceName, version, clientNamespace, language, output); 
		}
		
		private static void GenerateAdSenseServiceV1A4 ()
		{
			var version = "v1";
			var clientNamespace ="Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApiV1A4";
			var language = "CSharp";
			var output = "../../../CommandLineGeneratedService/V03/AdSense/AdSenseApiV1A4.cs";
			
			var cachedFetcher = new StringDiscoveryDevice();
			cachedFetcher.Document = AdSenseV1A4Json;
				
			
			var discovery = new DiscoveryService (cachedFetcher);
            // Build the service based on discovery information.
			var param = new FactoryParameterV0_3("http://example.url.com",null);
            var service = discovery.GetService (version, DiscoveryVersion.Version_0_3, param);
            
            var generator = new GoogleServiceGenerator (service, clientNamespace);
            
            var provider = CodeDomProvider.CreateProvider (language);
            
            using (StreamWriter sw = new StreamWriter (output, false)) {
                IndentedTextWriter tw = new IndentedTextWriter (sw, "  ");
                
                // Generate source code using the code provider.
                
                provider.GenerateCodeFromCompileUnit (
					generator.GenerateCode (), tw, new CodeGeneratorOptions ());
                
                // Close the output file.
                tw.Close ();
            }
		}
		
		private static void GenerateAdSenseServiceV03 ()
		{
			var version = "v1";
			var clientNamespace ="Google.Apis.Samples.CommandLineGeneratedService.V03.AdSenseApi";
			var language = "CSharp";
			var output = "../../../CommandLineGeneratedService/V03/AdSense/AdSenseApi.cs";
			
			//var fetcher = new StringDiscoveryDevice();
			//fetcher.Document = AdSenseV0_3_Json;
			var fetcher = new WebDiscoveryDevice(new Uri("https://www.googleapis.com/discovery/v0.3/describe/buzz/v1"));
				
			
			var discovery = new DiscoveryService (fetcher);
            // Build the service based on discovery information.
			var param = new FactoryParameterV0_3("https://www.googleapis.com/",null);
            var service = discovery.GetService (version, DiscoveryVersion.Version_0_3, param);
            
            var generator = new GoogleServiceGenerator (service, clientNamespace);
            
            var provider = CodeDomProvider.CreateProvider (language);
            
            using (StreamWriter sw = new StreamWriter (output, false)) {
                IndentedTextWriter tw = new IndentedTextWriter (sw, "  ");
                
                // Generate source code using the code provider.
                
                provider.GenerateCodeFromCompileUnit (
					generator.GenerateCode (), tw, new CodeGeneratorOptions ());
                
                // Close the output file.
                tw.Close ();
            }
		}
		
		private static void GenerateBuzzServiceV03 ()
		{
			var version = "v1";
			var clientNamespace ="Google.Apis.Samples.CommandLineGeneratedService.V03.Buzz";
			var language = "CSharp";
			var output = "../../../CommandLineGeneratedService/V03/Buzz/BuzzService.cs";
			
			//var stringFetcher = new StringDiscoveryDevice();
			//stringFetcher.Document = BuzzV0_3_Json;
			
			var cachedFetcher = new CachedWebDiscoveryDevice(
                	new Uri("https://www.googleapis.com/discovery/v0.3/describe/buzz/v1"), 
                    GetCacheDirectory());
			
			var discovery = new DiscoveryService (cachedFetcher);
            // Build the service based on discovery information.
			var param = new FactoryParameterV0_3("https://www.googleapis.com",null);
            var service = discovery.GetService (version, DiscoveryVersion.Version_0_3, param);
            
            var generator = new GoogleServiceGenerator (service, clientNamespace);
            
            var provider = CodeDomProvider.CreateProvider (language);
            
            using (StreamWriter sw = new StreamWriter (output, false)) {
                IndentedTextWriter tw = new IndentedTextWriter (sw, "  ");
                
                // Generate source code using the code provider.
                
                provider.GenerateCodeFromCompileUnit (
					generator.GenerateCode (), tw, new CodeGeneratorOptions ());
                
                // Close the output file.
                tw.Close ();
            }
			
		}
		
		private static DirectoryInfo GetCacheDirectory() 
		{
			string cacheDirectory = Path.Combine (
					Environment.GetFolderPath (Environment.SpecialFolder.ApplicationData), 
			        "GoogleApis.Tools.CodeGenCache");
            if (Directory.Exists (cacheDirectory) == false) {
                Directory.CreateDirectory (cacheDirectory);
            }
			return new DirectoryInfo(cacheDirectory);
		}
	}
}


/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;


using LumenWorks.Framework.IO.Csv;

using Google.Apis.Samples.AdSenseApi.Service;

namespace Google.Apis.Samples.AdSenseApi
{
	public class RevenueReport
	{
		private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(RevenueReport));
		
		public DateTime StartDate{get;set;}
		public DateTime EndDate{get;set;}
		public string PublicationId{get;set;}
		public AdsensemgmtService Service{get; set;}
		private const string jsonFormat = @"
{
  ""scope"": {
    ""property_codes"": [""{0}""]
  },
  ""dimensions"": [""DATE""],
  ""metrics"": [""PUBLISHER_EARNINGS""],
  ""period"": {
  ""start_date"": ""{1}"",
  ""end_date"": ""{2}""
  }
}
";
		
		public RevenueReport (AdsensemgmtService service)
		{
			this.Service = service;
		}
		
		private string GenerateRequestJson()
		{
			// Can't use string.format as it gets confused by jason 
			//return string.Format(jsonFormat, PublicationId, StartDate, EndDate);
			return jsonFormat
				.Replace("{0}", PublicationId)
				.Replace("{1}", string.Format("{0:yyyyMMdd}", StartDate))
				.Replace("{2}", string.Format("{0:yyyyMMdd}", EndDate));
		}
		
		public IEnumerable<ResultRow> ExecuteReport()
		{
			var result = this.Service.Reports.Generate(GenerateRequestJson());
            StreamReader st = new StreamReader(result);
            String resultAsString = st.ReadToEnd();
            logger.Debug("Result was :\n" + resultAsString);
			var dict = Json.JsonReader.Parse(resultAsString) as Json.JsonDictionary;
			string csv = dict["csv"] as string;
			csv = csv.Replace("\\n", "\n");
			logger.Debug(csv);
			var csvAsStream = new StreamReader(new MemoryStream(System.Text.UTF8Encoding.UTF8.GetBytes(csv)));
			using( CsvReader reader = new CsvReader(csvAsStream, true) )
			{
				//int fieldCount = reader.FieldCount;
				string[] header = reader.GetFieldHeaders();
				foreach(string h in header)
				{
					Console.Write(string.Format("{0}\t\t", h));
				}
				while(reader.ReadNextRecord())
				{
					yield return new ResultRow(reader[0], reader[1]);
				}
			}
			
			yield break;
		}
		
		public class ResultRow
		{
			public DateTime Date{get; private set;}
			public double EstimatedRevenue{get; private set;}
			
			public ResultRow(string date, string estRevenue)
			{
				DateTime d;
				double estimatedRevenue;
				if(DateTime.TryParseExact(date,"yyyyMMdd", null,  DateTimeStyles.None,  out d))
				{
					Date = d;
				}
				if(Double.TryParse(estRevenue, out estimatedRevenue))
				{
					EstimatedRevenue = estimatedRevenue;
				}
			}
			
			public override string ToString ()
			{
				return string.Format ("[ResultRow: Date={0:yyyy-MM-dd}, EstimatedRevenue={1}]", Date, EstimatedRevenue);
			}
		}
		
		
		
	}
}


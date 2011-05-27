using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Google.Apis.Util
{
    /// <summary>
    ///     Calls to Google Api return StandardResponses as Json with
    ///     two properties Data, being the return type of the method called
    ///     and Error, being any errors that occure.
    /// </summary>
    public sealed class StandardResponse<InnerType>
    {
        /// <summary>May be null if call failed.</summary>
        public InnerType Data { get; set; }
        /// <summary>May be null if call succedded.</summary>
        public RequestError Error { get; set; }

        public class RequestError
        {
            public IList<SingleError> Errors { get; set; }
            public int Code { get; set; }
            public string Message { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this.GetType().FullName).
                    Append(this.Message).AppendFormat(" [{0}]", Code).AppendLine();
                if ( Errors.IsNullOrEmpty() ) 
                {
                    sb.AppendLine("No individual errors");
                } else {
                    sb.AppendLine("Errors [");
                    foreach (SingleError err in Errors)
                    {
                        sb.Append('\t').AppendLine(err.ToString());
                    }
                    sb.AppendLine("]");
                }

                return sb.ToString();
            } 
        }

        public class SingleError
        {
            public string Domain { get; set; }
            public string Reason { get; set; }
            public string Message { get; set; }
            public string LocationType { get; set; }
            public string Location { get; set; }

            public override string  ToString()
            {
 	             return string.Format("Message[{0}] Location[{1} - {2}] Reason[{3}] Domain[{4}]", 
                     Message, Location, LocationType, Reason, Domain);
            }
        }
    }
}

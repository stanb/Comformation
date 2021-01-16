using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution OriginGroupFailoverCriteria
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupfailovercriteria.html
    /// </summary>
    public class OriginGroupFailoverCriteria
    {

        /// <summary>
        /// StatusCodes
        /// 		
        /// The status codes that, when returned from the primary origin, will trigger CloudFront to failover
        /// 		to the second origin.
        /// 	
        /// Required: Yes
        /// Type: StatusCodes
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatusCodes")]
        public StatusCodes StatusCodes { get; set; }

    }
}

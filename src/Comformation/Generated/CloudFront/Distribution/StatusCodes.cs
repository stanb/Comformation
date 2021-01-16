using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution StatusCodes
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-statuscodes.html
    /// </summary>
    public class StatusCodes
    {

        /// <summary>
        /// Quantity
        /// 		
        /// The number of status codes.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Quantity")]
        public Union<int, IntrinsicFunction> Quantity { get; set; }

        /// <summary>
        /// Items
        /// 		
        /// The items (status codes) for an origin group.
        /// 	
        /// Required: Yes
        /// Type: List of Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Items")]
        public List<Union<int, IntrinsicFunction>> Items { get; set; }

    }
}

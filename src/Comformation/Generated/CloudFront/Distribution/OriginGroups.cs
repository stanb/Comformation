using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution OriginGroups
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroups.html
    /// </summary>
    public class OriginGroups
    {

        /// <summary>
        /// Quantity
        /// 		
        /// The number of origin groups.
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
        /// The items (origin groups) in a distribution.
        /// 	
        /// Required: No
        /// Type: List of OriginGroup
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Items")]
        public List<OriginGroup> Items { get; set; }

    }
}

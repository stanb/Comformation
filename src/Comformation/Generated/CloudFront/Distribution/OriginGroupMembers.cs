using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution OriginGroupMembers
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupmembers.html
    /// </summary>
    public class OriginGroupMembers
    {

        /// <summary>
        /// Items
        /// 		
        /// Items (origins) in an origin group.
        /// 	
        /// Required: Yes
        /// Type: List of OriginGroupMember
        /// Maximum: 2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Items")]
        public List<OriginGroupMember> Items { get; set; }

        /// <summary>
        /// Quantity
        /// 		
        /// The number of origins in an origin group.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Quantity")]
        public Union<int, IntrinsicFunction> Quantity { get; set; }

    }
}

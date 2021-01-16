using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution OriginGroupMember
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroupmember.html
    /// </summary>
    public class OriginGroupMember
    {

        /// <summary>
        /// OriginId
        /// 		
        /// The ID for an origin in an origin group.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginId")]
        public Union<string, IntrinsicFunction> OriginId { get; set; }

    }
}

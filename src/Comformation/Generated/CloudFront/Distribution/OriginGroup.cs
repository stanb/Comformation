using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution OriginGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origingroup.html
    /// </summary>
    public class OriginGroup
    {

        /// <summary>
        /// FailoverCriteria
        /// 		
        /// A complex type that contains information about the failover criteria for an origin group.
        /// 	
        /// Required: Yes
        /// Type: OriginGroupFailoverCriteria
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailoverCriteria")]
        public OriginGroupFailoverCriteria FailoverCriteria { get; set; }

        /// <summary>
        /// Id
        /// 		
        /// The origin group&#39;s ID.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Members
        /// 		
        /// A complex type that contains information about the origins in an origin group.
        /// 	
        /// Required: Yes
        /// Type: OriginGroupMembers
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Members")]
        public OriginGroupMembers Members { get; set; }

    }
}

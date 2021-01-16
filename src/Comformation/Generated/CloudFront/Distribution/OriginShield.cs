using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution OriginShield
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-originshield.html
    /// </summary>
    public class OriginShield
    {

        /// <summary>
        /// OriginShieldRegion
        /// 		
        /// The AWS Region for Origin Shield.
        /// 		
        /// Specify the AWS Region that has the lowest latency to your origin. To specify a region, use the
        /// region code, not the region name. For example, specify the US East (Ohio) region as us-east-2.
        /// When you enable CloudFront Origin Shield, you must specify the AWS Region for Origin Shield. For the
        /// list of AWS Regions that you can specify, and for help choosing the best Region for your origin, see
        /// Choosing the AWS Region for Origin Shield in the 			Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 32
        /// Pattern: [a-z]{2}-[a-z]+-\d
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginShieldRegion")]
        public Union<string, IntrinsicFunction> OriginShieldRegion { get; set; }

        /// <summary>
        /// Enabled
        /// 		
        /// A flag that specifies whether Origin Shield is enabled.
        /// 		
        /// When it’s enabled, CloudFront routes all requests through Origin Shield, which can help protect your
        /// origin. When it’s disabled, CloudFront might send requests directly to your origin from multiple
        /// edge locations or regional edge caches.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}

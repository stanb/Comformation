using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CachePolicy
{
    /// <summary>
    /// AWS::CloudFront::CachePolicy HeadersConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-headersconfig.html
    /// </summary>
    public class HeadersConfig
    {

        /// <summary>
        /// HeaderBehavior
        /// Determines whether any HTTP headers are included in the cache key and automatically 			included in
        /// requests that CloudFront sends to the origin. Valid values are:
        /// 		
        /// 			 			 		 				 none – HTTP headers are not included in the cache key and are not 					automatically
        /// included in requests that CloudFront sends to the origin. Even when this 					field is set to none,
        /// any headers that are listed in an 					OriginRequestPolicy are included in origin 					requests. 			
        /// 				 whitelist – The HTTP headers that are listed in the Headers type 					are included in the cache
        /// key and are automatically included in requests that 					CloudFront sends to the origin. 			
        /// Required: Yes
        /// Type: String
        /// Allowed values: none | whitelist
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderBehavior")]
        public Union<string, IntrinsicFunction> HeaderBehavior { get; set; }

        /// <summary>
        /// Headers
        /// 		
        /// Contains a list of HTTP header names.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Headers")]
        public List<Union<string, IntrinsicFunction>> Headers { get; set; }

    }
}

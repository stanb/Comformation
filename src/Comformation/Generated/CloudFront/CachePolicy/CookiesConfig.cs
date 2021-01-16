using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CachePolicy
{
    /// <summary>
    /// AWS::CloudFront::CachePolicy CookiesConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cookiesconfig.html
    /// </summary>
    public class CookiesConfig
    {

        /// <summary>
        /// CookieBehavior
        /// 		
        /// Determines whether any cookies in viewer requests are included in the cache key and 			automatically
        /// included in requests that CloudFront sends to the origin. Valid values 			are:
        /// 		
        /// 			 			 			 			 		 				 none – Cookies in viewer requests are not included in the cache key and are
        /// 					not automatically included in requests that CloudFront sends to the origin. Even when 					this
        /// field is set to none, any cookies that are listed in an 					OriginRequestPolicy are included in
        /// origin 					requests. 			 				 whitelist – The cookies in viewer requests that are listed in the
        /// 					CookieNames type are included in the cache key and automatically 					included in requests that
        /// CloudFront sends to the origin. 			 				 allExcept – All cookies in viewer requests that are not
        /// listed in the CookieNames 					type are included in the cache key and automatically included in
        /// requests that 					CloudFront sends to the origin. 			 				 all – All cookies in viewer requests are
        /// included in the cache key and are 					automatically included in requests that CloudFront sends to
        /// the origin. 			
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: all | allExcept | none | whitelist
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CookieBehavior")]
        public Union<string, IntrinsicFunction> CookieBehavior { get; set; }

        /// <summary>
        /// Cookies
        /// 		
        /// Contains a list of cookie names.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cookies")]
        public List<Union<string, IntrinsicFunction>> Cookies { get; set; }

    }
}

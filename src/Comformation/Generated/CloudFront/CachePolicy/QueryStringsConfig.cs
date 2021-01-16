using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CachePolicy
{
    /// <summary>
    /// AWS::CloudFront::CachePolicy QueryStringsConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-querystringsconfig.html
    /// </summary>
    public class QueryStringsConfig
    {

        /// <summary>
        /// QueryStringBehavior
        /// 		
        /// Determines whether any URL query strings in viewer requests are included in the cache key 			and
        /// automatically included in requests that CloudFront sends to the origin. Valid values 			are:
        /// 		
        /// 			 			 			 			 		 				 none – Query strings in viewer requests are not included in the cache key
        /// and 					are not automatically included in requests that CloudFront sends to the origin. Even
        /// 					when this field is set to none, any query strings that are listed 					in an
        /// OriginRequestPolicy are included in 					origin requests. 			 				 whitelist – The query strings in
        /// viewer requests that are listed in the 					QueryStringNames type are included in the cache key and
        /// 					automatically included in requests that CloudFront sends to the origin. 			 				 allExcept –
        /// All query strings in viewer requests that are not listed in the 					QueryStringNames type are
        /// included in the cache key and 					automatically included in requests that CloudFront sends to the
        /// origin. 			 				 all – All query strings in viewer requests are included in the cache key and
        /// 					are automatically included in requests that CloudFront sends to the origin. 			
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: all | allExcept | none | whitelist
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryStringBehavior")]
        public Union<string, IntrinsicFunction> QueryStringBehavior { get; set; }

        /// <summary>
        /// QueryStrings
        /// 		
        /// Contains a list of query string names.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryStrings")]
        public List<Union<string, IntrinsicFunction>> QueryStrings { get; set; }

    }
}

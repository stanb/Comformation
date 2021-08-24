using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CachePolicy
{
    /// <summary>
    /// AWS::CloudFront::CachePolicy CachePolicyConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cachepolicyconfig.html
    /// </summary>
    public class CachePolicyConfig
    {

        /// <summary>
        /// Comment
        /// A comment to describe the cache policy. The comment cannot be longer than 128 			characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// DefaultTTL
        /// The default amount of time, in seconds, that you want objects to stay in the CloudFront 			cache
        /// before CloudFront sends another request to the origin to see if the object has been 			updated.
        /// CloudFront uses this value as the object’s time to live (TTL) only when the origin 			does not send
        /// Cache-Control or Expires 			headers with the object. For more information, see Managing How Long
        /// Content Stays in an Edge Cache (Expiration) in the 			Amazon CloudFront Developer Guide.
        /// 		
        /// The default value for this field is 86400 seconds (one day). If the value of 			MinTTL is more than
        /// 86400 seconds, then the default value for this field is 			the same as the value of MinTTL.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultTTL")]
        public Union<double, IntrinsicFunction> DefaultTTL { get; set; }

        /// <summary>
        /// MaxTTL
        /// 		
        /// The maximum amount of time, in seconds, that objects stay in the CloudFront cache 			before
        /// CloudFront sends another request to the origin to see if the object has been updated. 			CloudFront
        /// uses this value only when the origin sends Cache-Control or 			Expires headers with the object. For
        /// more information, see Managing How Long Content Stays in an Edge Cache (Expiration) in the 			Amazon
        /// CloudFront Developer Guide.
        /// 		
        /// The default value for this field is 31536000 seconds (one year). If the value of 			MinTTL or
        /// DefaultTTL is more than 31536000 seconds, then the 			default value for this field is the same as
        /// the value of DefaultTTL.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxTTL")]
        public Union<double, IntrinsicFunction> MaxTTL { get; set; }

        /// <summary>
        /// MinTTL
        /// The minimum amount of time, in seconds, that you want objects to stay in the CloudFront 			cache
        /// before CloudFront sends another request to the origin to see if the object has been 			updated. For
        /// more information, see Managing How Long Content Stays in an Edge Cache (Expiration) in the 			Amazon
        /// CloudFront Developer Guide.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinTTL")]
        public Union<double, IntrinsicFunction> MinTTL { get; set; }

        /// <summary>
        /// Name
        /// A unique name to identify the cache policy.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// ParametersInCacheKeyAndForwardedToOrigin
        /// The HTTP headers, cookies, and URL query strings to include in the cache key. The 			values included
        /// in the cache key are automatically included in requests that CloudFront sends 			to the origin.
        /// Required: Yes
        /// Type: ParametersInCacheKeyAndForwardedToOrigin
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParametersInCacheKeyAndForwardedToOrigin")]
        public ParametersInCacheKeyAndForwardedToOrigin ParametersInCacheKeyAndForwardedToOrigin { get; set; }

    }
}

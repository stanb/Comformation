using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution Cookies
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cookies.html
    /// </summary>
    public class Cookies
    {

        /// <summary>
        /// Forward
        /// 		
        /// This field is deprecated. We recommend that you use a cache policy or an origin 			request policy
        /// instead of this field.
        /// 		
        /// If you want to include cookies in the cache key, use a cache policy. For more information, 			see
        /// Creating cache policies in the Amazon CloudFront Developer Guide.
        /// 		
        /// If you want to send cookies to the origin but not include them in the cache key, use origin
        /// 			request policy. For more information, see Creating origin request policies in the 			Amazon
        /// CloudFront Developer Guide.
        /// 		
        /// Specifies which cookies to forward to the origin for this cache behavior: all, none, or 			the list
        /// of cookies specified in the WhitelistedNames complex type.
        /// 		
        /// Amazon S3 doesn&#39;t process cookies. When the cache behavior is forwarding requests to an 			Amazon S3
        /// origin, specify none for the Forward element.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: all | none | whitelist
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Forward")]
        public Union<string, IntrinsicFunction> Forward { get; set; }

        /// <summary>
        /// WhitelistedNames
        /// 		
        /// This field is deprecated. We recommend that you use a cache policy or an origin 			request policy
        /// instead of this field.
        /// 		
        /// If you want to include cookies in the cache key, use a cache policy. For more information, 			see
        /// Creating cache policies in the Amazon CloudFront Developer Guide.
        /// 		
        /// If you want to send cookies to the origin but not include them in the cache key, use an 			origin
        /// request policy. For more information, see Creating origin request policies in the 			Amazon
        /// CloudFront Developer Guide.
        /// 		
        /// Required if you specify whitelist for the value of Forward. 			A complex type that specifies how
        /// many different cookies you want CloudFront to forward to the 			origin for this cache behavior and,
        /// if you want to forward selected cookies, the names of 			those cookies.
        /// 		
        /// If you specify all or none for the value of Forward, omit 				WhitelistedNames. If you change the
        /// value of Forward from 			whitelist to all or none and you don&#39;t delete the WhitelistedNames
        /// 			element and its child elements, CloudFront deletes them automatically.
        /// 		
        /// For the current limit on the number of cookie names that you can whitelist for each 			cache
        /// behavior, see 				CloudFront Limits in the AWS General Reference.
        /// 	
        /// Required: Conditional
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WhitelistedNames")]
        public List<Union<string, IntrinsicFunction>> WhitelistedNames { get; set; }

    }
}

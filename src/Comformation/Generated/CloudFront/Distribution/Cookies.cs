using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution Cookies
    /// A complex type that specifies whether you want CloudFront to forward cookies to the origin 			and, if so,
    /// which ones. For more information about forwarding cookies to the origin, see 				How CloudFront Forwards,
    /// Caches, and Logs Cookies in 			the Amazon CloudFront Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cookies.html
    /// </summary>
    public class Cookies
    {

        /// <summary>
        /// WhitelistedNames
        /// 		
        /// Required if you specify whitelist for the value of Forward:. 			A complex type that specifies how
        /// many different cookies you want CloudFront to forward to the 			origin for this cache behavior and,
        /// if you want to forward selected cookies, the names of 			those cookies.
        /// 		
        /// If you specify all or none for the value of Forward, omit 				WhitelistedNames. If you change the
        /// value of Forward from 				whitelist to all or none and you don&#39;t delete the WhitelistedNames
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

        /// <summary>
        /// Forward
        /// 		
        /// Specifies which cookies to forward to the origin for this cache behavior: all, none, or 			the list
        /// of cookies specified in the WhitelistedNames complex type.
        /// 		
        /// Amazon S3 doesn&#39;t process cookies. When the cache behavior is forwarding requests to an 			Amazon S3
        /// origin, specify none for the Forward element.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: all | none | whitelist
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Forward")]
        public Union<string, IntrinsicFunction> Forward { get; set; }

    }
}

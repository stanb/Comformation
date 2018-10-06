using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution Cookies
    /// Cookies is a property of the CloudFront Distribution ForwardedValues property that describes which cookies are
    /// forwarded to the Amazon CloudFront origin.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cookies.html
    /// </summary>
    public class Cookies
    {

        /// <summary>
        /// WhitelistedNames
        /// The names of cookies to forward to the origin for the cache behavior.
        /// Required: Conditional. Required if you specified whitelist for the Forward property.
        /// Type: List of String values
        /// </summary>
        [JsonProperty("WhitelistedNames")]
        public List<Union<string, IntrinsicFunction>> WhitelistedNames { get; set; }

        /// <summary>
        /// Forward
        /// The cookies to forward to the origin of the cache behavior. You can specify none, all, or whitelist.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Forward")]
        public Union<string, IntrinsicFunction> Forward { get; set; }

    }
}

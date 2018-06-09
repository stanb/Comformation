using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution OriginCustomHeader
    /// OriginCustomHeader is a property of the Amazon CloudFront Origin property that specifies the custom headers
    /// CloudFront includes when it forwards requests to your origin.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origincustomheader.html
    /// </summary>
    public class OriginCustomHeader
    {

        /// <summary>
        /// HeaderValue
        /// The value for the header that you specified in the HeaderName property.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("HeaderValue")]
        public Union<string, IntrinsicFunction> HeaderValue { get; set; }

        /// <summary>
        /// HeaderName
        /// The name of a header that CloudFront forwards to your origin. For more information, see Forwarding
        /// Custom Headers to Your Origin (Web Distributions Only) in the Amazon CloudFront Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("HeaderName")]
        public Union<string, IntrinsicFunction> HeaderName { get; set; }

    }
}

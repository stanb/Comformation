using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution OriginCustomHeader
    /// A complex type that contains HeaderName and HeaderValue 			elements, if any, for this distribution.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origincustomheader.html
    /// </summary>
    public class OriginCustomHeader
    {

        /// <summary>
        /// HeaderValue
        /// 		
        /// The value for the header that you specified in the HeaderName 			field.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderValue")]
        public Union<string, IntrinsicFunction> HeaderValue { get; set; }

        /// <summary>
        /// HeaderName
        /// 		
        /// The name of a header that you want CloudFront to forward to your origin. For more 			information,
        /// see Forwarding Custom 				Headers to Your Origin (Web Distributions Only) in the 				Amazon
        /// CloudFront Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderName")]
        public Union<string, IntrinsicFunction> HeaderName { get; set; }

    }
}

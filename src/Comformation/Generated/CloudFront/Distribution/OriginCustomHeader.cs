using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution OriginCustomHeader
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origincustomheader.html
    /// </summary>
    public class OriginCustomHeader
    {

        /// <summary>
        /// HeaderName
        /// 		
        /// The name of a header that you want CloudFront to send to your origin. For more information, see
        /// 			Adding Custom 			Headers to Origin Requests in the Amazon CloudFront Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderName")]
        public Union<string, IntrinsicFunction> HeaderName { get; set; }

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

    }
}

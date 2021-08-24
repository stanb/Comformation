using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution LegacyS3Origin
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-legacys3origin.html
    /// </summary>
    public class LegacyS3Origin
    {

        /// <summary>
        /// DNSName
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DNSName")]
        public Union<string, IntrinsicFunction> DNSName { get; set; }

        /// <summary>
        /// OriginAccessIdentity
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginAccessIdentity")]
        public Union<string, IntrinsicFunction> OriginAccessIdentity { get; set; }

    }
}

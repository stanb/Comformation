using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution LegacyCustomOrigin
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-legacycustomorigin.html
    /// </summary>
    public class LegacyCustomOrigin
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
        /// HTTPPort
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTPPort")]
        public Union<int, IntrinsicFunction> HTTPPort { get; set; }

        /// <summary>
        /// HTTPSPort
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTPSPort")]
        public Union<int, IntrinsicFunction> HTTPSPort { get; set; }

        /// <summary>
        /// OriginProtocolPolicy
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginProtocolPolicy")]
        public Union<string, IntrinsicFunction> OriginProtocolPolicy { get; set; }

        /// <summary>
        /// OriginSSLProtocols
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginSSLProtocols")]
        public List<Union<string, IntrinsicFunction>> OriginSSLProtocols { get; set; }

    }
}

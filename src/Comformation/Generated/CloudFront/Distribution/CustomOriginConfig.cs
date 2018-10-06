using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution CustomOriginConfig
    /// CustomOriginConfig is a property of the Amazon CloudFront Origin property that describes an HTTP server.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html
    /// </summary>
    public class CustomOriginConfig
    {

        /// <summary>
        /// OriginReadTimeout
        /// You can create a custom origin read timeout. All timeout units are in seconds. The default origin
        /// read timeout is 30 seconds, but you can configure custom timeout lengths. The minimum timeout length
        /// is 4 seconds; the maximum is 60 seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginReadTimeout")]
        public Union<int, IntrinsicFunction> OriginReadTimeout { get; set; }

        /// <summary>
        /// HTTPSPort
        /// The HTTPS port the custom origin listens on.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("HTTPSPort")]
        public Union<int, IntrinsicFunction> HTTPSPort { get; set; }

        /// <summary>
        /// OriginKeepaliveTimeout
        /// You can create a custom keep-alive timeout. All timeout units are in seconds. The default keep-alive
        /// timeout is 5 seconds, but you can configure custom timeout lengths. The minimum timeout length is 1
        /// second; the maximum is 60 seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginKeepaliveTimeout")]
        public Union<int, IntrinsicFunction> OriginKeepaliveTimeout { get; set; }

        /// <summary>
        /// OriginSSLProtocols
        /// The SSL protocols that CloudFront can use when establishing an HTTPS connection with your origin. By
        /// default, AWS CloudFormation specifies the TLSv1 and SSLv3 protocols.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("OriginSSLProtocols")]
        public List<Union<string, IntrinsicFunction>> OriginSSLProtocols { get; set; }

        /// <summary>
        /// HTTPPort
        /// The HTTP port the custom origin listens on.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("HTTPPort")]
        public Union<int, IntrinsicFunction> HTTPPort { get; set; }

        /// <summary>
        /// OriginProtocolPolicy
        /// The origin protocol policy to apply to your origin.
        /// Required: Yes
        /// Type: String
        /// Valid Values: http-only, match-viewer, https-only
        /// </summary>
        [JsonProperty("OriginProtocolPolicy")]
        public Union<string, IntrinsicFunction> OriginProtocolPolicy { get; set; }

    }
}

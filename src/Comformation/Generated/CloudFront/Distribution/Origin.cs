using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution Origin
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html
    /// </summary>
    public class Origin
    {

        /// <summary>
        /// ConnectionTimeout
        /// 		
        /// The number of seconds that CloudFront waits when trying to establish a connection to the origin.
        /// 			The minimum timeout is 1 second, the maximum is 10 seconds, and the default (if you 			don’t
        /// specify otherwise) is 10 seconds.
        /// 		
        /// For more information, see Origin Connection Timeout in the 			Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionTimeout")]
        public Union<int, IntrinsicFunction> ConnectionTimeout { get; set; }

        /// <summary>
        /// OriginCustomHeaders
        /// 		
        /// A list of HTTP header names and values that CloudFront adds to the requests that it sends to the
        /// origin.
        /// 		
        /// For more information, see Adding Custom Headers to Origin Requests in the 			Amazon CloudFront
        /// Developer Guide.
        /// 	
        /// Required: No
        /// Type: List of OriginCustomHeader
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginCustomHeaders")]
        public List<OriginCustomHeader> OriginCustomHeaders { get; set; }

        /// <summary>
        /// ConnectionAttempts
        /// 		
        /// The number of times that CloudFront attempts to connect to the origin. The minimum number is 1, the
        /// maximum is 3, and the default (if you don’t specify otherwise) is 3.
        /// For a custom origin (including an Amazon S3 bucket that’s configured with static website hosting),
        /// this value also specifies the number of times that CloudFront attempts to get a response from the
        /// origin, in the case of an Origin Response Timeout.
        /// For more information, see Origin Connection Attempts in the 			Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionAttempts")]
        public Union<int, IntrinsicFunction> ConnectionAttempts { get; set; }

        /// <summary>
        /// DomainName
        /// 		
        /// The domain name for the origin.
        /// 		
        /// For more information, see Origin Domain Name in the Amazon CloudFront Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DomainName")]
        public Union<string, IntrinsicFunction> DomainName { get; set; }

        /// <summary>
        /// OriginShield
        /// 		
        /// CloudFront Origin Shield. Using Origin Shield can help reduce the load on your origin.
        /// 		
        /// For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: OriginShield
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginShield")]
        public OriginShield OriginShield { get; set; }

        /// <summary>
        /// S3OriginConfig
        /// 		
        /// Use this type to specify an origin that is an Amazon S3 bucket that is not configured with static
        /// 			website hosting. To specify any other type of origin, including an Amazon S3 bucket that is
        /// 			configured with static website hosting, use the CustomOriginConfig type 			instead.
        /// 	
        /// Required: Conditional
        /// Type: S3OriginConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3OriginConfig")]
        public S3OriginConfig S3OriginConfig { get; set; }

        /// <summary>
        /// OriginPath
        /// 		
        /// An optional path that CloudFront appends to the origin domain name when CloudFront requests content
        /// from 			the origin.
        /// 		
        /// For more information, see Origin Path in the 			Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginPath")]
        public Union<string, IntrinsicFunction> OriginPath { get; set; }

        /// <summary>
        /// Id
        /// 		
        /// A unique identifier for the origin. This value must be unique within the 			distribution.
        /// Use this value to specify the TargetOriginId in a CacheBehavior or DefaultCacheBehavior.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// CustomOriginConfig
        /// 		
        /// Use this type to specify an origin that is not an Amazon S3 bucket, with one exception. If the
        /// 			Amazon S3 bucket is configured with static website hosting, use this type. If the Amazon S3
        /// bucket 			is not configured with static website hosting, use the S3OriginConfig type 			instead.
        /// 	
        /// Required: Conditional
        /// Type: CustomOriginConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomOriginConfig")]
        public CustomOriginConfig CustomOriginConfig { get; set; }

    }
}

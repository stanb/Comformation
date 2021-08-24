using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution CustomOriginConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html
    /// </summary>
    public class CustomOriginConfig
    {

        /// <summary>
        /// HTTPPort
        /// 		
        /// The HTTP port that CloudFront uses to connect to the origin. Specify the HTTP port that the origin
        /// 			listens on.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTPPort")]
        public Union<int, IntrinsicFunction> HTTPPort { get; set; }

        /// <summary>
        /// HTTPSPort
        /// 		
        /// The HTTPS port that CloudFront uses to connect to the origin. Specify the HTTPS port that the
        /// 			origin listens on.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTPSPort")]
        public Union<int, IntrinsicFunction> HTTPSPort { get; set; }

        /// <summary>
        /// OriginKeepaliveTimeout
        /// 		
        /// Specifies how long, in seconds, CloudFront persists its connection to the origin. The minimum
        /// 			timeout is 1 second, the maximum is 60 seconds, and the default (if you don’t specify
        /// 			otherwise) is 5 seconds.
        /// 		
        /// For more information, see Origin Keep-alive Timeout in the 			Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginKeepaliveTimeout")]
        public Union<int, IntrinsicFunction> OriginKeepaliveTimeout { get; set; }

        /// <summary>
        /// OriginProtocolPolicy
        /// 		
        /// Specifies the protocol (HTTP or HTTPS) that CloudFront uses to connect to the origin. Valid values
        /// 			are:
        /// 		
        /// 			 			 			 		 				 http-only – CloudFront always uses HTTP to connect to the 					origin. 			 				
        /// match-viewer – CloudFront connects to the origin using the same 					protocol that the viewer used
        /// to connect to CloudFront. 			 				 https-only – CloudFront always uses HTTPS to connect to the
        /// 					origin. 			
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: http-only | https-only | match-viewer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginProtocolPolicy")]
        public Union<string, IntrinsicFunction> OriginProtocolPolicy { get; set; }

        /// <summary>
        /// OriginReadTimeout
        /// 		
        /// Specifies how long, in seconds, CloudFront waits for a response from the origin. This is also
        /// 			known as the origin response timeout. The minimum timeout is 1 			second, the maximum is 60
        /// seconds, and the default (if you don’t specify otherwise) is 			30 seconds.
        /// 		
        /// For more information, see Origin Response Timeout in the 			Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginReadTimeout")]
        public Union<int, IntrinsicFunction> OriginReadTimeout { get; set; }

        /// <summary>
        /// OriginSSLProtocols
        /// 		
        /// Specifies the minimum SSL/TLS protocol that CloudFront uses when connecting to your origin over
        /// 			HTTPS. Valid values include SSLv3, TLSv1, 			TLSv1. 1, and TLSv1. 2.
        /// 		
        /// For more information, see Minimum Origin SSL Protocol in the 			Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginSSLProtocols")]
        public List<Union<string, IntrinsicFunction>> OriginSSLProtocols { get; set; }

    }
}

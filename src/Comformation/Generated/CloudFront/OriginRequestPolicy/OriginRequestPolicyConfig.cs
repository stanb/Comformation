using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.OriginRequestPolicy
{
    /// <summary>
    /// AWS::CloudFront::OriginRequestPolicy OriginRequestPolicyConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-originrequestpolicyconfig.html
    /// </summary>
    public class OriginRequestPolicyConfig
    {

        /// <summary>
        /// Comment
        /// 		
        /// A comment to describe the origin request policy. The comment cannot be longer than 128
        /// 			characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// CookiesConfig
        /// 		
        /// The cookies from viewer requests to include in origin requests.
        /// 	
        /// Required: Yes
        /// Type: CookiesConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CookiesConfig")]
        public CookiesConfig CookiesConfig { get; set; }

        /// <summary>
        /// HeadersConfig
        /// The HTTP headers to include in origin requests. These can include headers from viewer 			requests
        /// and additional headers added by CloudFront.
        /// Required: Yes
        /// Type: HeadersConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeadersConfig")]
        public HeadersConfig HeadersConfig { get; set; }

        /// <summary>
        /// Name
        /// 		
        /// A unique name to identify the origin request policy.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// QueryStringsConfig
        /// 		
        /// The URL query strings from viewer requests to include in origin requests.
        /// 	
        /// Required: Yes
        /// Type: QueryStringsConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryStringsConfig")]
        public QueryStringsConfig QueryStringsConfig { get; set; }

    }
}

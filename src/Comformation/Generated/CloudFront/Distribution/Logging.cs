using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution Logging
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-logging.html
    /// </summary>
    public class Logging
    {

        /// <summary>
        /// Bucket
        /// 		
        /// The Amazon S3 bucket to store the access logs in, for example, 				myawslogbucket. s3. amazonaws.
        /// com.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// IncludeCookies
        /// 		
        /// Specifies whether you want CloudFront to include cookies in access logs, specify 				true for
        /// IncludeCookies. If you choose to include cookies in logs, 			CloudFront logs all cookies regardless
        /// of how you configure the cache behaviors for this 			distribution. If you don&#39;t want to include
        /// cookies when you create a distribution or if you 			want to disable include cookies for an existing
        /// distribution, specify false for 				IncludeCookies.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeCookies")]
        public Union<bool, IntrinsicFunction> IncludeCookies { get; set; }

        /// <summary>
        /// Prefix
        /// 		
        /// An optional string that you want CloudFront to prefix to the access log 				filenames for this
        /// distribution, for example, myprefix/. If you 			want to enable logging, but you don&#39;t want to
        /// specify a prefix, you still must include an 			empty Prefix element in the Logging element.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    /// AWS::CloudFront::StreamingDistribution Logging
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-logging.html
    /// </summary>
    public class Logging
    {

        /// <summary>
        /// Bucket
        /// 		
        /// The Amazon S3 bucket to store the access logs in, for example, myawslogbucket. s3. amazonaws. com.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Enabled
        /// 		
        /// Specifies whether you want CloudFront to save access logs to an Amazon S3 bucket. If you don&#39;t
        /// 			want to enable logging when you create a streaming distribution or if you want to disable
        /// 			logging for an existing streaming distribution, specify false for 				Enabled, and specify empty
        /// Bucket and Prefix 			elements. If you specify false for Enabled but you specify values 			for Bucket
        /// and Prefix, the values are automatically deleted. 		
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// Prefix
        /// 		
        /// An optional string that you want CloudFront to prefix to the access log filenames for this streaming
        /// distribution, for example, 			myprefix/. If you want to enable logging, but you don&#39;t want to
        /// specify a prefix, you still must include 			an empty Prefix element in the Logging element.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

    }
}

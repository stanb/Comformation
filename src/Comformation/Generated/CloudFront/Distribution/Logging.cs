using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution Logging
    /// Logging is a property of the DistributionConfig property that enables Amazon CloudFront to deliver access logs
    /// for each distribution to an Amazon Simple Storage Service (S3) bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-logging.html
    /// </summary>
    public class Logging
    {

        /// <summary>
        /// IncludeCookies
        /// Indicates whether CloudFront includes cookies in access logs.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("IncludeCookies")]
        public Union<bool, IntrinsicFunction> IncludeCookies { get; set; }

        /// <summary>
        /// Bucket
        /// The Amazon S3 bucket address where access logs are stored, for example, mybucket. s3. amazonaws.
        /// com.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Prefix
        /// A prefix for the access log file names for this distribution.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

    }
}

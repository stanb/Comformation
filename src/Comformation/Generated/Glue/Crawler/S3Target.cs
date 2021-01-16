using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS::Glue::Crawler S3Target
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html
    /// </summary>
    public class S3Target
    {

        /// <summary>
        /// ConnectionName
        /// 	
        /// The name of a connection which allows a job or crawler to access data in Amazon S3 within an Amazon
        /// Virtual Private Cloud environment (Amazon VPC).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionName")]
        public Union<string, IntrinsicFunction> ConnectionName { get; set; }

        /// <summary>
        /// Path
        /// The path to the Amazon S3 target.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// Exclusions
        /// A list of glob patterns used to exclude from the crawl. For more information, see Catalog Tables
        /// with a Crawler.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exclusions")]
        public List<Union<string, IntrinsicFunction>> Exclusions { get; set; }

    }
}

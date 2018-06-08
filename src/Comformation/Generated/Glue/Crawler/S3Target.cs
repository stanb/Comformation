using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS Glue Crawler S3Target
    /// The S3Target property type specifies an Amazon S3 target for an AWS Glue crawl.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html
    /// </summary>
    public class S3Target
    {

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
        /// A list of UTF-8 strings that specify the Amazon S3 objects to exclude from the crawl.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exclusions")]
        public Union<List<string>, IntrinsicFunction> Exclusions { get; set; }

    }
}

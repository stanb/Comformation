using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS Glue Crawler JdbcTarget
    /// The JdbcTarget property type specifies a JDBC target for an AWS Glue crawl.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-jdbctarget.html
    /// </summary>
    public class JdbcTarget
    {

        /// <summary>
        /// ConnectionName
        /// The name of the connection to use for the JDBC target.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionName")]
        public Union<string, IntrinsicFunction> ConnectionName { get; set; }

        /// <summary>
        /// Path
        /// The path of the JDBC target.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// Exclusions
        /// A list of UTF-8 strings that specify the items to exclude from the crawl.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exclusions")]
        public Union<List<string>, IntrinsicFunction> Exclusions { get; set; }

    }
}

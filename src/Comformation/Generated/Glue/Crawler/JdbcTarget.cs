using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS::Glue::Crawler JdbcTarget
    /// Specifies a JDBC data store to crawl.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-jdbctarget.html
    /// </summary>
    public class JdbcTarget
    {

        /// <summary>
        /// ConnectionName
        /// The name of the connection to use to connect to the JDBC target.
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

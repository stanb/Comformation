using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS::Glue::Crawler Targets
    /// Specifies data stores to crawl.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html
    /// </summary>
    public class Targets
    {

        /// <summary>
        /// S3Targets
        /// Specifies Amazon Simple Storage Service (Amazon S3) targets.
        /// Required: No
        /// Type: List of S3Target
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Targets")]
        public List<S3Target> S3Targets { get; set; }

        /// <summary>
        /// JdbcTargets
        /// Specifies JDBC targets.
        /// Required: No
        /// Type: List of JdbcTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JdbcTargets")]
        public List<JdbcTarget> JdbcTargets { get; set; }

    }
}

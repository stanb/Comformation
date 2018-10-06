using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS Glue Crawler Targets
    /// The Targets property type specifies AWS Glue crawler targets.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html
    /// </summary>
    public class Targets
    {

        /// <summary>
        /// S3Targets
        /// The Amazon S3 crawler targets.
        /// Required: No
        /// Type: List of AWS Glue Crawler S3Target
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Targets")]
        public List<S3Target> S3Targets { get; set; }

        /// <summary>
        /// JdbcTargets
        /// The JDBC crawler targets.
        /// Required: No
        /// Type: List of AWS Glue Crawler JdbcTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JdbcTargets")]
        public List<JdbcTarget> JdbcTargets { get; set; }

    }
}

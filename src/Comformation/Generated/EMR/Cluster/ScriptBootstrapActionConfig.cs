using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster ScriptBootstrapActionConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scriptbootstrapactionconfig.html
    /// </summary>
    public class ScriptBootstrapActionConfig
    {

        /// <summary>
        /// Args
        /// A list of command line arguments to pass to the bootstrap action script.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Args")]
        public List<Union<string, IntrinsicFunction>> Args { get; set; }

        /// <summary>
        /// Path
        /// Location in Amazon S3 of the script to run during a bootstrap action.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 10280
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster ScriptBootstrapActionConfig
    /// ScriptBootstrapActionConfig is a subproperty of the BootstrapActionConfig property type.
    /// ScriptBootstrapActionConfig specifies the arguments and location of the bootstrap script for EMR to run on all
    /// cluster nodes before it installs open-source big data applications on them.
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
        /// Location of the script to run during a bootstrap action. Can be either a location in Amazon S3 or on
        /// a local file system.
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

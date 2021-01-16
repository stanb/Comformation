using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster BootstrapActionConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-bootstrapactionconfig.html
    /// </summary>
    public class BootstrapActionConfig
    {

        /// <summary>
        /// Name
        /// The name of the bootstrap action.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// ScriptBootstrapAction
        /// The script run by the bootstrap action.
        /// Required: Yes
        /// Type: ScriptBootstrapActionConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScriptBootstrapAction")]
        public ScriptBootstrapActionConfig ScriptBootstrapAction { get; set; }

    }
}

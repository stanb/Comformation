using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster BootstrapActionConfig
    /// BootstrapActionConfig is a property of AWS::EMR::Cluster that can be used to run bootstrap actions on EMR
    /// clusters. You can use a bootstrap action to install software and configure EC2 instances for all cluster nodes
    /// before EMR installs and configures open-source big data applications on cluster instances. For more
    /// information, see Create Bootstrap Actions to Install Additional Software in the Amazon EMR Management Guide.
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

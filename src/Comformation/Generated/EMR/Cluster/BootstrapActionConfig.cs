using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster BootstrapActionConfig
    /// BootstrapActionConfig is a property of the AWS::EMR::Cluster resource that specifies bootstrap actions that
    /// Amazon EMR (Amazon EMR) runs before it installs applications on the cluster nodes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-bootstrapactionconfig.html
    /// </summary>
    public class BootstrapActionConfig
    {

        /// <summary>
        /// Name
        /// The name of the bootstrap action to add to your cluster.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// ScriptBootstrapAction
        /// The script that the bootstrap action runs.
        /// Required: Yes
        /// Type: Amazon EMR Cluster ScriptBootstrapActionConfig
        /// </summary>
        [JsonProperty("ScriptBootstrapAction")]
        public Union<ScriptBootstrapActionConfig, IntrinsicFunction> ScriptBootstrapAction { get; set; }

    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster ScriptBootstrapActionConfig
    /// ScriptBootstrapActionConfig is a property of the Amazon EMR Cluster BootstrapActionConfig property that
    /// specifies the arguments and location of the bootstrap script that Amazon EMR (Amazon EMR) runs before it
    /// installs applications on the cluster nodes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-bootstrapactionconfig-scriptbootstrapactionconfig.html
    /// </summary>
    public class ScriptBootstrapActionConfig
    {

        /// <summary>
        /// Args
        /// A list of command line arguments to pass to the bootstrap action script.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Args")]
        public Union<List<string>, IntrinsicFunction> Args { get; set; }

        /// <summary>
        /// Path
        /// The location of the script that Amazon EMR runs during a bootstrap action. Specify a location in an
        /// S3 bucket or your local file system.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster Application
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-application.html
    /// </summary>
    public class Application
    {

        /// <summary>
        /// AdditionalInfo
        /// This option is for advanced users only. This is meta information about clusters and applications
        /// that are used for testing and troubleshooting.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdditionalInfo")]
        public Dictionary<string, Union<string, IntrinsicFunction>> AdditionalInfo { get; set; }

        /// <summary>
        /// Args
        /// Arguments for Amazon EMR to pass to the application.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Args")]
        public List<Union<string, IntrinsicFunction>> Args { get; set; }

        /// <summary>
        /// Name
        /// The name of the application.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Version
        /// The version of the application.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}

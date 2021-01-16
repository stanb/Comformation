using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster Configuration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html
    /// </summary>
    public class Configuration
    {

        /// <summary>
        /// Classification
        /// The classification within a configuration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Classification")]
        public Union<string, IntrinsicFunction> Classification { get; set; }

        /// <summary>
        /// ConfigurationProperties
        /// A list of additional configurations to apply within a configuration object.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfigurationProperties")]
        public Dictionary<string, Union<string, IntrinsicFunction>> ConfigurationProperties { get; set; }

        /// <summary>
        /// Configurations
        /// A list of additional configurations to apply within a configuration object.
        /// Required: No
        /// Type: List of Configuration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Configurations")]
        public List<Configuration> Configurations { get; set; }

    }
}

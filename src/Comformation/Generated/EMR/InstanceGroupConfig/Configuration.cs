using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// AWS::EMR::InstanceGroupConfig Configuration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-configuration.html
    /// </summary>
    public class Configuration
    {

        /// <summary>
        /// Classification
        /// The classification within a configuration.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Classification")]
        public Union<string, IntrinsicFunction> Classification { get; set; }

        /// <summary>
        /// ConfigurationProperties
        /// Within a configuration classification, a set of properties that represent the settings that you want
        /// to change in the configuration file. Duplicates not allowed.
        /// Required: No
        /// Type: Map of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ConfigurationProperties")]
        public Dictionary<string, Union<string, IntrinsicFunction>> ConfigurationProperties { get; set; }

        /// <summary>
        /// Configurations
        /// A list of additional configurations to apply within a configuration object.
        /// Required: No
        /// Type: List of Configuration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Configurations")]
        public List<Configuration> Configurations { get; set; }

    }
}

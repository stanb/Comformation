using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// Amazon EMR InstanceFleetConfig Configuration
    /// Use the Configuration property to configure fleet instances for Amazon EMR and applications and software
    /// bundled with Amazon EMR. For more information, see Configuring Applications in the Amazon EMR Release Guide.
    /// Configuration is a subproperty of the Amazon EMR InstanceFleetConfig InstanceTypeConfig property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-configuration.html
    /// </summary>
    public class Configuration
    {

        /// <summary>
        /// Classification
        /// The application-specific configuration file.
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
        /// Type: String to String map
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ConfigurationProperties")]
        public Union<Dictionary<string, string>, IntrinsicFunction> ConfigurationProperties { get; set; }

        /// <summary>
        /// Configurations
        /// The list of additional configurations to apply within a configuration object. Duplicates not
        /// allowed.
        /// Required: No
        /// Type: List of Amazon EMR InstanceFleetConfig Configuration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Configurations")]
        public Union<List<Configuration>, IntrinsicFunction> Configurations { get; set; }

    }
}

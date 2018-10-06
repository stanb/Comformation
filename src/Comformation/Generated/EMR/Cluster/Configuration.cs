using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster Configurations
    /// Configurations is a property of the AWS::EMR::Cluster resource that specifies the software configuration of an
    /// Amazon EMR (Amazon EMR) cluster. For example configurations, see Configuring Applications in the Amazon EMR
    /// Release Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-configuration.html
    /// </summary>
    public class Configuration
    {

        /// <summary>
        /// Classification
        /// The name of an application-specific configuration file. For more information see, Configuring
        /// Applications in the Amazon EMR Release Guide.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Classification")]
        public Union<string, IntrinsicFunction> Classification { get; set; }

        /// <summary>
        /// ConfigurationProperties
        /// The settings that you want to change in the application-specific configuration file. For more
        /// information see, Configuring Applications in the Amazon EMR Release Guide.
        /// Required: No
        /// Type: String-to-string map
        /// </summary>
        [JsonProperty("ConfigurationProperties")]
        public Dictionary<string, Union<string, IntrinsicFunction>> ConfigurationProperties { get; set; }

        /// <summary>
        /// Configurations
        /// A list of configurations to apply to this configuration. You can nest configurations so that a
        /// single configuration can have its own configurations. In other words, you can configure a
        /// configuration. For more information see, Configuring Applications in the Amazon EMR Release Guide.
        /// Required: No
        /// Type: List of Amazon EMR Cluster Configurations
        /// </summary>
        [JsonProperty("Configurations")]
        public List<Configuration> Configurations { get; set; }

    }
}

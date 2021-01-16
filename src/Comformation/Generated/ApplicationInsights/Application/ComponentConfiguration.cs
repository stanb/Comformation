using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application ComponentConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentconfiguration.html
    /// </summary>
    public class ComponentConfiguration
    {

        /// <summary>
        /// ConfigurationDetails
        /// The configuration settings.
        /// Required: No
        /// Type: ConfigurationDetails
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfigurationDetails")]
        public ConfigurationDetails ConfigurationDetails { get; set; }

        /// <summary>
        /// SubComponentTypeConfigurations
        /// Sub-component configurations of the component.
        /// Required: No
        /// Type: List of SubComponentTypeConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubComponentTypeConfigurations")]
        public List<SubComponentTypeConfiguration> SubComponentTypeConfigurations { get; set; }

    }
}

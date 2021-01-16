using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application SubComponentTypeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponenttypeconfiguration.html
    /// </summary>
    public class SubComponentTypeConfiguration
    {

        /// <summary>
        /// SubComponentType
        /// The sub-component type.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubComponentType")]
        public Union<string, IntrinsicFunction> SubComponentType { get; set; }

        /// <summary>
        /// SubComponentConfigurationDetails
        /// The configuration settings of the sub-components.
        /// Required: Yes
        /// Type: SubComponentConfigurationDetails
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubComponentConfigurationDetails")]
        public SubComponentConfigurationDetails SubComponentConfigurationDetails { get; set; }

    }
}

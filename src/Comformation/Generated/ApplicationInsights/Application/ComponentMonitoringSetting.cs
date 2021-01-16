using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application ComponentMonitoringSetting
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-componentmonitoringsetting.html
    /// </summary>
    public class ComponentMonitoringSetting
    {

        /// <summary>
        /// ComponentName
        /// The name of the component.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComponentName")]
        public Union<string, IntrinsicFunction> ComponentName { get; set; }

        /// <summary>
        /// ComponentARN
        /// The ARN of the component.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComponentARN")]
        public Union<string, IntrinsicFunction> ComponentARN { get; set; }

        /// <summary>
        /// Tier
        /// The tier of the application component. Supported tiers include DOT_NET_WORKER, DOT_NET_WEB,
        /// DOT_NET_CORE, SQL_SERVER, and DEFAULT.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tier")]
        public Union<string, IntrinsicFunction> Tier { get; set; }

        /// <summary>
        /// ComponentConfigurationMode
        /// Component monitoring can be configured in one of the following three modes:
        /// DEFAULT: The component will be configured with the recommended default monitoring settings of the
        /// selected Tier. CUSTOM: The component will be configured with the customized monitoring settings that
        /// are specified in CustomComponentConfiguration. If used, CustomComponentConfiguration must be
        /// provided. DEFAULT_WITH_OVERWRITE: The component will be configured with the recommended default
        /// monitoring settings of the selected Tier, and merged with customized overwrite settings that are
        /// specified in DefaultOverwriteComponentConfiguration. If used, DefaultOverwriteComponentConfiguration
        /// must be provided.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComponentConfigurationMode")]
        public Union<string, IntrinsicFunction> ComponentConfigurationMode { get; set; }

        /// <summary>
        /// DefaultOverwriteComponentConfiguration
        /// Customized overwrite monitoring settings. Required if CUSTOM mode is configured in
        /// ComponentConfigurationMode.
        /// Required: No
        /// Type: ComponentConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultOverwriteComponentConfiguration")]
        public ComponentConfiguration DefaultOverwriteComponentConfiguration { get; set; }

        /// <summary>
        /// CustomComponentConfiguration
        /// Customized monitoring settings. Required if CUSTOM mode is configured in ComponentConfigurationMode.
        /// Required: No
        /// Type: ComponentConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomComponentConfiguration")]
        public ComponentConfiguration CustomComponentConfiguration { get; set; }

    }
}

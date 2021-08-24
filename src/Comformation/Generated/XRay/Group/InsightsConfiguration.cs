using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.XRay.Group
{
    /// <summary>
    /// AWS::XRay::Group InsightsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-xray-group-insightsconfiguration.html
    /// </summary>
    public class InsightsConfiguration
    {

        /// <summary>
        /// InsightsEnabled
        /// Set the InsightsEnabled value to true to enable insights or false to disable insights.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InsightsEnabled")]
        public Union<bool, IntrinsicFunction> InsightsEnabled { get; set; }

        /// <summary>
        /// NotificationsEnabled
        /// Set the NotificationsEnabled value to true to enable insights notifications. Notifications can only
        /// be enabled on a group with InsightsEnabled set to true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationsEnabled")]
        public Union<bool, IntrinsicFunction> NotificationsEnabled { get; set; }

    }
}

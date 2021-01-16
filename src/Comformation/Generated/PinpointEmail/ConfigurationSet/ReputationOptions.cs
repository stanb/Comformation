using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSet
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSet ReputationOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-reputationoptions.html
    /// </summary>
    public class ReputationOptions
    {

        /// <summary>
        /// ReputationMetricsEnabled
        /// If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of
        /// reputation metrics is disabled for the configuration set.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReputationMetricsEnabled")]
        public Union<bool, IntrinsicFunction> ReputationMetricsEnabled { get; set; }

    }
}

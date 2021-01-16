using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel FeatureActivations
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-featureactivations.html
    /// </summary>
    public class FeatureActivations
    {

        /// <summary>
        /// InputPrepareScheduleActions
        /// Enables the Input Prepare feature. You can create Input Prepare actions in the schedule only if this
        /// feature is enabled. If you disable the feature on an existing schedule, make sure that you first
        /// delete all input prepare actions from the schedule.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputPrepareScheduleActions")]
        public Union<string, IntrinsicFunction> InputPrepareScheduleActions { get; set; }

    }
}

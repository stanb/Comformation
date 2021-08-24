using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel FailoverCondition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-failovercondition.html
    /// </summary>
    public class FailoverCondition
    {

        /// <summary>
        /// FailoverConditionSettings
        /// Settings for a specific failover condition.
        /// Required: No
        /// Type: FailoverConditionSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailoverConditionSettings")]
        public FailoverConditionSettings FailoverConditionSettings { get; set; }

    }
}

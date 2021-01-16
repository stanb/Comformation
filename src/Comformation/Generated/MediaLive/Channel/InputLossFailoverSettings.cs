using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel InputLossFailoverSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossfailoversettings.html
    /// </summary>
    public class InputLossFailoverSettings
    {

        /// <summary>
        /// InputLossThresholdMsec
        /// The amount of time (in milliseconds) that no input is detected. After that time, an input failover
        /// will occur.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossThresholdMsec")]
        public Union<int, IntrinsicFunction> InputLossThresholdMsec { get; set; }

    }
}

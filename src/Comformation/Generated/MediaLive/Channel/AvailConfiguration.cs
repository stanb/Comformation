using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AvailConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-availconfiguration.html
    /// </summary>
    public class AvailConfiguration
    {

        /// <summary>
        /// AvailSettings
        /// The setup of ad avail handling in the output.
        /// Required: No
        /// Type: AvailSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailSettings")]
        public AvailSettings AvailSettings { get; set; }

    }
}

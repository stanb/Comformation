using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel UdpContainerSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpcontainersettings.html
    /// </summary>
    public class UdpContainerSettings
    {

        /// <summary>
        /// M2tsSettings
        /// The M2TS configuration for this UDP output.
        /// Required: No
        /// Type: M2tsSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("M2tsSettings")]
        public M2tsSettings M2tsSettings { get; set; }

    }
}

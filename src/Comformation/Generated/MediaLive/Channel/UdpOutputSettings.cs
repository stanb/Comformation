using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel UdpOutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-udpoutputsettings.html
    /// </summary>
    public class UdpOutputSettings
    {

        /// <summary>
        /// Destination
        /// The destination address and port number for RTP or UDP packets. These can be unicast or multicast
        /// RTP or UDP (for example, rtp://239. 10. 10. 10:5001 or udp://10. 100. 100. 100:5002).
        /// Required: No
        /// Type: OutputLocationRef
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// FecOutputSettings
        /// The settings for enabling and adjusting Forward Error Correction on UDP outputs.
        /// Required: No
        /// Type: FecOutputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FecOutputSettings")]
        public FecOutputSettings FecOutputSettings { get; set; }

        /// <summary>
        /// ContainerSettings
        /// The settings for the UDP output.
        /// Required: No
        /// Type: UdpContainerSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainerSettings")]
        public UdpContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// BufferMsec
        /// The UDP output buffering in milliseconds. Larger values increase latency through the transcoder but
        /// simultaneously assist the transcoder in maintaining a constant, low-jitter UDP/RTP output while
        /// accommodating clock recovery, input switching, input disruptions, picture reordering, and so on.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufferMsec")]
        public Union<int, IntrinsicFunction> BufferMsec { get; set; }

    }
}

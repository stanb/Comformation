using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.LaunchProfile
{
    /// <summary>
    /// AWS::NimbleStudio::LaunchProfile StreamConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-launchprofile-streamconfiguration.html
    /// </summary>
    public class StreamConfiguration
    {

        /// <summary>
        /// ClipboardMode
        /// Enable or disable the use of the system clipboard to copy and paste between the streaming session
        /// and streaming client.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClipboardMode")]
        public Union<string, IntrinsicFunction> ClipboardMode { get; set; }

        /// <summary>
        /// StreamingImageIds
        /// The streaming images that users can select from when launching a streaming session with this launch
        /// profile.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamingImageIds")]
        public List<Union<string, IntrinsicFunction>> StreamingImageIds { get; set; }

        /// <summary>
        /// Ec2InstanceTypes
        /// The EC2 instance types that users can select from when launching a streaming session with this
        /// launch profile.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ec2InstanceTypes")]
        public List<Union<string, IntrinsicFunction>> Ec2InstanceTypes { get; set; }

        /// <summary>
        /// MaxSessionLengthInMinutes
        /// The length of time, in minutes, that a streaming session can run. After this point, Nimble Studio
        /// automatically terminates the session.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxSessionLengthInMinutes")]
        public Union<double, IntrinsicFunction> MaxSessionLengthInMinutes { get; set; }

    }
}

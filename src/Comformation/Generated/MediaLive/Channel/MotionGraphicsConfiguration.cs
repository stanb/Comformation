using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel MotionGraphicsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-motiongraphicsconfiguration.html
    /// </summary>
    public class MotionGraphicsConfiguration
    {

        /// <summary>
        /// MotionGraphicsSettings
        /// Settings to enable and configure the motion graphics overlay feature in the channel.
        /// Required: No
        /// Type: MotionGraphicsSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MotionGraphicsSettings")]
        public MotionGraphicsSettings MotionGraphicsSettings { get; set; }

        /// <summary>
        /// MotionGraphicsInsertion
        /// Enables or disables the motion graphics overlay feature in the channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MotionGraphicsInsertion")]
        public Union<string, IntrinsicFunction> MotionGraphicsInsertion { get; set; }

    }
}

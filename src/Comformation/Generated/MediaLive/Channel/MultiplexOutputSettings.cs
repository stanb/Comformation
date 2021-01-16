using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel MultiplexOutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexoutputsettings.html
    /// </summary>
    public class MultiplexOutputSettings
    {

        /// <summary>
        /// Destination
        /// Destination is a Multiplex.
        /// Required: No
        /// Type: OutputLocationRef
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public OutputLocationRef Destination { get; set; }

    }
}

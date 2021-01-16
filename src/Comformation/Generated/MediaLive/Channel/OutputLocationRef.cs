using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel OutputLocationRef
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputlocationref.html
    /// </summary>
    public class OutputLocationRef
    {

        /// <summary>
        /// DestinationRefId
        /// A reference ID for this destination.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationRefId")]
        public Union<string, IntrinsicFunction> DestinationRefId { get; set; }

    }
}

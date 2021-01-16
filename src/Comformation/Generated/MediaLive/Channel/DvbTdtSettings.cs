using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel DvbTdtSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbtdtsettings.html
    /// </summary>
    public class DvbTdtSettings
    {

        /// <summary>
        /// RepInterval
        /// The number of milliseconds between instances of this table in the output transport stream.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RepInterval")]
        public Union<int, IntrinsicFunction> RepInterval { get; set; }

    }
}

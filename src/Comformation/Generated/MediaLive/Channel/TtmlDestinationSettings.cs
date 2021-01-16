using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel TtmlDestinationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ttmldestinationsettings.html
    /// </summary>
    public class TtmlDestinationSettings
    {

        /// <summary>
        /// StyleControl
        /// When set to passthrough, passes through style and position information from a TTML-like input source
        /// (TTML, SMPTE-TT, CFF-TT) to the CFF-TT output or TTML output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StyleControl")]
        public Union<string, IntrinsicFunction> StyleControl { get; set; }

    }
}

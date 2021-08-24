using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel TeletextSourceSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-teletextsourcesettings.html
    /// </summary>
    public class TeletextSourceSettings
    {

        /// <summary>
        /// OutputRectangle
        /// Settings to configure the caption rectangle for an output captions that will be created using this
        /// Teletext source captions.
        /// Required: No
        /// Type: CaptionRectangle
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputRectangle")]
        public CaptionRectangle OutputRectangle { get; set; }

        /// <summary>
        /// PageNumber
        /// Specifies the Teletext page number within the data stream from which to extract captions. The range
        /// is 0x100 (256) to 0x8FF (2303). This is unused for passthrough. It should be specified as a
        /// hexadecimal string with no &quot;0x&quot; prefix.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PageNumber")]
        public Union<string, IntrinsicFunction> PageNumber { get; set; }

    }
}
